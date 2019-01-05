using System.ComponentModel.DataAnnotations;

namespace BookMenagement.Model
{
    public class AuthorModel
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string ArtistName { get; set; }
        [Required]
        public  PersonModel Person { get; set; }
    }
}
