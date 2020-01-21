using System.ComponentModel.DataAnnotations;

namespace BookMenagement.Model
{

    public class RecieptLineModel
    {
        [Key]
        public int Id { get; set; }
        public int LineNo { get; set; }
        [Required]
        public  BookModel Product { get; set; }
        public int ProductId { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int RecieptHeaderId { get; set; }
    }
}
