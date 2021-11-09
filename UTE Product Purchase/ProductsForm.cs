using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (nameInputTb.Text != "" && priceInputTb.Text != "")
            {
                AddProductControl(nameInputTb.Text, priceInputTb.Text, inputPicBox.Image, upcTextBox.Text);
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

        private void AddProductControl(string name, string price, Image image, string upc)
        {
            ProductControl prod = new ProductControl(name, price, image, upc);
            prod.Location = new Point(10, prodPanel.Controls.Count * 110 + 10);

            prodPanel.Controls.Add(prod);
        }

        public string PicLoc { get; set; }
        private void getImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.jfif)|*.jpg; *.jpeg; *.gif; *.bmp; *.jfif" ;
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                inputPicBox.Image = new Bitmap(open.FileName);
                // image file path  
                PicLoc = open.FileName;
            }
        }

        private void saveProdBtn_Click(object sender, EventArgs e)
        {
            string folderName = Application.StartupPath.ToString();
            string pathString = Path.Combine(folderName, "UTEAPP");
            Directory.CreateDirectory(pathString);
            string fileName = "PRODUCTS.txt";
            fileName = Path.Combine(pathString, fileName);
            pathString = Path.Combine(pathString, "IMAGES\\");
            Directory.CreateDirectory(pathString);

            using (StreamWriter writer = new StreamWriter(fileName, append: false))
            {
                foreach (ProductControl cntrl in prodPanel.Controls)
                {
                    string picName = pathString + cntrl.ProdName + ".jpg";
                    try
                    {
                        if(cntrl.Pic != null)
                        {
                            cntrl.Pic.Save(picName);
                        }
                    }
                    catch
                    {

                    }
                    writer.WriteLine(cntrl.ProdName + "|" + cntrl.Price + "|" + picName + "|" + cntrl.UPC);
                }
            }

            MainForm.LoadValues(); 
            Close();
        }
        private void LoadProds()
        {
            try
            {

                string folderName = Application.StartupPath.ToString();
                string pathString = Path.Combine(folderName, "UTEAPP");
                Directory.CreateDirectory(pathString);
                string fileName = "PRODUCTS.txt";
                fileName = Path.Combine(pathString, fileName);
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(fileName);
                Image pic = null;
                foreach (string line in lines)
                {
                    string[] segments = line.Split('|');
                    try
                    {
                        pic = Image.FromFile(segments[2]);
                    }
                    catch
                    {
                        pic = null;
                    }
                    AddProductControl(segments[0], segments[1], pic, segments[3]);
                }
            }
            catch
            {

            }
        }
    }
}
