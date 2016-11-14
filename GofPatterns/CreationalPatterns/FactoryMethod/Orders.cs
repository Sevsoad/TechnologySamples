namespace GofPatterns.FactoryMethod
{
    public abstract class Order
    {
        protected int _orderId;
        protected string _orderType;

        public string GetMyType()
        {
            return _orderType;
        }
    }

    public class VirtualOrder : Order
    {
        private int _virtualId;

        public VirtualOrder()
        {
            _orderType = "VirtualOrder v1.0";
        }
    }

    public class PhysicalOrder:Order
    {
        public string _address;

        public PhysicalOrder()
        {
            _orderType = "PhysicalOrder v3.0";
        }
    }
}
