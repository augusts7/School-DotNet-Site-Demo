using Microsoft.EntityFrameworkCore;
using demo_school_app.Models;

namespace demo_school_app.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> students;
        public DbSet<Course> courses;
        public DbSet<Department> departments;

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }
          
    }
}