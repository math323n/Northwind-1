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
        [HttpGet("all")]
        public async Task<IEnumerable<Orders>> GetAllAsync()
        {
            return await new OrderRepository().GetAllAsync();
        }

        [HttpGet("all/{customerID}")]
        public async Task<IEnumerable<Orders>> GetAllByIdAsync(string customerId)
        {
           var result = await new OrderRepository().GetByIdAsync(customerId);
            if(result == null)
            {
               
            }
            return result;
        }
    }
}