using Microsoft.EntityFrameworkCore;
using WebApiDemo.Models;

namespace WebApiDemo.Data
{
    public class ApplicationdbContext:DbContext
    {
        public ApplicationdbContext(DbContextOptions<ApplicationdbContext> op) : base(op)
        {

        }

        public DbSet<Book> Books { get; set; }
         public DbSet<Student> Students { get; set; }

        public DbSet<Employee> Employees { get; set; }

       

    }
}
