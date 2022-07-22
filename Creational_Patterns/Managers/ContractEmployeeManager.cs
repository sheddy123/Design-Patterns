namespace Creational_Patterns.Managers
{
    public class ContractEmployeeManager : IEmployeeManager, IContractEmployeeManager
    {
        public decimal GetBonus()
        {
            System.Console.WriteLine("The Bonus is {0}", 5);
            return 5;
        }

        public decimal GetMedicalAllowance()
        {
            System.Console.WriteLine("The Medical allowance is {0}", 100);
            return 100;
        }

        public decimal GetPay()
        {
            System.Console.WriteLine("The Pay is {0}", 12);
            return 12;
        }
    }
}
