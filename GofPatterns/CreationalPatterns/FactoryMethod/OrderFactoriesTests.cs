using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GofPatterns.FactoryMethod
{
    [TestClass]
    public class OrderFactoriesTests
    {
        [TestMethod]
        public void VirtualFactoryTest()
        {
            OrderFactory factory = new VirtualOrdersFactory();

            var results = MassProduceOrders(factory);

            Assert.AreEqual("VirtualOrder v1.0", results[2].GetMyType());
        }

        private List<Order> MassProduceOrders(OrderFactory orderFactory)
        {
            List<Order> orders = new List<Order>();

            for(var i = 0; i < 5; i++)
            {
                orders.Add(orderFactory.CreateOrder());
            }

            return orders;
        }
    }
}
