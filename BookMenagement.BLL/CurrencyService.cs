using BookMenagement.Bll.Interfaces;
using BookMenagement.DAL.Interfaces;
using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMenagement.BLL
{
    public class CurrencyService : ICurrencyService
    {
        #region fields and ctr
        public readonly IRepository<Currency> _repository;
        public CurrencyService(IRepository<Currency> repository)
        {
            _repository = repository;
        }
        #endregion

        #region CRUD
        public void Create(CurrencyModel sc)
        {
            if (sc == null)
            {
                throw new ArgumentNullException();
            }
            if (sc.Id != 0)
            {
                throw new ArgumentException("Id cant be provided in creation");
            }
            if (sc.IsDefault && _repository.Any(a => a.IsDefault))
            {
                throw new ArgumentException("IsDefault cant be checked,we already have a default currency");
            }

            var model = Parser.Parser.Parse(sc);


            _repository.Insert(model);
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
        public void Update(CurrencyModel sc)
        {
            if (sc == null)
            {
                throw new ArgumentNullException();
            }
            if (sc.Id == 0)
            {
                throw new ArgumentException("Id is required field");
            }
            if (sc.IsDefault && _repository.Any(a => a.IsDefault))
            {
                throw new ArgumentException("IsDefault cant be checked,we already have a default currency");
            }

            var model = Parser.Parser.Parse(sc);
            model.Id = sc.Id;
            _repository.Update(model);
            _repository.Save();
        }
        public List<CurrencyModel> GetAll()
        {
            return _repository.GetAll()
                              .Select(a => Parser.Parser.Parse(a)).ToList();
        }

        public CurrencyModel GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("Id cant be 0");
            }
            var model = _repository.GetById(id);
            return Parser.Parser.Parse(model);
        }
        #endregion

    }
}
