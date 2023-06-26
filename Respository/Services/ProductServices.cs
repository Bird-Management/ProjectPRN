using Respository.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
                var listAllProduct = _context.Product.ToList();
                if (listAllProduct != null)
                {
                    return listAllProduct;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
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

        public Category GetCategoryById(String categoryId)
        {
            try
            {
                var category = _context.Category.FirstOrDefault(c => c.CategoryId == categoryId);
                return category;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving category: " + ex.Message);
            }
        }

        public List<Category> GetAllCategories()
        {
            return _context.Category.ToList();
        }

        public bool UpdateProduct(Product updatedProduct)
        {
            try
            {
                var existingProduct = _context.Product.Find(updatedProduct.ProductId);
                if (existingProduct == null)
                    return false;

                existingProduct.ProductName = updatedProduct.ProductName;
                existingProduct.Quantity = updatedProduct.Quantity;
                existingProduct.Description = updatedProduct.Description;
                existingProduct.Price = updatedProduct.Price;
                existingProduct.CategoryId = updatedProduct.CategoryId;

                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}