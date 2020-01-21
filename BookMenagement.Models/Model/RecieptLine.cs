using System.ComponentModel.DataAnnotations;

namespace BookMenagement.DAL.Model
{
    public class RecieptLine
    {
        [Key]
        public int Id { get; set; }
        public int LineNo { get; set; }
        [Required]
        public virtual Book Product { get; set; }
        public int ProductId { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int RecieptHeaderId { get; set; }
    }
}