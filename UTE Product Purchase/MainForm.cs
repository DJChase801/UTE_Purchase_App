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
            LoadValues(); 
        }

        public List<ProductModel> Products { get; set; }
        public ProductModel Product { get; set; }
        public void LoadValues()
        {
            prodPic.Image = null;
            prodCmbox.Text = "Select...";
            LoadProducts(); 
            LoadProductDropDown(); 
            //Load More info when the time comes such as all members in the list. 
        }

        private void LoadProducts()
        {
            string textFile = GetTextFile();
            try
            {
                string[] lines = File.ReadAllLines(textFile);
                Products = new List<ProductModel>();
                foreach (string line in lines)
                {
                    string[] segments = line.Split('|');
                    ProductModel prod = new ProductModel(segments[0], Convert.ToDouble(segments[1]), segments[2], segments[3]);
                    Products.Add(prod);
                }
            }
            catch
            {

            }
        }

        private void LoadProductDropDown()
        {
            prodCmbox.Items.Clear();
            if (Products != null)
            {

                foreach (ProductModel prod in Products)
                {
                    prodCmbox.Items.Add(prod.Name);
                }

                string folderName = Application.StartupPath.ToString();
                folderName = Path.Combine(folderName, "UTEAPP\\IMAGES\\");
                bool delete = true;
                foreach (string fileName in Directory.GetFiles(folderName))
                {
                    foreach (var e in Products)
                    {
                        if (e.ImgString == fileName)
                        {
                            delete = false;
                        }
                    }
                    if (delete)
                    {
                        try
                        {
                            File.Delete(fileName);
                        }
                        catch
                        {

                        }
                    }
                    delete = true;
                }
            }
        }

        private string GetTextFile()
        {
            string folderName = Application.StartupPath.ToString();
            string pathString = Path.Combine(folderName, "UTEAPP");
            Directory.CreateDirectory(pathString);
            string fileName = "PRODUCTS.txt";
            pathString = Path.Combine(pathString, fileName);

            return pathString; 
        }

        private void prodCmbox_SelectedValueChanged(object sender, EventArgs e)
        {
            StageFormNewProduct(prodCmbox.Text); 
        }


        private void StageFormNewProduct(string name)
        {
            Product = Products.Find(e => e.Name == name);
            prodPic.Image = null; 
            try
            {
                if(Product != null)
                {
                    prodPic.Load(Product.ImgString);
                }
            }
            catch
            {

            }
            prodNameLbl.Text = "Name: " + Product.Name;
            prodPriceLbl.Text = "Price: $" + Product.Price.ToString(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct(); 
        }

        private void AddProduct()
        {
            if (Product != null && prodNameLbl.Text != "Name: ")
            {
                cartList.Items.Add(Product.Name + "............. $" + Product.Price);
                Total += Product.Price;
                totalLbl.Text = "Total: $" + Total.ToString();
            }
            else
            {
                MessageBox.Show("You must select a product to add to the cart.");
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

        public double Total { get; set; }
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (ValidateAccept())
            {
                string folderName = Application.StartupPath.ToString();
                string pathString = Path.Combine(folderName, "UTEAPP");
                Directory.CreateDirectory(pathString);
                string fileName = "DATA.txt";
                pathString = Path.Combine(pathString, fileName);

                using (StreamWriter writer = new StreamWriter(pathString, append: true))
                {
                    foreach (string item in cartList.Items)
                    {
                        string[] cartIt = item.Replace(" ", "").Split('$'); 
                        writer.WriteLine(memNameTB.Text.Trim() + "|" + cartIt[0].Replace(".", "") + "|" + cartIt[1] + "|" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    }
                }

                ClearApplication();
                MessageBox.Show("Success!"); 
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
                DialogResult answer = MessageBox.Show("Are you, " + memNameTB.Text +  " sure you want to commit these charges to your membership fee?", "Check Out", MessageBoxButtons.YesNo);
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

        private void ScanFormNewProduct(string sku)
        {
            Product = Products.Find(e => e.Sku == sku);
            prodPic.Image = null;
            try
            {
                if (Product != null)
                {
                    prodPic.Load(Product.ImgString);
                    prodNameLbl.Text = "Name: " + Product.Name;
                    prodPriceLbl.Text = "Price: $" + Product.Price.ToString();
                }
            }
            catch
            {

            }
        }
    }
}
