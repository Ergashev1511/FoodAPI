using FoodAPI.Data.dbcontext;
using FoodAPI.Data.IRepositories;
using FoodAPI.Models.Entity.Tables;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.Data.Repositories
{
    public class TableRepository : ITableRepository
    {
        private readonly AppDbContext _context;
        public TableRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Table> Create(Table table)
        {
            await _context.tables.AddAsync(table);
            await _context.SaveChangesAsync();
            return table;
        }

        public async Task<Table> Delete(Table table)
        {
            var old= await _context.tables.FirstOrDefaultAsync(a=>a.Id==table.Id);
            if(old!=null)
            {
                _context.tables.Remove(old);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("This is Table not found");
            }
            return table;
        }


        public async Task<List<Table>> GetAll()
        {
           var tablelist= await _context.tables.ToListAsync();
            if(tablelist!=null)
            {  
               return tablelist;
            }
            else 
            { 
                throw new Exception("This are Tables bot founnd!");
            }
            return new List<Table>();
        }

        public async Task<Table> Update(Table table)
        {
            var old = await _context.tables.FirstOrDefaultAsync(a => a.Id == table.Id);
            if(old!=null)
            {
                old.order=table.order;
                old.Info=table.Info;
                old.IsCreated = table.IsCreated;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("This  is Table not found!");
            }
            return table;   
        }
    }
}
