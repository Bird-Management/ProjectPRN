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
                    DataTable dtProduct = new DataTable();
                    dtProduct.Columns.Add("Image", Type.GetType("System.Byte[]"));
                    foreach (DataRow dr in dtProduct.Rows)
                    {
                        dr["Image"] = File.ReadAllBytes(dr["image"].ToString());
                    }
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
    }
}
