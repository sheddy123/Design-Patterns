using Creational_Patterns.Managers;
using Creational_Patterns.Models;

namespace Creational_Patterns.Factory_Pattern.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
            
        }
        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}
