using Creational_Patterns.Managers;
using Creational_Patterns.Models;

namespace Creational_Patterns.Factory_Pattern.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {

        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {

        }
        public override IEmployeeManager Create()
        {
            PermannentEmployeeManager manager = new PermannentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}
