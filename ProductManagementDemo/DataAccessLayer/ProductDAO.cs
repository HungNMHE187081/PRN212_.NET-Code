using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.Models;


namespace DataAccessLayer
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();
            try
            {
                using var db = new MyStoreContext();
                listProducts = db.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

            return listProducts;
        }
    }

    public static void SaveProduct(Product product)
    {
        try
        {
            using var context = new MyStoreContext();
            context.Products.Add(product);
            context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message);
        }
    }

    public static void UpdateProduct(Product product)
    {
        try
        {
            using var context = new MyStoreContext();
            context.Products.Update(product);
            context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message);
        }
    }
}
