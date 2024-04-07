using FoodAPI.Models.Common;
using FoodAPI.Models.Entity.Foods;

namespace FoodAPI.Models.Entity.Orders
{
    public class OrderInFood: Auditable
    {
        public Food  foods { get; set; }
        public int Amount { get; set; }
        public long Price { get; set; }
    }
}
