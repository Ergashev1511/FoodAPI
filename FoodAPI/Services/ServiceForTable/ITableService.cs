using FoodAPI.Models.Entity.Tables;

namespace FoodAPI.Services.ServiceForTable
{
    public interface ITableService
    {
         Task<Table> Create(Table table);

        Task<Table> Update(Table table);
        Task<Table> Delete(Table table);
        Task<List<Table>> GetAll();
    }
}
