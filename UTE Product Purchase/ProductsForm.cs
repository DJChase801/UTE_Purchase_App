using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UTE_Product_Purchase
{
    public partial class ProductsForm : Form
    {
        public ProductsForm(MainForm mf)
        {
            InitializeComponent();
            LoadProds();
            MainForm = mf; 
        }
        public MainForm MainForm { get; set; }
        /// <summary>
        /// Button on the product form to save the product that is being built
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (nameInputTb.Text != "" && priceInputTb.Text != "")
            {
                AddProductControl(nameInputTb.Text, priceInputTb.Text, inputPicBox.Image, upcTextBox.Text);
                SaveProduct(nameInputTb.Text, priceInputTb.Text, inputPicBox.Image, upcTextBox.Text);
                MainForm.LoadValues(); 

                //Resets the form. 
                nameInputTb.Text = "";
                priceInputTb.Text = "";
                upcTextBox.Text = ""; 
                inputPicBox.Image = null; 
            }
            else
            {
                MessageBox.Show("You must enter a Name and Price");
            }
        }
        /// <summary>
        /// Saves a product to the application database. 
        /// </summary>
        /// <param name="prodName"></param>
        /// <param name="prodPrice"></param>
        /// <param name="prodImg"></param>
        /// <param name="prodUPC"></param>
        private void SaveProduct(string prodName, string prodPrice, Image prodImg, string prodUPC)
        {
            ProductModel prod = new ProductModel();
            prod.ProductName = prodName;
            prod.ProductPrice = Convert.ToDouble(prodPrice.Replace("$", ""));
            prod.ProductImg = prodImg;
            prod.ProductUPC = prodUPC;
            prod.SetByteImg(); 

            SqliteDataAccess.SaveProduct(prod); 
        }
        /// <summary>
        /// Sets the product control in the list of products.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="image"></param>
        /// <param name="upc"></param>
        private void AddProductControl(string name, string price, Image image, string upc)
        {
            ProductControl prod = new ProductControl(name, price, image, upc);
            prod.Location = new Point(10, prodPanel.Controls.Count * 110 + 10);

            prodPanel.Controls.Add(prod);
        }

        /// <summary>
        /// Opens a file dialog to select a IMG file for the product being created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.jfif)|*.jpg; *.jpeg; *.gif; *.bmp; *.jfif" ;
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                inputPicBox.Image = new Bitmap(open.FileName);
            }
        }

        /// <summary>
        /// Loads all the products from the db to controls on the product view form.
        /// </summary>
        public void LoadProds()
        {
            List<ProductModel> prods = new List<ProductModel>(); 
            prods = SqliteDataAccess.LoadProducts(); 
            foreach(ProductModel prod in prods)
            {
                prod.ProductImg = ByteToImage(prod.ProductByteImg); 
                AddProductControl(prod.ProductName, prod.ProductPrice.ToString(), prod.ProductImg, prod.ProductUPC); 
            }
        }
        /// <summary>
        /// Reverts the Image that comes out of the database back to Image type.
        /// </summary>
        /// <param name="imageBytes"></param>
        /// <returns></returns>
        public Image ByteToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }
    }
}
