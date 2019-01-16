using BookMenagement.Model;
using System.Collections.Generic;

namespace BookMenagement.Bll.Interfaces
{
    public interface IAuthorService
    {
        List<AuthorModel> GetAll();
        AuthorModel GetById(int id);
        void Create(AuthorModel sc);
        void Update(AuthorModel sc);
        void Delete(int id);
    }
}
