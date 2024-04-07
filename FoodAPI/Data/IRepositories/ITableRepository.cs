using FoodAPI.Models.Entity.Tables;

namespace FoodAPI.Data.IRepositories
{
    public interface ITableRepository
    {
        Task<Table> Create(Table table);
        Task<Table> Update(Table table);
        Task<Table> Delete(Table table);
        Task<List<Table>> GetAll();

    }
}
