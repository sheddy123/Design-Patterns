using static Creational_Patterns.Abstract_Factory_Pattern.Enumerations;

namespace Creational_Patterns.Abstract_Factory_Pattern
{
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}

