using System;
using System.Collections.Generic;

namespace BookMenagement.DAL.Interfaces
{
   public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(Object id);
        void Save();
    }
}

