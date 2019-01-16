using System.ComponentModel.DataAnnotations;

namespace BookMenagement.Model
{
    public class AuthorModel
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string ArtistName { get; set; }
        public  PersonModel Person { get; set; }
        public int PersonId { get; set; }
    }
}
