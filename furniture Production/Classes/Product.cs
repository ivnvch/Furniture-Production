using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furniture_Production.Classes
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Material> materials { get; set; } = new();//отношение, многие ко многим с таблицей Material
        public List<Employee> employees { get; set; } = new();
        public string? Color { get; set; }

    }
}
