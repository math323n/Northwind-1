using Microsoft.VisualStudio.TestTools.UnitTesting;

using NT.Entities.Models;
using NT.Services;

using System;
using System.Collections.Generic;

namespace NT.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async System.Threading.Tasks.Task TestMethod1Async()
        {
            // arrange
            OrderService service;

            List<Orders> orderList;

            // act
            service = new OrderService();
            orderList = await service.GetAllOrders();

            //assert
            Assert.IsTrue(orderList.Count > 0);
            

        }
    }
}
