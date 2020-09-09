using NT.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NT.DataAccess.RepositoryBase
{
    public interface IRepositoryBase<T>
    {
        NorthwindContext Context { get; set; }

        IEnumerable<T> GetAll();

        T GetBy(int id);

        void Update();
        void Add(T t);
        void Delete(T t);
    }
}