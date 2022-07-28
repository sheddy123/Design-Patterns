namespace Creational_Patterns.Factory_Pattern.FactoryMethod.Pizza
{

 
        public class NYStyleCheesePizza : IPizza
        {
            public void bake()
            {
                System.Console.WriteLine("I am baking a NYStyleCheesePizza");
            }

            public  void box()
            {
                System.Console.WriteLine("I am boxing a NYStyleCheesePizza");
            }

            public void cut()
            {
                System.Console.WriteLine("I am cutting a NYStyleCheesePizza");
            }

            public void prepare()
            {
                System.Console.WriteLine("I am preparing a NYStyleCheesePizza");
            }

        }
    
}
