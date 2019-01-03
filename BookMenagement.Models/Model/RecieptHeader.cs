using System;
using System.ComponentModel.DataAnnotations;

namespace BookMenagement.DAL.Model
{
    public class RecieptHeader
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedTime { get; set; }
        public virtual Person Costumer  { get; set; }
    }
}