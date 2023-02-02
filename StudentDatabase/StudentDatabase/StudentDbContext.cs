
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
    }
}
