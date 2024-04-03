using EntityFrameworkProject.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Database
{
    public class BookContext : DbContext
    {

        public DbSet<Book> Books { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }


    }
}
