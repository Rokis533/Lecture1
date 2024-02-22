using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }


        public override string ToString()
        {
            return $"This Person is {Name} and his age is {Age}";
        }
    }
}
