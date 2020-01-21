using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMenagement.BLL.Parser
{
    public static partial class Parser
    {
        public static BookCategoryModel Parse(BookCategory bookCategory, int bookCategoryId)
        {
            if (bookCategoryId == 0)
            {
                return Parse(bookCategory);
            }
            var model = new BookCategoryModel();

            if (bookCategory != null)
            {
                model.Code = bookCategory.Code;
                model.Name = bookCategory.Name;
            }
            model.Id = bookCategoryId;
            return model;
        }
        public static BookCategoryModel Parse(BookCategory bookCategory)
        {
            if (bookCategory == null)
            {
                return null;
            }
            var model = new BookCategoryModel();
            model.Code = bookCategory.Code;
            model.Name = bookCategory.Name;
            model.Id = bookCategory.Id;
            return model;
        }

        public static BookCategory Parse(BookCategoryModel sc)
        {
            if (sc == null) return null;
           return new BookCategory { Code = sc.Code, Name = sc.Name };
        }

    }
}

