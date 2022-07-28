using static Creational_Patterns.Abstract_Factory_Pattern.Enumerations;

namespace Creational_Patterns.Abstract_Factory_Pattern
{
    public class DELL : IBrand
    {
        public string GetBrand()
        {
            return Brands.Dell.ToString();
        }
    }
}

