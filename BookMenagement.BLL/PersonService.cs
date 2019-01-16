using BookMenagement.Bll.Interfaces;
using BookMenagement.DAL.Interfaces;
using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BookMenagement.BLL
{
    public class PersonService : IPersonService
    {
        #region fields and ctr
        public PersonService(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public readonly IRepository<Person> _repository;

        #endregion

        #region Queries
        public bool Any(Expression<Func<PersonModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public PersonModel FirstOrDefault(Expression<Func<PersonModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region CRUD
        public void Create(PersonModel sc)
        {
            if (sc == null)
            {
                throw new ArgumentNullException();
            }
            Person person = Parse(sc);
            _repository.Insert(person);
            _repository.Save();
        }



        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public List<PersonModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PersonModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonModel sc)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Helpers
        private Person Parse(PersonModel sc)
        {
            return new Person
            {
                Name = sc.Name,
                Surname = sc.Surname
            };
        }

        private PersonModel Parse(Person sc)
        {
            return new PersonModel
            {
                Name = sc.Name,
                Surname = sc.Surname,
                Id = sc.Id
            };
        }
        #endregion

    }
}
