using BookMenagement.Bll.Interfaces;
using BookMenagement.DAL.Interfaces;
using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;

namespace BookMenagement.BLL
{
    public class RecieptService : IRecieptService
    {
        #region fields & ctr
        private readonly IRepository<RecieptHeader> headerRepository;
        private readonly IRepository<RecieptLine> lineRepository;
        public RecieptService(IRepository<RecieptHeader> headerRepository,IRepository<RecieptLine> lineRepository)
        {
            this.headerRepository = headerRepository;
            this.lineRepository = lineRepository;
        }

        #endregion

        #region CRUD

        public void Create(RecieptHeaderModel sc)
        {
            throw new NotImplementedException();
        }

        public void CreateLine(RecieptLineModel sc)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteLine(int id)
        {
            throw new NotImplementedException();
        }

        public List<RecieptHeaderModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public RecieptHeaderModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(RecieptHeaderModel sc)
        {
            throw new NotImplementedException();
        }

        public void UpdateLine(RecieptLineModel sc)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
