using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany.Models
{
    public class Book : BaseModel
    {

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public virtual List<Author> Authors { get; set; }
    }
}
