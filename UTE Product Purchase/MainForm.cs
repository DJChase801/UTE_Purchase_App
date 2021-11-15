using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTE_Product_Purchase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetUpDataBase(); 
            LoadValues();
        }
        public string  AppDB { get; set; }
        private void SetUpDataBase()
        {

            string fileName = "UteDataBase.db";
            string sourcePath = @".\";
            string targetPath = @"C:\UTE APP\Back Up Folder";

            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            Directory.CreateDirectory(targetPath);

            // To copy a file to another location and
            // overwrite the destination file if it already exists.
            if (!File.Exists(destFile))
            {
                File.Copy(sourceFile, destFile, true);
            }
            AppDB = destFile; 
        }

        public List<ProductModel> Products { get; set; }
        public ProductModel Product { get; set; }
        public void LoadValues()
        {
            prodPic.Image = null;
            prodCmbox.Text = "Select...";
            Products = SqliteDataAccess.LoadProducts();
            LoadProductDropDown(); 
            //Load More info when the time comes such as all members in the list. 
        }

        private void LoadProductDropDown()
        {
            prodCmbox.Items.Clear();
            if (Products != null)
            {

                foreach (ProductModel prod in Products)
                {
                    prodCmbox.Items.Add(prod.ProductName);
                }
            }
        }

        private void prodCmbox_SelectedValueChanged(object sender, EventArgs e)
        {
            StageFormNewProduct(prodCmbox.Text); 
        }


        private void StageFormNewProduct(string name)
        {
            Product = Products.Find(e => e.ProductName == name);
            prodPic.Image = Product.ProductImg; 
            prodNameLbl.Text = "Name: " + Product.ProductName;
            prodPriceLbl.Text = "Price: $" + Product.ProductPrice.ToString("##.00"); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct(); 
        }

        private void AddProduct()
        {
            if (Product != null && prodNameLbl.Text != "Name: ")
            {
                cartList.Items.Add(Product.ProductName + "................ $" + Product.ProductPrice.ToString("##.00"));
                Total += Product.ProductPrice;
                totalLbl.Text = "Total: $" + Total.ToString("##.00");
            }
            else
            {
                MessageBox.Show("You must select a product to add to the cart. If scanned, barcode may be unavailable in program.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ClearApplication(); 
        }

        private void ClearApplication()
        {
            memNameTB.Text = "";
            scanTextBox.Text = ""; 
            prodCmbox.Text = "Select...";
            prodNameLbl.Text = "Name:";
            prodPriceLbl.Text = "Price:";
            totalLbl.Text = "Total:";
            Total = 0; 
            prodPic.Image = null;
            cartList.Items.Clear(); 
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(cartList.SelectedIndex != -1)
            {
                double remAmnt = Convert.ToDouble(cartList.SelectedItem.ToString().Split('$')[1]);
                Total -= remAmnt;
                totalLbl.Text = "Total: $" + Total; 
                cartList.Items.Remove(cartList.SelectedItem);
            }
        }
        /// <summary>
        /// Keeps the running total for the application.
        /// </summary>
        public double Total { get; set; }
        /// <summary>
        /// Passes the information to the add purchase method and clears the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (ValidateAccept())
            {
                AddPurchases(cartList.Items); 

                ClearApplication();
                MessageBox.Show("Success!"); 
            }
        }
        /// <summary>
        /// Writes the purchase record to the database.
        /// </summary>
        /// <param name="items"></param>
        private void AddPurchases(ListBox.ObjectCollection items)
        {
            foreach(string item in items)
            {
                string[] cartIt = item.Replace(" ", "").Split('$');
                PurchaseModel p = new PurchaseModel();
                p.MemberName = memNameTB.Text.Trim();
                p.ProductName = cartIt[0].Replace(".", "");
                p.Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                SqliteDataAccess.SavePurchase(p); 
            }
        }

        private bool ValidateAccept()
        {
            string error = "Error:\n";
            
            if(memNameTB.Text == "")
            {
                error += "- You must input the member name first\n"; 
            }

            if(cartList.Items.Count == 0)
            {
                error += "- You must select at least one product."; 
            }

            if(error == "Error:\n")
            {
                DialogResult answer = MessageBox.Show("Do you, " + memNameTB.Text + ", agree to the total charges of $" + Total.ToString("##.00"), "Check Out", MessageBoxButtons.YesNo);
                if (answer == DialogResult.No)
                {
                    return false;
                }
                return true; 
            }
            else
            {
                MessageBox.Show(error);
                return false; 
            }
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            ClearApplication(); 
            AdminStart start = new AdminStart(this);
            start.Show(); 
        }

        private void scanTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(scanTextBox.Text != "" && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                ScanFormNewProduct(scanTextBox.Text);
                AddProduct();
                scanTextBox.Text = ""; 
            }
        }

        private void ScanFormNewProduct(string upc)
        {
            Product = Products.Find(e => e.ProductUPC == upc);
            try
            {
                if (Product != null)
                {
                    prodPic.Image = Product.ProductImg;
                    prodCmbox.Text = Product.ProductName; 
                    prodNameLbl.Text = "Name: " + Product.ProductName;
                    prodPriceLbl.Text = "Price: $" + Product.ProductPrice.ToString();
                }
                else
                {
                    prodCmbox.Text = "Select..."; 
                    prodNameLbl.Text = "Name: ";
                    prodPriceLbl.Text = "Price: ";
                    prodPic.Image = null;
                }
            }
            catch
            {

            }
        }
    }
}
