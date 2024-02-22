using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccesabilityModifiers
{
    internal class TestChild : Test
    {
        private string Id = Guid.NewGuid().ToString();

        public void Print()
        {
            Console.WriteLine(Name);
        }
        public string Get()
        {
            return Id;
        }

    }
}
