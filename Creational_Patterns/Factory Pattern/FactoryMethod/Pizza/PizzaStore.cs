using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_Patterns.Factory_Pattern.FactoryMethod.Pizza
{
    public abstract class PizzaStore
    {
        public IPizza orderPizza(string type)
        {
            IPizza pizza;
            pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        protected abstract IPizza createPizza(String type);
    }
}
