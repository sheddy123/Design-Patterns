using static Creational_Patterns.Abstract_Factory_Pattern.Enumerations;

namespace Creational_Patterns.Abstract_Factory_Pattern
{
    public class I3 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.i3.ToString();
        }
    }
}

