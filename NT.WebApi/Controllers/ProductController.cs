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
    public class ProductController
    {
        [HttpGet("all")]
        public async Task<IEnumerable<Products>> GetAll()
        {
            return await new ProductRepository().GetAllAsync();
        }
    }
}
