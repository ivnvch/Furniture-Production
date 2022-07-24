using furniture_Production;
using furniture_Production.Classes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


using (ProductionContent pc = new ProductionContent ())
{
    pc.Database.EnsureCreated ();

    City city = new City { Name = "Пинск" };
    City city1 = new City { Name = "Лельчицы" };
    pc.Cities.AddRange(city, city1);

    Company company = new Company { Name = "Домовёнок", City = city };
    Company company1 = new Company { Name = "Строй Дом", City = city1 };
    Company company2 = new Company { Name = "Интел", City = city };
    Company company3 = new Company { Name = "Кто Здесь?", City = city1 };
    pc.Companies.AddRange(company, company1, company2, company3);
    pc.SaveChanges();

    Employee employee = new Employee { Name = "Сергей", Age = 40, Experience = 20, Company = company };
    Employee employee1 = new Employee { Name = "Анатолий", Age = 29, Experience = 7, Company = company3 };
    Employee employee2 = new Employee { Name = "Славик", Age = 19, Experience = 1, Company = company };
    pc.Employees.AddRange(employee, employee1, employee2);
    Provider provider = new Provider { Name = "Лесхоз" };
    pc.Providers.Add(provider);
    Material material = new Material { Name = "Дерево", Price = 150 };
    material.Providers.Add(provider);
    pc.Materials.Add(material);
    Product product = new Product { Name = "Качели", Color = "Зелёный" };
    product.materials.Add(material);
    pc.Products.Add(product);

    pc.SaveChanges();
    //var companies = pc.Companies.ToList();
    //Console.WriteLine("Список компаний дО удаления:");
    //foreach (var comp in companies)
    //{
    //    Console.WriteLine($"{comp.Name}");
    //}

    //var cit = pc.Cities.FirstOrDefault();
    //if (cit!=null)
    //{
    //    pc.Cities.Remove(cit!);
    //}
    //pc.SaveChanges();
    //Console.WriteLine();
    //Console.WriteLine("Список компаний после удаления города");
    //var c = pc.Companies.ToList();
    //foreach (var coms in c)
    //{
    //    Console.WriteLine($"{coms.Name}");
    //}

    Buyer buyer = new Buyer { Name = "Дмитрий", NumberPhone = "+375(29)104-77-51" };
    Buyer buyer1 = new Buyer { Name = "Александр", NumberPhone = "+375(44)365-85-94", Age = 20 };
    pc.Buyers.AddRange(buyer, buyer1);


    End_Product end_Product = new End_Product { Name = "Стулья", Color = "Коричневый", Cost = 150 };
    pc.End_Products.Add(end_Product);

    Order order = new Order { Buyer = buyer };
    order.Endproducts.Add(end_Product);
    pc.Orders.Add(order);

    pc.SaveChanges();
    var orders = pc.Orders.Include(o => o.Buyer).ToList();
    foreach (Order order1 in orders)
    {
        Console.WriteLine($"{order1.Buyer?.Name}");
    }
    pc.SaveChanges();

}

using (ProductionContent pc = new ProductionContent())
{
   // var d = pc.Companies.ToList();
    var employees = pc.Employees
        .Include(e => e.Company)
           .ThenInclude(c => c.City)
         .ToList();
    
    foreach (var iseer in employees)
    {
        Console.WriteLine($"{iseer.Name} - {iseer.Company?.Name}");
        Console.WriteLine("--------------------------------");
    }

}

using (ProductionContent content = new ProductionContent())
{
    //var comp = content.Companies.ToList();
    SqlParameter param = new("@name", "Домовёнок");
    var empl = content.Companies.FromSqlRaw("GetEmployeesByCompany @name", param).ToList();
    foreach (var procedure in empl)
    {
        Console.WriteLine($"{procedure.Id} - {procedure.Name}");
    }
    content.Database.EnsureDeleted();
}

