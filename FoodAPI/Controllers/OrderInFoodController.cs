using FoodAPI.Models.Entity.Orders;
using FoodAPI.Services.ServiceForOrderInFood;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderInFoodController : ControllerBase
    {
        private readonly IOrderInFoodService _service;

        public OrderInFoodController(IOrderInFoodService service)
        {
            _service = service;
        }

        [HttpPost]

    public async ValueTask<ActionResult> Create(OrderInFood orderInFood)
            =>Ok(await _service.Create(orderInFood));


        [HttpGet]
          public async ValueTask<ActionResult>  GetAll()
            =>Ok(await _service.GetAll());



        [HttpPut]
        public async ValueTask<ActionResult> Update(OrderInFood orderInFood)
            =>Ok(await _service.Update(orderInFood));

        [HttpDelete]
        public async ValueTask<ActionResult> Delete(OrderInFood orderInFood)
            => Ok(await _service.Delete(orderInFood));
    }
}
