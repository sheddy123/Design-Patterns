namespace Creational_Patterns.Abstract_Factory_Pattern
{
    public interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}

