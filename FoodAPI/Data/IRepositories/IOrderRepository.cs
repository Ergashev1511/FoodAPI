using FoodAPI.Models.Entity.Orders;

namespace FoodAPI.Data.IRepositories
{
    public interface IOrderRepository
    {
        Task<Order>  Create(Order order);
        Task<Order> Update(Order order);
        Task<Order> Delete(Order order);
        Task<List<Order>> GetAll();

    }
}
