using FoodAPI.Data.dbcontext;
using FoodAPI.Data.IRepositories;
using FoodAPI.Models.Entity.Orders;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Data.Repositories
{
    public class OrderInFoodRepository : IOrderInFoodRepository
    {
        private readonly AppDbContext _context;
        public OrderInFoodRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<OrderInFood> Create(OrderInFood orderInFood)
        {
            await _context.orderInFoods.AddAsync(orderInFood);
            await _context.SaveChangesAsync();
            return orderInFood;
        }

        public  async Task<OrderInFood> Delete(OrderInFood orderInFood)
        {
            var old= await _context.orderInFoods.FirstOrDefaultAsync(a=>a.Id==orderInFood.Id);
          if (old == null)
            {
                _context.orderInFoods.Remove(old);
              _context.SaveChanges();
            }
          else
            {
                throw new Exception("This is OrderInFood not found!");
            }
            return orderInFood;
        }
        

        public async Task<List<OrderInFood>> GetAll()
        {
            var orderinfoodlist= await _context.orderInFoods.ToListAsync();
            if(orderinfoodlist != null)
            {
                return orderinfoodlist; 
            }
            else
            {
                throw new Exception("This are Orderinfoods not found!");
            }
            return new List<OrderInFood>(); 
        }

        public async Task<OrderInFood> Update(OrderInFood orderInFood)
        {
           var old= await _context.orderInFoods.FirstOrDefaultAsync(a=>a.Id==orderInFood.Id);
            if(old != null)
            {
                old.Price = orderInFood.Price;
                old.foods=orderInFood.foods;
                old.Amount=orderInFood.Amount;
                old.IsCreated=orderInFood.IsCreated;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("This is Orderinfood not found!");
            }
            return orderInFood;       
        }
    }
}
