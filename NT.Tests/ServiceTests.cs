using Microsoft.VisualStudio.TestTools.UnitTesting;
using NT.Entities.Models;
using NT.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NT.Tests
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public async Task GetAllOrdersAsyncTest()
        {
            // Arrange
            OrderService service;

            List<Orders> orderList;

            // Act
            service = new OrderService();
            orderList = await service.GetAllOrdersAsync();

            // Assert
            Assert.IsTrue(orderList.Count > 0);
        }

        [TestMethod]
        public async Task GetAllProductsAsyncTest()
        {
            // Arrange
            ProductService service;
            List<Products> productList;

            // Act
            service = new ProductService();
            productList = await service.GetAllProductsAsync();

            // Assert
            Assert.IsTrue(productList.Count > 0);
        }
    }
}