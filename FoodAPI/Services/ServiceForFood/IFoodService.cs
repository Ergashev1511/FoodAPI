using FoodAPI.Models.Entity.Foods;

namespace FoodAPI.Services.ServiceForFood
{
    public interface IFoodService
    {
        Task<Food> Create(Food food);
        Task<Food> Update(Food food);
        Task<Food> Delete(Food food);
        Task<List<Food>> GetAllFood();
    }
}
