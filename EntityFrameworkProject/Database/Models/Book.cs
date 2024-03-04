using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Database.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        private List<Page> _pages;

        public virtual List<Page> Pages
        {
            get
            {
                Console.WriteLine("Getting pages");
                return _pages;
            }
            set
            {
                _pages = value;
            }
        }
    }
}
