using System;

namespace GofPatterns.FactoryMethod
{
    public abstract class OrderFactory
    {
        public abstract Order CreateOrder();
    }

    public class VirtualOrdersFactory : OrderFactory
    {
        public override Order CreateOrder()
        {
            return new VirtualOrder();
        }
    }

    public class PhysicalOrdersFactory : OrderFactory
    {
        public override Order CreateOrder()
        {
            return new PhysicalOrder();
        }
    }
}
