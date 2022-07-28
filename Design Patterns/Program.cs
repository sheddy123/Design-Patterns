using Creational_Patterns.Singleton_Pattern;
using Creational_Patterns.Models;
using System;
using Creational_Patterns.Factory_Pattern.FactoryMethod;
using Creational_Patterns.Managers;
using static Creational_Patterns.Models.Employee_Type;
using Creational_Patterns.SimpleFactory;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //Implementing Single Fatory method
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(factory);
            var pepperoni = pizzaStore.orderPizza("cheese");

            Employee employee = new Employee()
            {
                Id = 1,
                JobDescription = "Employee First Job",
                Bonus = 23,
                HourlyPay = 679,
                Name = "Marshal",
                Department = "Physics",
                EmployeeTypeId = new Employee_Type()
                {
                    EmoloyeeType = "Permanent",
                    Id = 1,
                    employeeType = EmployeeType.Permanent
                }
            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                JobDescription = "Employee First Job",
                Bonus = 23,
                HourlyPay = 679,
                Name = "Marshalla",
                Department = "Chemistry",
                EmployeeTypeId = new Employee_Type()
                {
                    EmoloyeeType = "Contract",
                    Id = 2,
                    employeeType = EmployeeType.Contract
                }
            };
            BaseEmployeeFactory empFactory = new EmployeeManagerFactory().CreateFactory(employee);
            empFactory.ApplySalary();

            empFactory = new EmployeeManagerFactory().CreateFactory(employee2);
            empFactory.ApplySalary();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
