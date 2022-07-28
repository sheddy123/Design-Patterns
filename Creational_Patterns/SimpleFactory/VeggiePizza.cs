using System;

namespace Creational_Patterns.SimpleFactory
{
    public class VeggiePizza : Pizza
    {
        public override void bake()
        {
            throw new NotImplementedException();
        }

        public override void box()
        {
            throw new NotImplementedException();
        }

        public override void cut()
        {
            throw new NotImplementedException();
        }

        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }

}
