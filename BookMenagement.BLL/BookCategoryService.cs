using BookMenagement.Bll.Interfaces;
using BookMenagement.DAL.Interfaces;
using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookMenagement.BLL
{
    public class BookCategoryService : IBookCategoryService
    {
        #region fields And ctr
        public readonly IRepository<BookCategory> _repository;
        public BookCategoryService(IRepository<BookCategory> repository)
        {
            _repository = repository;
        }
        #endregion

        #region CRUD
        public void Create(BookCategoryModel sc)
        {
            if (sc == null)
            {
                throw new ArgumentNullException();
            }
            if (sc.Id != 0)
            {
                throw new ArgumentException("Id cant be provided in creation");
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

        public List<BookCategoryModel> GetAll()
        {
            return _repository.GetAll()
                              .Select(a =>
                                Parser.Parser.Parse(a)).ToList();
        }

        public BookCategoryModel GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException("Id cant be 0");
            }
            var model = _repository.GetById(id);
            return Parser.Parser.Parse(model);

        }

        public void Update(BookCategoryModel sc)
        {

            if (sc == null)
            {
                throw new ArgumentNullException();
            }
            if (sc.Id == 0)
            {
                throw new ArgumentNullException("Id cant be null");
            }

            var model = Parser.Parser.Parse(sc);
            model.Id = sc.Id;
            _repository.Update(model);
            _repository.Save();
        }
        #endregion

    }
}
