using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMenagement.DAL.Model
{
    public class RecieptHeader
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CostumerId { get; set; }
        public virtual Person Costumer  { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual List<RecieptLine> RecieptLines { get; set; }
    }
}