using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NT.DataAccess.Repos;
using NT.Entities.Models;

namespace NT.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SupplierController : Controller
    {
        [HttpGet("all")]
        public async Task<IEnumerable<Suppliers>> GetAllAsync()
        {
            return await new SupplierRepository().GetAllAsync();
        }
    }
}