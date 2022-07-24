using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furniture_Production.Classes
{
    internal class Provider
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Material> Materials { get; set; } = new();//отношение многие ко многим с таблицей Material
    }
}
