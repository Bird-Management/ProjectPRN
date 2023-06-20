using Respository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class CartServices
    {
        private readonly BirdManagementContext _context;

        public CartServices(BirdManagementContext context)
        {
            _context = context;
        }

        public bool addToCart(int id, string title, decimal price)
        {
            try
            {
                var check = this._context.Cart.Where(x => x.ProductId.Equals(id)).FirstOrDefault();
                if (check != null)
                {
                    check.Amount += 1;
                    this._context.SaveChanges();
                    return true;
                } else
                {
                    var newCart = new Cart();
                    newCart.ProductId = id;
                    newCart.Title = title;
                    newCart.Price = price;
                    newCart.Amount = 1;
                    
                    _context.Cart.Add(newCart);
                    _context.SaveChanges();
                    return true;
                }

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Cart> getCarts()
        {
            try
            {
                var listCart = this._context.Cart.ToList();
                if (listCart != null)
                {
                    return listCart;
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
    