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
            return await new OrderRepository().GetAllAsync();
        }

        [HttpGet("all/{customerID}")]
        public async Task<IEnumerable<Orders>> GetAllById(string customerId)
        {
            return await new OrderRepository().GetByIdAsync(customerId);
        }
    }
}