using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDemo.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]  // this is primary key col in DB
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
