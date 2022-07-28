namespace Creational_Patterns.Factory_Pattern.FactoryMethod.Pizza
{
    public partial class NYPizzaStore : PizzaStore
    {

        protected override IPizza createPizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            return null;
        }
    }
}
