using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsTopic.Models
{
    internal class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, string gender) : this(name)
        {
            Gender = gender;
        }
        public Person(string name, string gender, DateTime birthday) : this(name, gender)
        {
            Birthday = birthday;
        }

        public string Name
        {
            get { return "Block"; }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Value canoot be null");
                }
            }
        }
        private string name;
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }



    }
}
