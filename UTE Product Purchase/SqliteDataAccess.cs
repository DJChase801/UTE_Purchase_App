using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTE_Product_Purchase
{
    public class SqliteDataAccess
    {
        public static List<ProductModel> LoadProducts()
        {
            List<ProductModel> prods = new List<ProductModel>(); 
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var outputs = cnn.Query("Select * from Product order by Product.ProductName", new DynamicParameters());
                foreach(var output in outputs)
                {
                    ProductModel prod = new ProductModel();
                    prod.ProductName = output.ProductName;
                    prod.ProductPrice = (Double)output.ProductPrice;
                    prod.ProductUPC = output.ProductUPC;
                    prod.ProductByteImg = output.ProductImg;
                    prod.ProductImg = ByteToImage(prod.ProductByteImg); ;
                    prods.Add(prod); 
                }

                return prods; 
            }
        }
        public static Image ByteToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }
        public static void RemoveProduct(string prodName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Product " +
                    "WHERE Product.ProductName = '" + prodName + "'");
            }
        }
        public static void SaveProduct(ProductModel product)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Product (ProductName, ProductPrice, ProductUPC, ProductIMG)" +
                    " values (@ProductName, @ProductPrice, @ProductUPC, @ProductByteIMG)", product);
            }
        }
        public static void SavePurchase(PurchaseModel purchase)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Purchase (MemberName, ProductName, Date)" +
                    " values (@MemberName, @ProductName, @Date)", purchase);
            }
        }
        /// <summary>
        /// Returns all the purchases data for current month to current day.
        /// </summary>
        /// <returns></returns>
        public static List<PurchaseModel> LoadPurchases()
        {
            var today = DateTime.Now; 
            string start = new DateTime(today.Year, today.Month, 1).ToString("yyyy-MM-dd");
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var outputs = cnn.Query<PurchaseModel>("SELECT * FROM Purchase WHERE Purchase.Date > " +
                    "dateTime(" + start + ")", new DynamicParameters());

                return outputs.ToList();
            }
        }
        /// <summary>
        /// returns the purchases data from the db between the dates on the date time pickers.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static List<PurchaseModel> LoadSpecificPurchases(string start, string end)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var outputs = cnn.Query<PurchaseModel>("Select * from Purchase " +
                    "WHERE Purchase.Date > dateTime(" + start +") "
                    , new DynamicParameters());

                outputs = (from outRecs in outputs
                           where DateTime.Parse(outRecs.Date) <= DateTime.Parse(end).AddDays(1)
                           select outRecs).ToList();


                return outputs.ToList();
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString; 
        }

        
    }
}
