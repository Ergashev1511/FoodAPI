using FoodAPI.Models.Entity.Foods;
using FoodAPI.Models.Entity.Orders;
using FoodAPI.Models.Entity.Tables;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Data.dbcontext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }   


        public DbSet<Food> foods { get; set; }

        public DbSet<Order> order { get; set; }
        public DbSet<OrderInFood> orderInFoods { get; set; }
        public DbSet<Table> tables { get; set; }
    }
}
