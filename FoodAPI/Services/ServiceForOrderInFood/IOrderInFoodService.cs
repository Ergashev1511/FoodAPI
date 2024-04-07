using FoodAPI.Models.Entity.Orders;

using FoodAPI.Models.Entity.Orders;

namespace FoodAPI.Services.ServiceForOrderInFood
{
    public interface IOrderInFoodService
    {
        Task<OrderInFood>  Create(OrderInFood orderInFood);
        Task<OrderInFood> Update(OrderInFood orderInFood);  
        Task<OrderInFood> Delete(OrderInFood orderInFood);
        Task<List<OrderInFood>> GetAll();
    }
}
