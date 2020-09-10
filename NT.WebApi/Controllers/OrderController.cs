using Microsoft.AspNetCore.Mvc;
using NT.DataAccess.Repos;
using NT.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController
    {
        [HttpGet("all")]
        public async Task<IEnumerable<Orders>> GetAll()
        {
            return await new OrderRepository().GetAllOrdersAsync();
        }

        [HttpGet("all/{customerID}")]
        public async Task<IEnumerable<Orders>> GetAllById(string customerId)
        {
            return await new OrderRepository().GetAllOrdersByIdAsync(customerId);
        }

        //[HttpGet("pending/{customerID}")]
        //public List<Orders> GetAllPending(string customerID)
        //{
        //    return new OrderRepository().GetPendingOrders(customerID);
        //}

        //[HttpGet("completed/{customerID}")]
        //public List<Orders> GetAllCompleted(string customerID)
        //{
        //    return new OrderRepository().GetCompletedOrders(customerID);
        //}
    }
}