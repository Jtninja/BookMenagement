using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMenagement.BLL.Parser
{
    public static partial class Parser
    {
        public static RecieptLineModel Parse(RecieptLine line)
        {
            if (line == null)
            {
                return null;
            }
            return new RecieptLineModel
            {
                LineNo = line.LineNo,
                Price = line.Price,
                ProductId = line.ProductId,
                Product = Parse(line.Product),
                Id = line.Id,
                RecieptHeaderId = line.RecieptHeaderId
            };
        }
        public static RecieptLine Parse(RecieptLineModel line, int headerId,bool includeId=false)
        {
            if (line == null)
            {
                return null;
            }
            var model =
                         new RecieptLine
                         {
                             LineNo = line.LineNo,
                             Price = line.Price,
                             ProductId = line.ProductId

                         };
            if (includeId)
                model.Id = line.Id;

            if (headerId != 0)
            {
                model.RecieptHeaderId = headerId;
            }

            return model;
        }
    }
}
