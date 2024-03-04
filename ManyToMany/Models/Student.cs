using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public virtual List<Course> StudentCourses { get; set; }
    }
}
