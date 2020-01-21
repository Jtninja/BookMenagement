using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMenagement.BLL.Parser
{
    public static partial class Parser
    {
        

        public static RecieptHeaderModel Parse(RecieptHeader reciept)
        {
            if (reciept==null)
            {
                return null;
            }
            var model = 
                new RecieptHeaderModel {
                    Id=reciept.Id,
                    CostumerId=reciept.CostumerId,
                    Costumer=Parse(reciept.Costumer),
                    CreatedTime=reciept.CreatedTime,
                    Currency=Parse(reciept.Currency),
                    CurrencyId=reciept.CurrencyId,
                    TotalAmount=reciept.TotalAmount
                };

            if (reciept.RecieptLines?.Count>0)
            {
                model.RecieptLines = new List<RecieptLineModel>();
                foreach (var ln in reciept.RecieptLines)
                {
                    model.RecieptLines.Add(Parse(ln));
                }
            }

            return model;
        }

        public static RecieptHeader Parse(RecieptHeaderModel reciept,bool includeId=false)
        {
            if (reciept == null) return null;

            var model =
               new RecieptHeader
               {
                   CostumerId = reciept.CostumerId,
                   CreatedTime = reciept.CreatedTime,
                   CurrencyId = reciept.CurrencyId,
                   TotalAmount = reciept.TotalAmount
               };

            if (reciept.RecieptLines?.Count>0)
            {
                model.RecieptLines = new List<RecieptLine>();
                foreach (var ln in reciept.RecieptLines)
                {
                    model.RecieptLines.Add(Parse(ln,0, includeId));
                }
            }
            return model;
        }
    }
}
