using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsInClass
{
    internal class ToyBox
    {
        private List<Toy> toys = new();

        public ToyBox()
        {

        }
        public void AddToy(Toy toy)
        {
            toys.Add(toy);
        }
        public void RemoveToy(Toy toy)
        {
            toys.Remove(toy);
        }
        public void PrintNameOfToys()
        {
            foreach (Toy toy in SortToys(toys))
            {
                Console.WriteLine(toy.Name);
            }
        }
        public void PrintNameOfToys(int weight)
        {
            foreach (Toy toy in SortToys(toys))
            {
                if (toy.Weight == weight)
                {
                    Console.WriteLine(toy.Name);
                }
            }
        }
        private List<Toy> SortToys(List<Toy> toysList)
        {
            return toysList.OrderBy(x => x.Name).ToList();
        }
    }
}
