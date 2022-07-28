using Creational_Patterns.Models;

namespace Creational_Patterns.Abstract_Factory_Pattern
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returnValue = null;
            if(e.EmployeeTypeId.Id == 1)
            {
                if(e.JobDescription == "Manager")
                {
                    returnValue = new MAC_LaptopFactory();
                }
                else
                {
                    returnValue = new MAC_Factory();
                }
            }
            else if(e.EmployeeTypeId.Id == 2)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                    returnValue = new DellFactory();
            }
            return returnValue;
        }
    }
}

