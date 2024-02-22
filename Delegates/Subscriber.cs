using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Subscriber
    {
        private string _name;
        public Subscriber(string name)
        {
            _name = name;
        }
        public void Subscribe(Publisher publisher)
        {
            publisher.Handler += HandleEvent;
        }

        private void HandleEvent(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{_name} received message: {message}");
            Console.ResetColor();
        }
    }
}
