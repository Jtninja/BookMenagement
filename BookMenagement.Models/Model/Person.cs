using System.ComponentModel.DataAnnotations;

namespace BookMenagement.DAL.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
  
        [StringLength(150)]
        public string Surname { get; set; }
    }
}