using furniture_Production.Classes;
using Microsoft.EntityFrameworkCore;

namespace furniture_Production
{
    internal class ProductionContent : DbContext
    {
       public ProductionContent() => Database.EnsureCreated();//удаляю и создаю БД
        

        public DbSet<Buyer> Buyers { get; set; } = null!;
        public DbSet<City> Cities {get; set;} = null!;
        public DbSet<Company> Companies {get; set;} = null!;
        public DbSet<Employee> Employees {get; set;} = null!;
        public DbSet<End_Product> End_Products { get; set; } = null!;
        public DbSet<Material> Materials { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Person> People { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Provider> Providers { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//строка подключения к БД
        {
            optionsBuilder.UseSqlServer("Server = DMITRY;DataBase = Furniture Production;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            City city = new City { Id = 3, Name = "swv" };
            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Гомель"},
                new City {Id = 2, Name = "Брест"}, city
            );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "ftyr", CityID = city.Id});
        }
    }
}
