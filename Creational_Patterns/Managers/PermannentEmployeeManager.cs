namespace Creational_Patterns.Managers
{
    public class PermannentEmployeeManager : IEmployeeManager
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
    }
}
