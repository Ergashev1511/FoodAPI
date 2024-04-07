using FoodAPI.Models.Common;
using FoodAPI.Models.Enums;

namespace FoodAPI.Models.Entity.Foods
{
    public class Food : Auditable
    {
        public string Name  { get; set; }
        public string Info { get; set; }
        public long Price { get; set; }
        public Mail mail { get; set; }
    }
}
