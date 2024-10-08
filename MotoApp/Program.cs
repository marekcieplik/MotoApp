using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Entities.Extensions;
using MotoApp.Repositories;
using MotoApp.Repositories.Extensions;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
AddEmployees(employeeRepository);
WriteAllToConsole(employeeRepository);

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    var employees = new[]
    {
        new Employee { FirstName = "Adam"},
        new Employee { FirstName = "Piotr"},
        new Employee { FirstName = "Zuzanna"}
    };

    employeeRepository.AddBatch(employees);
    Employee? test = EntityExtensions.Copy(new Employee { FirstName = "Adam" });
    employeeRepository.Add(test);
    employeeRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}