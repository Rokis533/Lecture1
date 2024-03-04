
using ManyToMany.Models;
using Microsoft.EntityFrameworkCore;


namespace ManyToMany
{
    internal class CourseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=CourseDatabase;Trusted_Connection=True");

    }
}
