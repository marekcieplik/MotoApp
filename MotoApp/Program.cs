using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
employeeRepository.Add(new Employee() { FirstName = "Adam" });
employeeRepository.Add(new Employee() { FirstName = "Piotr" });
employeeRepository.Add(new Employee() { FirstName = "Zuzanna" });

GetEmployeeById(employeeRepository);


static void GetEmployeeById(IRepository<Employee> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine(employee.ToString());
}

//GetEmployeeByIdIEntity(employeeRepository);


static void GetEmployeeByIdIEntity(IRepository<IEntity> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine(employee.ToString());
}
