using BookMenagement.Model;
using System.Collections.Generic;

namespace BookMenagement.Bll.Interfaces
{
    public interface ICurrencyService
    {
        IEnumerable<CurrencyModel> GetAll();
        CurrencyModel GetById(int id);
        void Create(CurrencyModel sc);
        void Update(CurrencyModel sc);
        void Delete(int id);
    }
}
