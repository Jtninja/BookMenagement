using System.ComponentModel.DataAnnotations;

namespace BookMenagement.Model
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(250)]
        public string ImageUrl { get; set; }
        public decimal Amount { get; set; }
        public  CurrencyModel Currency { get; set; }
        public  BookCategoryModel BookCategory { get; set; }
        public  AuthorModel Author { get; set; }

    }
}
