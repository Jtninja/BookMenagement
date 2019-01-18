using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMenagement.Model
{
    public class RecieptHeaderModel
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CostumerId { get; set; }
        public  PersonModel Costumer { get; set; }
        public int CurrencyId { get; set; }
        public virtual CurrencyModel Currency { get; set; }
        public virtual List<RecieptLineModel> RecieptLines { get; set; }
    }
}
