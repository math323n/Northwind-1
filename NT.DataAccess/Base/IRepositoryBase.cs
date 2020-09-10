using NT.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NT.DataAccess.RepositoryBase
{
    public interface IRepositoryBase<T>
    {
        NorthwindContext Context { get; set; }

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByAsync(int id);

        Task UpdateAsync();
        Task AddAsync(T t);
        Task DeleteAsync(T t);
    }
}