using BookMenagement.Model;
using System.Collections.Generic;

namespace BookMenagement.Bll.Interfaces
{
    public interface IRecieptService
    {
        List<RecieptHeaderModel> GetAll();
        RecieptHeaderModel GetById(int id);

        void Create(RecieptHeaderModel sc);
        void Update(RecieptHeaderModel sc);
        void Delete(int id);

        void DeleteLine(int id);
        void UpdateLine(RecieptLineModel sc);
        void CreateLine(RecieptLineModel sc);
    }
}
