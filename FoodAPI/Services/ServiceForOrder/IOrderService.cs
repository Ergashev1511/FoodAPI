using FoodAPI.Models.Entity.Orders;

namespace FoodAPI.Services.ServiceForOrder
{
    public interface IOrderService
    {
        Task<Order>  Create(Order order);

        Task<Order> Update(Order order);

        Task<Order> Delete(Order order);
        Task<List<Order>> GetAll();

    }
}
