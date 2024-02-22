using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTopic
{
    public enum WeekDays
    {
        Monday = 1, // 1
        Tuesday = 2,// 2
        Wednesday = 3,// 3
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }

    [Flags]
    public enum Permition
    {
        Read = 4,       // 001
        Write = 2,      // 010
        Execute = 1,    // 100
    }     // read and write   = 011          
}
