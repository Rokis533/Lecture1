using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class SportLeague<T>
    {
        private readonly List<T> teams;

        public SportLeague()
        {
            teams = new List<T>();
        }
        public void AddTeam(T team)
        {
            Console.WriteLine($"Team name is");
        }

    }

    internal class SportLeague2
    {
        private readonly List<BasketballTeam> teams;

        public void AddTeam(BasketballTeam team)
        {
            Console.WriteLine($"Team name is{team.Name}");
        }
    }



}
