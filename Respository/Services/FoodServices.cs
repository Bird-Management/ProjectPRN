using Respository.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //public List<Food> GetFoods()
        //{
        //    try
        //    {
        //        var foodList = this._context.Food.ToList();
        //        if (foodList != null)
        //        {
        //            return foodList;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        public List<Food> GetFoodsOther()
        {
            try
            {
                var check = this._context.Food.Select(x => new Food
                {
                    FoodId = x.FoodId,
                    FoodName = x.FoodName,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Producer = x.Producer,
                    Amount = x.Amount,
                    Price = x.Price,
                    Status = x.Status,
                })
                .ToList();

                if(check != null)
                {
                    return check;
                } return null;
            }catch (Exception ex)
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

        public bool IsValidFoodID(string fID)
        {
            string pattern = @"^F\d{4}$";
            return Regex.IsMatch(fID, pattern);

        }

        public bool FoodIdIsExist(string fID)
        {
            return _context.Food.Any(x => x.FoodId == fID);
        }

        //public bool IsValidPriceVND(float price)
        //{
        //    string pricePattern = @"^([1-9]\d{3,}|[1-9]\d{2,}\d*VND)$"; // Định dạng giá cả: lớn hơn 1000 hoặc có dạng "số lượng dương + VND"
        //    string priceString = price.ToString(); // Chuyển đổi giá trị price thành chuỗi
        //    return Regex.IsMatch(priceString, pricePattern);
        //}


        public bool DeleteFood(string foodID)
        {
            try
            {
                var check = this._context.Food.FirstOrDefault(x => x.FoodId == foodID);
                if (check != null)
                {
                    _context.Food.Remove(check);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }

        public void UpdateFood(string foodID, string foodName, DateTime startDate, DateTime endDate, 
                                    string producer, float price, int amount, bool status)
        {
            try
            {
                var foodToUpdate = _context.Food.FirstOrDefault(x => x.FoodId == foodID);
                if (foodToUpdate != null)
                {
                    foodToUpdate.FoodName = foodName;
                    foodToUpdate.StartDate = startDate;
                    foodToUpdate.EndDate = endDate;
                    foodToUpdate.Producer = producer;
                    foodToUpdate.Price = price;
                    foodToUpdate.Amount = amount;
                    foodToUpdate.Status = status;

                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Food SearchFood(string searchID)
        {
            try
            {
                var searchResults = this._context.Food.Where(x => x.FoodId.Contains(searchID)).Select(
                    x => new Food
                    {
                        FoodId = x.FoodId,
                        FoodName = x.FoodName,
                        Price = x.Price,
                        StartDate = x.StartDate,
                        EndDate = x.EndDate,
                        Producer = x.Producer,
                        Amount = x.Amount,
                        Status = x.Status
                    }).FirstOrDefault();
                if (searchResults != null)
                {
                    return searchResults;
                }
                return null;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }


    }
}
