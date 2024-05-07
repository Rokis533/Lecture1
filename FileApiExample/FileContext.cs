using FileApiExample.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApiExample
{
    public class FileContext : DbContext
    {

        public DbSet<Photo> Photos { get; set; }

        public FileContext(DbContextOptions<FileContext> options) : base(options) { }


    }
}
