﻿using MotoApp.Data;
using MotoApp.Repisitories;
using MotoApp.Entites;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
AddEmployees(employeeRepository);
AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Adam" });
    employeeRepository.Add(new Employee { FirstName = "Zuzia" });
    employeeRepository.Add(new Employee { FirstName = "Damian" });
    employeeRepository.Save();
}

static void AddManagers(IWriteRepository<Manager> managerRepository)
{
    managerRepository.Add(new Manager { FirstName = "Przemek" });
    managerRepository.Add(new Manager { FirstName = "Tomek" });
    managerRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
// Test: 

GetEmployeeByIdTest(employeeRepository);
//why didn't IRepository(IEntity) not work
//static void GetEmployeeByIdTest(IRepository<IEntity> employeeRepository)  
static void GetEmployeeByIdTest(IRepository<Employee> employeeRepository)
{
    var employee = employeeRepository.GetById(1);
    Console.WriteLine(employee);
}