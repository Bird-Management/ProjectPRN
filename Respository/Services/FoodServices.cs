using Respository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class FoodServices
    {
        private readonly BirdManagementContext _context;

        public FoodServices(BirdManagementContext context)
        {
            _context = context;
        }

        public List<Food> GetFoods()
        {
            try
            {
                var foodList = this._context.Food.ToList();
                if (foodList.Count > 0)
                {
                    return foodList;
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
    }
}
