using System.Runtime.CompilerServices;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine(random.Next(1, 3));
            Console.WriteLine(random.Next(1, 3));
            Console.WriteLine(random.Next(1, 3));
            Console.WriteLine(random.Next(1, 3));
            Console.WriteLine(random.Next(1, 3));
            Console.WriteLine(random.Next(1, 3));
            Console.WriteLine(random.Next(1, 3));
            Console.WriteLine(random.Next(1, 3)); Console.WriteLine(random.Next(1, 3));

            string input = Console.ReadLine();

            Console.Clear();

            string word1 = "is";
            string word2 = "a";
            string word3 = input;

            Console.WriteLine("Write a " + word3 + " name:");

            string city = Console.ReadLine();


            Console.Clear();

            string print = "";

            print += city;
            print += " ";
            print += word1;
            print += " ";
            print += word2;
            print += " ";
            print += word3;

            bool ass, sad = true;



            Console.WriteLine(print);


        }
    }
}