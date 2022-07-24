using System.ComponentModel.DataAnnotations.Schema;


namespace furniture_Production.Classes
{
    [Table("Employee")]
    internal class Employee:Person
    {
        public string? Post { get; set; }//удалить эту строку
        public int Experience { get; set; }
        public List<Product> Products { get; set; } = new();
        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public char Gender { get; set; }
    }
}
