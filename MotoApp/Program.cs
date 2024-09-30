using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

//var employeesRepository = new ListGenericRepository<Employee>();
//employeesRepository.Add(new Employee() { FirstName = "Adam" });
//employeesRepository.Save();

var sqlRepository = new SqlRepository(new MotoAppDbContext());
sqlRepository.Add(new Employee() { FirstName = "Adam" });
sqlRepository.Add(new Employee() { FirstName = "Piotr" });
sqlRepository.Save();
var emp = sqlRepository.getById(1);
Console.WriteLine(emp.ToString());