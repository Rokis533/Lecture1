using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Database.Models
{
    internal class Page
    {
        [Key]
        public Guid Id { get; set; }
        public int Number { get; set; }
        [StringLength(255)]
        public string Content { get; set; }

        [ForeignKey("Book")]
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }

        public Page(int number, string content)
        {
            Id = Guid.NewGuid();
            Number = number;
            Content = content;
        }

    }
}
