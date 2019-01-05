using System;
using System.ComponentModel.DataAnnotations;

namespace BookMenagement.Model
{
    public class RecieptHeaderModel
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedTime { get; set; }
        public  PersonModel Costumer { get; set; }
    }
}
