using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BookMenagement.Bll.Interfaces
{
    public interface IPersonService
    {
        List<PersonModel> GetAll();

        PersonModel GetById(int id);
        void Create(PersonModel sc);
        void Update(PersonModel sc);
        void Delete(int id);

        bool Any(string name, string surname);
        bool Any(int id);
        PersonModel FirstOrDefaultByData(string name, string surname);
    }
}
