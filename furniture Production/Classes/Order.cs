using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furniture_Production.Classes
{
    internal class Order
    {
        public int Id { get; set; }
        //public string? Name { get; set; }
        public int BuyerId { get; set; }//отношение один ко многим с таблицей Buyer
        public Buyer? Buyer { get; set; }//заказ клиента
        public List<End_Product> Endproducts { get; set; } = new();
    }
}
