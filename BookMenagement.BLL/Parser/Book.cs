using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMenagement.BLL.Parser
{
    public static partial class Parser
    {
        public static Book Parse(BookModel sc)
        {
            var model
                     = new Book
                     {
                         Title = sc.Title,
                         Amount = sc.Amount,
                         Description = sc.Description,
                         ImageUrl = sc.ImageUrl,
                         AuthorId = sc.Author.Id,
                         BookCategoryId = sc.BookCategory.Id
                     };
            if (sc.Currency?.Id != 0)
            {
                model.CurrencyId = sc.Currency.Id;
            }
            return model;
        }

        public static BookModel Parse(Book sc)
        {
            var model =
                new BookModel
                {
                    Title = sc.Title,
                    Amount = sc.Amount,
                    Description = sc.Description,
                    ImageUrl = sc.ImageUrl,
                    Id = sc.Id,
                    Author = Parse(sc.Author, sc.AuthorId),
                    BookCategory = Parse(sc.BookCategory, sc.BookCategoryId),
                    Currency = Parse(sc.Currency, sc.CurrencyId)
                };
            return model;
        }

    }
}
