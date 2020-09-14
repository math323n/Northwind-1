using Microsoft.AspNetCore.Mvc;
using NT.DataAccess.Repositories;
using NT.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NT.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController
    {
        /// <summary>
        /// Method for getting all products
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public async Task<IEnumerable<Products>> GetAllAsync()
        {
            return await new ProductRepository().GetAllAsync();
        }
        /// <summary>
        /// Method for getting product by Id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("{productId}")]
        public async Task<Products> GetByIdAsync(int productId)
        {
            return await new ProductRepository().GetByIdAsync(productId);
        }
    }
}