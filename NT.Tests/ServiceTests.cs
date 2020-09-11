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
        #region Get All Orders Test
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
        #endregion

        #region Get Order By Id Test
        [TestMethod]
        public async Task GetOrderByIdAsyncTest()
        {
            // Arrange
            OrderService service;
            Orders order;

            // Act
            service = new OrderService();
            order = await service.GetOrderByIdAsync("anton");

            // Assert
            Assert.IsNotNull(order);
        }
        #endregion

        #region Get All Products Test
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
        #endregion

        #region Get All Shippers Test
        [TestMethod]
        public async Task GetAllShippersAsyncTest()
        {
            // Arrange
            ShipperService service;
            List<Shippers> shippersList;

            // Act
            service = new ShipperService();
            shippersList = await service.GetAllShippersAsync();

            // Assert
            Assert.IsTrue(shippersList.Count > 0);
        }
        #endregion
    }
}