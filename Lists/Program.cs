using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> country = new List<string> { "Lithuania", "Poland", "USA", "England", "Norway", "Japan", "Italy", "Spain" };

            List<string> cities = new List<string>();
            cities.Add("Kaunas");
            cities.Add("Vilnius");
            cities.Add("Klaipėda");
            cities.Add("Tauragė");
            cities.Add("Šiauliai");
            cities.Add("Nida");

            List<string> names = Construct(country, cities);
            Print(names);

        }

        static List<string> Construct(List<string> countries, List<string> cities)
        {
            List<string> namesOCities = new List<string>();
            foreach (string country in countries)
            {
                foreach (string city in cities)
                {
                    namesOCities.Add($"{city}, {country}");
                }
            }

            return namesOCities;

        }











        static void Create(out List<int> list)
        {
            list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
        }

        static void Print(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
