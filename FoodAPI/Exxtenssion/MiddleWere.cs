using FoodAPI.Data.dbcontext;
using FoodAPI.Data.IRepositories;
using FoodAPI.Data.Repositories;
using FoodAPI.Services.ServiceForFood;
using FoodAPI.Services.ServiceForOrder;
using FoodAPI.Services.ServiceForOrderInFood;
using FoodAPI.Services.ServiceForTable;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Exxtenssion
{
    public static class MiddleWere
    {
        public static void AddDBConTextes(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IFoodRepository, FoodRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderInFoodRepository, OrderInFoodRepository>();
            services.AddTransient<ITableRepository, TableRepository>();

        }

        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<IFoodService, FoodService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IOrderInFoodService, OrderInFoodService>();
            services.AddTransient<ITableService, TableService>();
        }
    }
}
