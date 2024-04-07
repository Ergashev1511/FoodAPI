using FoodAPI.Models.Entity.Orders;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace FoodAPI.Data.IRepositories
{
    public interface IOrderInFoodRepository
    {
        Task<OrderInFood> Create(OrderInFood orderInFood);  
        Task<OrderInFood> Update(OrderInFood orderInFood);
        Task<OrderInFood> Delete(OrderInFood orderInFood);
        Task<List<OrderInFood>> GetAll();
    }
}
