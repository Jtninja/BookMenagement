using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMenagement.BLL.Parser
{
    public static partial class Parser
    {


        public static CurrencyModel Parse(Currency currency, int currencyId)
        {
            if (currencyId == 0)
            {
                return Parse(currency);
            }
            var model = new CurrencyModel();
            if (currency != null)
            {
                model.Code = currency.Code;
                model.DefaultRatio = currency.DefaultRatio;
                model.IsDefault = currency.IsDefault;
                model.Name = currency.Name;
                model.Symbol = currency.Symbol;
            }
            model.Id = currencyId;
            return model;
        }
        public static CurrencyModel Parse(Currency currency)
        {
            if (currency == null)
            {
                return null;
            }
            var model = new CurrencyModel();
            model.Code = currency.Code;
            model.DefaultRatio = currency.DefaultRatio;
            model.IsDefault = currency.IsDefault;
            model.Name = currency.Name;
            model.Symbol = currency.Symbol;

            model.Id = currency.Id;
            return model;
        }
        public static Currency Parse(CurrencyModel sc)
        {
            if (sc == null) return null;
            
            return new Currency
            {
                Code = sc.Code,
                Name = sc.Name,
                DefaultRatio = sc.DefaultRatio,
                IsDefault = sc.IsDefault,
                Symbol = sc.Symbol
            };
        }
    }
}
