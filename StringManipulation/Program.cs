using System.Security.Cryptography.X509Certificates;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char symbol1 = 'R';
            char symbol2 = 'o';
            char symbol3 = 'k';
            char symbol4 = 'a';
            char symbol5 = 's';
            char[] chars = { 'R', 'o', 'k', 'a', 's' };

            var encoding = '/';

            Console.WriteLine(Console.ReadLine());
            Console.WriteLine((char)(chars[1] + encoding));
            Console.WriteLine((char)(chars[2] + encoding));
            Console.WriteLine((char)(chars[3] + encoding));
            Console.WriteLine((char)(chars[4] + encoding));



        }
    }
}