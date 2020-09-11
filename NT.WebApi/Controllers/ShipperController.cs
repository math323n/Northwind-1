using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NT.DataAccess.Repos;
using NT.Entities.Models;

namespace NT.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShipperController : Controller
    {
        [HttpGet("all")]
        public async Task<IEnumerable<Shippers>> GetAllAsync()
        {
            return await new ShipperRepository().GetAllAsync();
        }
    }
}
