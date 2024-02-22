using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndVirtual
{
    internal class Meeting : Event
    {
        public DateTime MeetingTime { get; set; }

        public Meeting(string name)
        {

        }
        public override void StartEvent()
        {
            Console.WriteLine($"{Name} conference is starting at {MeetingTime.ToString("yyyy-MM-dd")}");
        }
    }
}
