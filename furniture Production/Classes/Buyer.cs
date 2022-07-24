using System.ComponentModel.DataAnnotations.Schema;

namespace furniture_Production.Classes
{
    [Table("Clients")]
    internal class Buyer : Person
    {
        public string? NumberPhone { get; set; }
       // public List<End_Product> products = new List<End_Product>();
        public List<Order> orders = new List<Order>();//отношение одник ко многим с таблицей Order
      
       
    }
}
