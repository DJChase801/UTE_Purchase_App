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
    public partial class ProductControl : UserControl
    {
        public ProductControl(string name, string price, Image pic, string upc)
        {
            InitializeComponent();
            prodNameLbl.Text = name;
            prodPriceLbl.Text = price;
            prodUPCLabel.Text = upc; 
            prodPic.Image = pic;
            ProdName = name;
            Price = price;
            Pic = pic;
            UPC = upc; 
        }
        public string ProdName { get; set; }
        public string Price { get; set; }
        public Image Pic { get; set; }
        public string UPC { get; set; }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            ControlCollection cntrls = Parent.Controls;
            cntrls.Remove(this);
            for (int i = 0; i < cntrls.Count; i++)
            {
                cntrls[i].Location = new Point(10, i * 110 + 10);
            }
        }
    }
}
