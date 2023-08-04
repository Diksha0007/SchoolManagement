using Microsoft.EntityFrameworkCore;
using SchoolManagement1.Models;

namespace SchoolManagement1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>Options):base(Options)
        {
                
        }
        public DbSet<Student>Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
    }
}
