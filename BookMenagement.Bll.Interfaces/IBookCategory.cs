using BookMenagement.Model;
using System;
using System.Collections.Generic;

namespace BookMenagement.Bll.Interfaces
{
    public interface IBookCategory
    {
        List<BookCategoryModel> GetAll();
        BookCategoryModel GetById(int id);
        BookCategoryModel Create(BookCategoryModel sc);
        BookCategoryModel Update(BookCategoryModel sc);
        void Delete(int id);

    }
}
