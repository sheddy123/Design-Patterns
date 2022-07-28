using static Creational_Patterns.Abstract_Factory_Pattern.Enumerations;

namespace Creational_Patterns.Abstract_Factory_Pattern
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Brands.Apple.ToString();
        }
    }
}

