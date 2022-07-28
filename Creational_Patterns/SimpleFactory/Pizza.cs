namespace Creational_Patterns.SimpleFactory
{
    public abstract class Pizza
    {
        public abstract void prepare();
        public abstract void bake();
        public abstract void cut();
        public abstract void box();
    }

}
