using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public abstract class Sport
    {
        public string Name { get; set; }

        public string Rules { get; set; }
    }

    //next file

    internal class BasketballTeam : Sport
    {

    }
    internal class FootballTeam : Sport
    {

    }
    internal class TenisTeam : Sport
    {

    }
}
