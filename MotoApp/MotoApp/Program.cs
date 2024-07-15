using MotoApp.Data;
using MotoApp.Repisitories;
using MotoApp.Entites;

var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new Employee("Adam"));
employeeRepository.Add(new Employee("Piotr"));
employeeRepository.Add(new Employee("Zuzia"));
employeeRepository.Save();

var sqlRepository = new SqlRepository(new MotoAppDbContext());
sqlRepository.Add(new Employee { FirstName = "Adam" });
sqlRepository.Add(new Employee { FirstName = "Piotr" });

sqlRepository.Save();

var empl = sqlRepository.GetById(1);
Console.WriteLine(empl);

