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
            if (line==null)
            {
                return null;
            }
            throw new NotImplementedException();
        }
    }
}
