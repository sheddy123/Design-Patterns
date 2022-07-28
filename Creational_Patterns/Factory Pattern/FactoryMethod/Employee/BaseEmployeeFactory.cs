using Creational_Patterns.Managers;
using Creational_Patterns.Models;

namespace Creational_Patterns.Factory_Pattern.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp)
        {
            this._emp = emp;
        }
        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetPay();
            return _emp;
        }
        public abstract IEmployeeManager Create();
    }
}
