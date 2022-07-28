namespace Creational_Patterns.Abstract_Factory_Pattern
{
    public class MAC_LaptopFactory : MAC_Factory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }

}

