using System.ComponentModel.DataAnnotations;

namespace BookMenagement.DAL.Model
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string ArtistName { get; set; }

        [Required]
        public int PersonId { get; set; }
        public virtual Person  Person { get; set; }
    }
}