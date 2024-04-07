using FoodAPI.Models.Entity.Foods;

namespace FoodAPI.Data.IRepositories
{
    public interface IFoodRepository
    {

        Task<Food> Create(Food food);
        Task<Food> Update(Food food);
        Task<Food> Delete(Food food);
        Task<List<Food>> GetAllFood();

    }
}
