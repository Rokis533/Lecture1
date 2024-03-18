using IntegrationTestableProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTestableProject
{
    public class BookStoreContext : DbContext
    {
        private DbContextOptionsBuilder<BookStoreContext> options;

        public BookStoreContext()
        {
        }

        public BookStoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=BookDatabaseTest;Trusted_Connection=True");
            }
        }

    }
}

