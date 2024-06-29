using MotoApp.Repisitories;
using MotoApp.Entites;

//var employeeRepository  = new EmployeeRepository(); how to swap repository to generic repositoro
var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new Employee("Adam"));
employeeRepository.Add(new Employee("Piotr"));
employeeRepository.Add(new Employee("Zuzia"));
employeeRepository.Save();

