using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesabilityModifiers
{
    public class Test
    {
        private string name;

        protected string Name
        {
            get { return name; }
            private set { name = value; }
        }
        protected void PrintInfo()
        {
            Console.WriteLine($"{Name}");
        }
        public bool IsValid()
        {
            return true; //do the checks
        }

    }
}
