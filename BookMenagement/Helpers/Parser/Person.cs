using BookMenagement.Api.DTO;
using BookMenagement.Model;

namespace BookMenagement.Api.Helpers
{
    public static partial class Parser
    {
        public static CurrencyModel Parse(CurrencyRequest source)
        {
            if (source == null)
                return null;
            var model = new CurrencyModel
            {
                Code = source.Code,
                DefaultRatio = source.DefaultRatio,
                Id = source.Id,
                IsDefault = source.IsDefault,
                Name = source.Name,
                Symbol = source.Symbol
            };
            return model;
        }
        public static CurrencyResponse Parse(CurrencyModel source)
        {
            if (source == null)
                return null;
            var model = new CurrencyResponse
            {
                Code = source.Code,
                DefaultRatio = source.DefaultRatio,
                Id = source.Id,
                IsDefault = source.IsDefault,
                Name = source.Name,
                Symbol = source.Symbol
            };
            return model;
        }
    }
}
