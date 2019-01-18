using BookMenagement.Bll.Interfaces;
using BookMenagement.DAL.Interfaces;
using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookMenagement.BLL
{
    public class BookService : IBookService
    {

        #region fields & ctr
        private readonly IRepository<Book> bookRepository;
        public BookService(IRepository<Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        #endregion

        #region CRUD
        public void Create(BookModel sc)
        {
            if (sc == null || sc.BookCategory == null || sc.Author == null)
            {
                throw new ArgumentNullException();
            }
            if (sc.Id != 0)
            {
                throw new ArgumentException("Id shouldnt be provided");
            }

            Book model = Parser.Parser.Parse(sc);

            if (!bookRepository.Any(a =>
                                      a.Title == sc.Title &&
                                      a.Author.PersonId == sc.Author.PersonId))
            {
                throw new ArgumentException("Book already exists");
            }

            bookRepository.Insert(model);
            bookRepository.Save();
        }

        public void Delete(int id)
        {
            bookRepository.Delete(id);
            bookRepository.Save();
        }

        public List<BookModel> GetAll()
        {
            return bookRepository.GetAll().Select(Parser.Parser.Parse).ToList();
        }

        public BookModel GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException("Id should be provided");
            }
            var model = bookRepository.GetById(id);
             return Parser.Parser.Parse(model);
          
        }

        public void Update(BookModel sc)
        {
            if (sc == null || sc.BookCategory == null || sc.Author == null)
            {
                throw new ArgumentNullException();
            }
            if (sc.Id == 0)
            {
                throw new ArgumentNullException("Id should be provided");
            }
            Book model = Parser.Parser.Parse(sc);
            model.Id = sc.Id;
            bookRepository.Update(model);
            bookRepository.Save();
        }
        #endregion
    

    }
}
