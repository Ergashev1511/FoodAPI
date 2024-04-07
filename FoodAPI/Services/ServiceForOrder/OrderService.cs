using FoodAPI.Data.IRepositories;
using FoodAPI.Models.Entity.Orders;

namespace FoodAPI.Services.ServiceForOrder
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }
        public async Task<Order> Create(Order order)
        {
          return await _repository.Create(order);
        }

        public async Task<Order> Delete(Order order)
        {
            return await _repository.Delete(order);
        }

        public async Task<List<Order>> GetAll()
        {
          return await _repository.GetAll();
        }

        public async Task<Order> Update(Order order)
        {
            return await _repository.Update(order);
        }
    }
}
