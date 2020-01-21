using BookMenagement.Model;
using System.Collections.Generic;

namespace BookMenagement.Bll.Interfaces
{
    public interface IBookService
    {
        List<BookModel> GetAll();
        BookModel GetById(int id);
        void Create(BookModel sc);
        void Update(BookModel sc);
        void Delete(int id);
    }
}
