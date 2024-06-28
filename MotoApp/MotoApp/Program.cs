using MotoApp.Repisitories;
using MotoApp.Entites;

var employeeRepository  = new EmployeeRepository();
employeeRepository.Add(new Employee("Adam"));
employeeRepository.Add(new Employee("Piotr"));
employeeRepository.Add(new Employee("Zuzia"));
employeeRepository.Save();
