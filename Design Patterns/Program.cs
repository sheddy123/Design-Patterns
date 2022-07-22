using Creational_Patterns.Singleton_Pattern;
using Creational_Patterns.Singleton_Pattern.Models;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeController employeeController = new EmployeeController();
            Employee addEmployee = new Employee()
            {
                Id = 1,
                JobDescription = "Job 2",
                Department = "Dept 1",
                Number = "23"
            };
            employeeController.AddEmployee(addEmployee);
            Console.WriteLine("Hello World!");
        }
    }
}
