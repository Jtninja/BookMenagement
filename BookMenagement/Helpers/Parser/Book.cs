using BookMenagement.Api.DTO;
using BookMenagement.Model;

namespace BookMenagement.Api.Helpers
{
    public static partial class Parser
    {
        public static BookModel Parse(BookRequest source)
        {
            if (source == null)
                return null;
            var model = new BookModel
            {
              
            };
            return model;
        }
  
    }
}
