using Microsoft.EntityFrameworkCore;
using NT.DataAccess.RepositoryBase;
using NT.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT.DataAccess.Repos
{
    public class OrderRepository : RepositoryBase<Orders>
    {
        public override async Task<IEnumerable<Orders>> GetAllAsync()
        {
            return await context.Set<Orders>()
                .Include("Customer")
                .Include("OrderDetails")
                .ToListAsync();
        }

        public async Task<IEnumerable<Orders>> GetByIdAsync(string customerId)
        {
            return await context.Set<Orders>()
                .Include("Customer")
                .Include("OrderDetails")
                .Where(o => o.CustomerId == customerId)
                .ToListAsync();
        }
    }
}
