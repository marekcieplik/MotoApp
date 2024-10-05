using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

var employeesRepository = new ListGenericRepository<Employee>();
employeesRepository.Add(new Employee() { FirstName = "Adam" });
employeesRepository.PrintListOnScrean();

var sqlRepository = new SqlRepository<Employee>(new MotoAppDbContext());
sqlRepository.Add(new Employee() { FirstName = "Adam" });
sqlRepository.Add(new Employee() { FirstName = "Piotr" });
//sqlRepository.Save();

var emp = sqlRepository.GetById(2);
Console.WriteLine(emp.ToString());