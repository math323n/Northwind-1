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
        protected const string orderDetails = "OrderDetails";

        public override async Task<Orders> GetByAsync(int id)
        {
            return await context.Orders
                .Include(orderDetails)
                .SingleOrDefaultAsync(p => p.OrderId == id);
        }

        public async Task<IEnumerable<Orders>> GetAllOrdersAsync()
        {
            return await context.Set<Orders>()
                .Include("Customer")
                .Include("OrderDetails")
                .ToListAsync();
        }

        public async Task<IEnumerable<Orders>> GetAllOrdersByIdAsync(string customerId)
        {
            return await context.Set<Orders>()
                .Include("Customer")
                .Include("OrderDetails")
                .Where(o => o.CustomerId == customerId)
                .ToListAsync();
        }
    }
}
