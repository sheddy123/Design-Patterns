namespace Creational_Patterns.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            System.Console.WriteLine("The Bonus is {0}", 5);
            return 5;
        }

        public decimal GetPay()
        {
            System.Console.WriteLine("The Pay is {0}", 12);
            return 12;
        }
    }
}
