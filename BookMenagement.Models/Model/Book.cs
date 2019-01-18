using System.ComponentModel.DataAnnotations;

namespace BookMenagement.DAL.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:150)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(250)]
        public string ImageUrl  { get; set; }
        public decimal Amount { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual BookCategory BookCategory { get; set; }
        public virtual Author Author { get; set; }
        public int AuthorId { get; set; }
        public int BookCategoryId { get; set; }
        public int CurrencyId { get; set; }
    }
}
