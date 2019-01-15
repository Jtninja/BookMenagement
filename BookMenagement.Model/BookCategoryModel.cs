using System.ComponentModel.DataAnnotations;

namespace BookMenagement.Model
{
    public class BookCategoryModel
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

    public class BookCategoryModelRequest
    {
        [Key]
        public int id { get; set; }
        [StringLength(2)]
        [Required]
        public string code { get; set; }
        [Required]
        [StringLength(100)]
        public string name { get; set; }
    }
}
