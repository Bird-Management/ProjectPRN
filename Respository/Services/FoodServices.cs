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
                if (foodList != null)
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

        public List<Producer> GetProducerList()
        {
            try
            {
                var producerList = this._context.Producer.ToList();
                if (producerList != null)
                {
                    return producerList;
                }
                else
                {
                    return null;
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }         
        }

        public Food AddNewFood(string foodID, string foodName, DateTime dateStart, DateTime dateEnd, 
                                    int amount, float price, string prducer, bool status)
        {
            try
            {
                var newFood = new Food();
                newFood.FoodId = foodID;
                newFood.FoodName = foodName;
                newFood.StartDate = dateStart;
                newFood.EndDate = dateEnd;
                newFood.Amount = amount;
                newFood.Price = price;
                newFood.Status = status;
                newFood.Producer = prducer;

                this._context.Add(newFood);
                this._context.SaveChanges();

                return newFood;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
