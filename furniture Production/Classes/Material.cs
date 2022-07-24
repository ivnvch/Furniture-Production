using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furniture_Production.Classes
{
    internal class Material
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal? Price { get; set; }
        public List<Product> Products { get; set; } = new();//отношение многие ко многим к таблице Product
        public List<Provider> Providers { get; set; } = new();//отношение многие ко многим к таблице Provider
        //public string? Materials { get; set; }
        
    }
}
