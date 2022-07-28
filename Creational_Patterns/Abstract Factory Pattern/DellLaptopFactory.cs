namespace Creational_Patterns.Abstract_Factory_Pattern
{
    public class DellLaptopFactory : DellFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}

