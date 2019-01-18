using BookMenagement.Bll.Interfaces;
using BookMenagement.DAL.Interfaces;
using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if (sc==null||sc.RecieptLines==null)
            {
                throw new  ArgumentNullException();
            }
            RecieptHeader recieptHeader = Parser.Parser.Parse(sc);
            headerRepository.Insert(recieptHeader);
            headerRepository.Save();

        }

        public void CreateLine(RecieptLineModel sc)
        {
            if (sc == null||sc.RecieptHeaderId==0)
            {
                throw new ArgumentNullException();
            }
            var model = Parser.Parser.Parse(sc,sc.RecieptHeaderId);
            lineRepository.Insert(model);
            lineRepository.Save();
        }

        public void Delete(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException();
            }
            headerRepository.Delete(id);
            headerRepository.Save();
        }

        public void DeleteLine(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException();
            }
            lineRepository.Delete(id);
            lineRepository.Save();
        }

        public List<RecieptHeaderModel> GetAll()
        {
            return headerRepository.GetAll().Select(a => Parser.Parser.Parse(a)).ToList();
        }

        public RecieptHeaderModel GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException();
            }
            var model = headerRepository.GetById(id);
            return Parser.Parser.Parse(model);
        }

        public void Update(RecieptHeaderModel sc)
        {
            if (sc == null || sc.RecieptLines == null)
            {
                throw new ArgumentNullException();
            }
            RecieptHeader recieptHeader = Parser.Parser.Parse(sc,true);
            recieptHeader.Id = sc.Id;
            headerRepository.Update(recieptHeader);
            headerRepository.Save();
        }

        public void UpdateLine(RecieptLineModel sc)
        {
            if (sc == null||sc.RecieptHeaderId==0)
            {
                throw new ArgumentNullException();
            }
            var model = Parser.Parser.Parse(sc,sc.RecieptHeaderId);
            lineRepository.Update(model);
            lineRepository.Save();

        }
        #endregion
    }
}
