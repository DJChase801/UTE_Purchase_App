using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTE_Product_Purchase
{
    public class ProductModel
    {
        public ProductModel() 
        {
            
        }

        public void SetByteImg()
        {
            using (var ms = new MemoryStream())
            {
                ProductImg.Save(ms, ProductImg.RawFormat);
                ProductByteImg = ms.ToArray();
            }
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductUPC { get; set; }
        public Image ProductImg { get; set; }
        public byte[] ProductByteImg { get; set; }
    }
}
