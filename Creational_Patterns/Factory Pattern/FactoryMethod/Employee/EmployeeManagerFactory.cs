using Creational_Patterns.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Patterns.Factory_Pattern.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory returnValue = null;
            switch (employee.EmployeeTypeId.Id)
            {
                case 1:
                    Console.WriteLine("We are about to create a permanent type employee factory");
                    returnValue = new PermanentEmployeeFactory(employee); break;
                case 2:
                    Console.WriteLine("We are about to create a contract type employee factory");
                    returnValue = new ContractEmployeeFactory(employee); break;
            }
            return returnValue;
        }
    }
}
