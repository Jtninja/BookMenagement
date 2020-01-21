using BookMenagement.Bll.Interfaces;
using BookMenagement.DAL.Interfaces;
using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public bool Any(string name, string surname)
        {
            return _repository.Any(a => a.Name == name && a.Surname == surname);
        }

        public bool Any(int id)
        {
            return _repository.Any(a => a.Id==id);
        }
        public PersonModel FirstOrDefaultByData(string name, string surname)
        {
            var model= _repository.Where(a => a.Name == name && a.Surname == surname).FirstOrDefault();

            if (model!=null)
            {
                return Parse(model);
            }
            return null;
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
            if (id == 0)
            {
                throw new ArgumentNullException();
            }
            _repository.Delete(id);
            _repository.Save();
        }
        public List<PersonModel> GetAll()
        {
            return _repository.GetAll().Select(Parse).ToList();
        }

        public PersonModel GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException();
            }
            var model = _repository.GetById(id);
            if (model != null)
            {
                return Parse(model);
            }
            return null;
        }

        public void Update(PersonModel sc)
        {
            if (sc == null||sc.Id==0)
            {
                throw new ArgumentNullException();
            }
            var model = Parse(sc);
            model.Id = sc.Id;
            _repository.Update(model);
            _repository.Save();
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
