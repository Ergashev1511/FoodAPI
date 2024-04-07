using FoodAPI.Data.IRepositories;
using FoodAPI.Models.Entity.Orders;

namespace FoodAPI.Services.ServiceForOrderInFood
{
    public class OrderInFoodService : IOrderInFoodService
    {

        private readonly IOrderInFoodRepository _repository;

        public OrderInFoodService(IOrderInFoodRepository repository)
        {
            _repository = repository;
        }
        public async Task<OrderInFood> Create(OrderInFood orderInFood)
        {
        return await _repository.Create(orderInFood); 
        }

        public async Task<OrderInFood> Delete(OrderInFood orderInFood)
        {
           return await (_repository.Delete(orderInFood));
        }

        public async Task<List<OrderInFood>> GetAll()
        {
            return  await _repository.GetAll();
        }

        public async Task<OrderInFood> Update(OrderInFood orderInFood)
        {
           return await _repository.Update(orderInFood);
        }
    }
}
