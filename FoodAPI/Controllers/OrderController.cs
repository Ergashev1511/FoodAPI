using FoodAPI.Models.Entity.Orders;
using FoodAPI.Services.ServiceForOrder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpPost]
        public async ValueTask<ActionResult> Create(Order order)
            =>Ok(await  _service.Create(order));

        [HttpGet]
        public async ValueTask<ActionResult>  GetAll()
            =>Ok(await _service.GetAll());

        [HttpPut]
        public async ValueTask<ActionResult> Update(Order order)
            =>Ok(await _service.Update(order));

        [HttpDelete]
        public async ValueTask<ActionResult>  Delete(Order order)
            =>Ok( await _service.Delete(order));
    }
}
