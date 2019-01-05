using BookMenagement.Bll.Interfaces;
using BookMenagement.DAL.Interfaces;
using BookMenagement.Model;
using System;
using System.Collections.Generic;

namespace BookMenagement.BLL
{
    public class BookCategory : IBookCategory
    {

        public readonly IRepository<BookCategory> _repository;
        public BookCategory(IRepository<BookCategory> repository)
        {
            _repository = repository;
        }


        public BookCategoryModel Create(BookCategoryModel sc)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BookCategoryModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public BookCategoryModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public BookCategoryModel Update(BookCategoryModel sc)
        {
            throw new NotImplementedException();
        }
    }
}
