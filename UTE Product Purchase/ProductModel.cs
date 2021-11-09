using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTE_Product_Purchase
{
    public class ProductModel
    {
        public ProductModel(string name, double price, string imgString, string skuString)
        {
            Name = name;
            Price = price;
            ImgString = imgString;
            Sku = skuString; 
        }

        public string Name { get; set; }
        public Image Img { get; set; }
        public double Price { get; set; }
        public string ImgString { get; set; }
        public string Sku { get; set; }
    }
}
