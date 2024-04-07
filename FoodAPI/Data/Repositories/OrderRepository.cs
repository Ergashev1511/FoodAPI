using FoodAPI.Data.dbcontext;
using FoodAPI.Data.IRepositories;
using FoodAPI.Models.Entity.Orders;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly  AppDbContext _context;
        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Order> Create(Order order)
        {
            await _context.order.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<Order> Delete(Order order)
        {
            var oldorder=await _context.order.FirstOrDefaultAsync(a=>a.Id==order.Id);
              if(oldorder!=null)
            {
                 _context.order.Remove(order);
                await _context.SaveChangesAsync();  
            }
              else
            {
                throw new Exception("This is Order not found!");
            }
              return order;
        }

        public async Task<List<Order>> GetAll()
        {
            var orderlist=await _context.order.ToListAsync();
            return orderlist;
        }

        public async Task<Order> Update(Order order)
        {
            var oldorder = await _context.order.FirstOrDefaultAsync(a => a.Id == order.Id);
         if(oldorder != null)
            {
                oldorder.Price = order.Price;
                oldorder.orderInFoods = order.orderInFoods;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("This is Order not found!");
            }
         return order;

        }
    }
}
