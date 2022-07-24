using System.ComponentModel.DataAnnotations.Schema;


namespace furniture_Production.Classes
{
    [Table("EndProduct")]
    internal class End_Product: Product
    {
        public decimal Cost { get; set; }
        public List<Order> orders { get; set; } = new();
    }
}
