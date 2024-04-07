namespace FoodAPI.Models.Common
{
    public class Auditable
    {
        public int Id { get; set; }
        public string IsCreated { get; set; } = DateTime.Now.ToString();
    }
}
