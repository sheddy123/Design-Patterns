using Creational_Patterns.Singleton_Pattern;
using Creational_Patterns.Models;
using System;
using Creational_Patterns.Factory_Pattern;
using Creational_Patterns.Managers;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
            IEmployeeManager empManager = empFactory.GetEmployeeManager(1);
            empManager.GetBonus();
            empManager.GetPay();

            empManager = empFactory.GetEmployeeManager(2);
            empManager.GetBonus();
            empManager.GetPay();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
