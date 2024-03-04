using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public virtual List<Student> CourseStudents { get; set; }
    }
}
