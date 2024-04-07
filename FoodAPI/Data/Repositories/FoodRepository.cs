using FoodAPI.Data.dbcontext;
using FoodAPI.Data.IRepositories;
using FoodAPI.Models.Entity.Foods;
using FoodAPI.Models.Entity.Orders;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Data.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        private readonly AppDbContext _context;


        public FoodRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Food> Create(Food food)
        {
           await _context.foods.AddAsync(food);
            await _context.SaveChangesAsync();
            return food;
        }

        public  async Task<Food> Delete(Food food)
        {
            var value = await _context.foods.FirstOrDefaultAsync(a=>a.Id==food.Id);
            if (value != null)
            {
                _context.Remove(value);
                _context.SaveChanges();
            }
           else
            {
                throw new Exception("This is Food not found!");
            }
            return food;
        }

       
        public async Task<List<Food>> GetAllFood()
        {
            var foodlist = await _context.foods.ToListAsync();
            if (foodlist == null)
            {
                throw new Exception("This are Food not found!");
            }
            else 
            {
                return foodlist;
            }
            return new List<Food>();
        }

  

        public async Task<Food> Update(Food food)
        {

            var oldfood = await _context.foods.FirstOrDefaultAsync(a => a.Id == food.Id);
            if (oldfood != null)
            {
                oldfood.Name=food.Name; 
                oldfood.Price=food.Price;
                oldfood.Info=food.Info;
                oldfood.mail=food.mail;
                await _context.SaveChangesAsync(); 
              
            }
            else
            { throw new Exception("This is Food not found!"); }
            return food;
         
        }

       
    }
}
