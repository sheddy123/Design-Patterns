using System.Collections.Generic;
using System.Text;

namespace Creational_Patterns.SimpleFactory
{
    public class PizzaStore
    {
        private SimplePizzaFactory _factory;
        public PizzaStore(SimplePizzaFactory simpleFactory)
        {
            _factory = simpleFactory;
        }

        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            
            pizza = _factory.createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            
            return pizza;
        }
    }

}
