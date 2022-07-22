namespace Creational_Patterns.Managers
{
    public class PermannentEmployeeManager : IEmployeeManager, IPermanentEmoloyeeManager
    {
        public decimal GetBonus()
        {
            System.Console.WriteLine("The Bonus is {0}", 10);
            return 10;
        }

        public decimal GetPay()
        {
            System.Console.WriteLine("The Pay is {0}", 8);
            return 8;
        }
        public decimal GetHouseAllowance()
        {
            System.Console.WriteLine("The House allowance is {0}", 150);
            return 150;
        }
    }
}
