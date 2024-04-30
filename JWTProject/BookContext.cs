using JWTProject;
using JWTProject.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTProject
{
    public class UserContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user = UserHelper.CreateUser("Admin", "Admin");
            user.Role = "Admin";
            user.Id = 9999;
            modelBuilder.Entity<User>().HasData(user);
        }

    }
}
