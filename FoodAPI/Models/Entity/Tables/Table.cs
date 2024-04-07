
using FoodAPI.Models.Common;
using FoodAPI.Models.Entity.Orders;

namespace FoodAPI.Models.Entity.Tables
{
    public class Table : Auditable
    {
        public string Info { get; set; }
        public Order? order { get; set; }
    }
}
