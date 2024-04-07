using FoodAPI.Data.IRepositories;
using FoodAPI.Models.Entity.Foods;

namespace FoodAPI.Services.ServiceForFood
{
    public class FoodService : IFoodService
    {

        private readonly IFoodRepository _repository;
        public FoodService(IFoodRepository repository)
        {
            _repository = repository;   
        }
        public async Task<Food> Create(Food food)
        {
           return await _repository.Create(food);
        }

        public async Task<Food> Delete(Food food)
        {
          return await (_repository.Delete(food));
        }

        public async Task<List<Food>> GetAllFood()
        {
            return await _repository.GetAllFood();
        }

        public async Task<Food> Update(Food food)
        {
          return await _repository.Update(food);  
        }
    }
}
