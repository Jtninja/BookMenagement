using System.ComponentModel.DataAnnotations;

namespace BookMenagement.Model
{
    public class CurrencyModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        [StringLength(2)]
        public string Code { get; set; }
        public char Symbol { get; set; }
        public bool IsDefault { get; set; }
        [Required]
        public decimal DefaultRatio { get; set; }
    }



}
