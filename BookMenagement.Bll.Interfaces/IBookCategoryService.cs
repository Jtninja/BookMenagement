using BookMenagement.Model;
using System;
using System.Collections.Generic;

namespace BookMenagement.Bll.Interfaces
{
    public interface IBookCategoryService
    {
        List<BookCategoryModel> GetAll();
        BookCategoryModel GetById(int id);
        void Create(BookCategoryModel sc);
        void Update(BookCategoryModel sc);
        void Delete(int id);
    }
}
