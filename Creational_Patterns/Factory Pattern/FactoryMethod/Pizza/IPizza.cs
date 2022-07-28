namespace Creational_Patterns.Factory_Pattern.FactoryMethod.Pizza
{
    public interface IPizza
    {
        void bake();
        void box();
        void cut();
        void prepare();
    }
}