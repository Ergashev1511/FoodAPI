using FoodAPI.Models.Entity.Foods;
using FoodAPI.Services.ServiceForFood;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _service;
        public FoodController(IFoodService service)
        {
            _service = service;
        }


        [HttpPost]
        public async ValueTask<ActionResult>  Create(Food food)
            =>Ok(await _service.Create(food));


        [HttpGet]
        public async ValueTask<ActionResult> GetAall()
            =>Ok(await _service.GetAllFood());


        [HttpPut]
        public  async ValueTask<ActionResult> Update(Food food)
            =>Ok(await _service.Update(food));


        [HttpDelete]
        public async ValueTask<ActionResult> Delete(Food food)
            =>Ok(await _service.Delete(food));
    }
}
