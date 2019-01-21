using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMenagement.Api.DTO
{
    public class AuthorRequest
    {
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string PersonPersonalNr { get; set; }
    }
}
