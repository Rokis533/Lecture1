using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsInClass
{
    internal class ErrorPrint
    {

        public void PrintNotification(string message)
        {
            Console.WriteLine(message);
        }
        public void PrintNotification(string message, string type)
        {
            Console.WriteLine($"[{type}] {message}");
        }
        public void PrintNotification(string message, string type, bool isError)
        {
            if (isError)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[{type}] {message}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[{type}] {message}");
                Console.ResetColor();
            }
        }

    }
}
