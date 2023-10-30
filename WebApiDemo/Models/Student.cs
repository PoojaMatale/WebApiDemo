using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDemo.Models
{
    [Table("Student")]  // Map class with table in DB
    public class Student
    {
        [Key]  // this is primary key col in DB
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public decimal Per { get; set; }
    }
}
