using FoodAPI.Models.Common;

namespace FoodAPI.Models.Entity.Orders
{
    public class Order : Auditable
    {
        public List<OrderInFood> orderInFoods { get; set; }
        public long Price { get; set; }

        public Order()
        {
            orderInFoods = new List<OrderInFood>();
        }
    }
}
