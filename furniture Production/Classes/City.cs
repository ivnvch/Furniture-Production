using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furniture_Production.Classes
{
    internal class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Company> Company { get; set; } = new();
        public string? Populations { get; set; }
    }
}
