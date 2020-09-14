using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NT.DataAccess.Repositories;
using NT.Entities.Models;

namespace NT.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SupplierController : Controller
    {
        /// <summary>
        /// Gets all Suppliers
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public async Task<IEnumerable<Suppliers>> GetAllAsync()
        {
            return await new SupplierRepository().GetAllAsync();
        }
    }
}