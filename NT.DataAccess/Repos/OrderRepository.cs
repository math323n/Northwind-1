using Microsoft.EntityFrameworkCore;
using NT.DataAccess.RepositoryBase;
using NT.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NT.DataAccess.Repos
{
    public class OrderRepository : RepositoryBase<Orders>
    {
        protected const string orderDetails = "OrderDetails";

        public override async Task<Orders> GetByAsync(int id)
        {
            return await context.Orders
                .Include(orderDetails)
                .SingleOrDefaultAsync(p => p.OrderId == id);
        }

        public override async Task<IEnumerable<Orders>> GetAllAsync()
        {
            return await context.Set<Orders>().Include(orderDetails).ToListAsync();
        }
    }
}
