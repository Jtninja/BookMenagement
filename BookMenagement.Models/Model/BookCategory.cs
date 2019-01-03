using System.ComponentModel.DataAnnotations;

namespace BookMenagement.DAL.Model
{
    public class BookCategory
    {
        [Key]
        public int Id { get; set; }
        [StringLength(2)]
        [Required]
        public string Code { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}