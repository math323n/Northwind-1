using Microsoft.AspNetCore.Mvc;

using NT.DataAccess.Repositories;
using NT.Entities.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace NT.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController
    {
        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public async Task<IEnumerable<Orders>> GetAllAsync()
        {
            return await new OrderRepository().GetAllAsync();
        }

        /// <summary>
        /// Gets all orders with a specified customer ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        [HttpGet("all/{customerID}")]
        public async Task<IEnumerable<Orders>> GetAllByIdAsync(string customerId)
        {
            return await new OrderRepository().GetByIdAsync(customerId);
        }
    }
}