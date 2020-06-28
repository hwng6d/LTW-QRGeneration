using QuanLyMaQR_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMaQR_v2.Controllers
{
    public class QRController
    {
        public static bool AddProduct(ListProduct product)
        {
            try
            {
                using (var _context = new DBQuanLyMaQREntities())
                {
                    _context.ListProduct.Add(product);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteProduct(ListProduct product)
        {
                using (var _context = new DBQuanLyMaQREntities())
                {
                    var v = _context.ListProduct.Find(product.STT);
                    _context.ListProduct.Remove(v);
                    _context.SaveChanges();
                    return true;
                }
           
        }
        public static ListProduct getProduct(string productID)
        {
            using (var _context = new DBQuanLyMaQREntities())
            {
                var product = (from u in _context.ListProduct
                               where u.ProductID == productID
                               select u).ToList();
                if (product.Count == 1)
                {
                    return product[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public static List<ListProduct> getListProduct()
        {
            using (var _context = new DBQuanLyMaQREntities())
            {
                var product = (from u in _context.ListProduct
                               select u).ToList();
                return product;
            }
        }

        public static bool UpdateQRProduct(ListProduct product)
        {
            using (var _context = new DBQuanLyMaQREntities())
            {
                _context.ListProduct.AddOrUpdate(product);
                _context.SaveChanges();
                return true;
            }

        }

    }

    
}
