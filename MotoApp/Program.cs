using MotoApp.Entities;
using MotoApp.Repositories;

var employeesRepository = new ListGenericRepository<Employee>();
employeesRepository.Add(new Employee() { FirstName = "Adam"});
employeesRepository.Save();

