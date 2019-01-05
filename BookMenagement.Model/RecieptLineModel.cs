using System.ComponentModel.DataAnnotations;

namespace BookMenagement.Model
{

    public class RecieptLineModel
    {
        [Key]
        public int Id { get; set; }
        public int LineNo { get; set; }
        [Required]
        public  BookModel ProductId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public  CurrencyModel Currency { get; set; }
    }
}
