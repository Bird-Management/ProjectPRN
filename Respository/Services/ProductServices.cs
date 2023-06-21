using Respository.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository.Services
{
    public class ProductServices
    {
        private readonly BirdManagementContext _context;

        public ProductServices(BirdManagementContext context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            try
            {
                var listAllProduct = this._context.Product.ToList();
                if (listAllProduct != null )
                {
                    return listAllProduct;
                }
                else
                {
                    return null;
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Product GetProductById(string productId)
        {
            try
            {
                var product = _context.Product.FirstOrDefault(p => p.ProductId == productId);
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving product: " + ex.Message);
            }
        }

        public bool DeleteProduct(string productId)
        {
            try
            {
                var product = _context.Product.FirstOrDefault(p => p.ProductId == productId);

                if (product != null)
                {
                    _context.Product.Remove(product);
                    _context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting product: " + ex.Message);
            }
        }

    }
}
