using FoodAPI.Models.Entity.Tables;
using FoodAPI.Services.ServiceForTable;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableService _service;
        public TableController(ITableService service)
        {
            _service = service;
        }


        [HttpPost]
        public async ValueTask<ActionResult> Create(Table table)
            =>Ok(await _service.Create(table));


        [HttpGet]
        public async ValueTask<ActionResult> GetAll()
            =>Ok(await _service.GetAll());

        [HttpPut]
        public async ValueTask<ActionResult> Update(Table table)
        =>Ok(await _service.Update(table));


        [HttpDelete]
        public async ValueTask<ActionResult>  Delete(Table table)   
            =>Ok(await  _service.Delete(table));
    }
}
