using System;
using System.Collections.Generic;

namespace NT.DataAccess.RepositoryBase
{
    public class RepositoryBase<T>: IRepositoryBase<T> where T : class
    {
        #region Fields
        // Static Northwind context
       // protected static NorthwindContext context;
        #endregion

        #region Constructor
        static RepositoryBase()
        {
           // context = new NorthwindContext();
        }

        protected RepositoryBase() { }
        #endregion

        #region Methods
        public virtual void Add(T t)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual T GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T t)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}