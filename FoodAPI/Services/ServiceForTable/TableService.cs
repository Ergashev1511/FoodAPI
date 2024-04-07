using FoodAPI.Data.IRepositories;
using FoodAPI.Models.Entity.Tables;

namespace FoodAPI.Services.ServiceForTable
{
    public class TableService : ITableService
    {
        private readonly ITableRepository _repository;

        public TableService(ITableRepository repository)
        {
            _repository = repository;
        }


        public async Task<Table> Create(Table table)
        {
           return await _repository.Create(table);
        }

        public async Task<Table> Delete(Table table)
        {
           return await _repository.Delete(table);
        }

        public  async Task<List<Table>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Table> Update(Table table)
        {
            return await _repository.Update(table); 
        }
    }
}
