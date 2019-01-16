using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BookMenagement.Bll.Interfaces
{
    public interface IPersonService
    {
        List<PersonModel> GetAll();
        bool Any(Expression<Func<PersonModel, bool>> predicate);
        PersonModel FirstOrDefault(Expression<Func<PersonModel, bool>> predicate);
        PersonModel GetById(int id);
        void Create(PersonModel sc);
        void Update(PersonModel sc);
        void Delete(int id);
    }
}
