using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furniture_Production.Classes
{
    internal class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CityID { get; set; }
        public City? City { get; set; }
        public List<Employee> Employees { get; set; } = null!;


    }
}
