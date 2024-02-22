using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndVirtual
{
    internal class Conference : Event
    {
        //public string Name { get; set; }

        public sealed override void StartEvent()
        {
            Console.WriteLine($"sadasdasdasd{Name} is starting");
        }
    }
}
