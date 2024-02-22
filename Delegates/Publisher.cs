using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyEventHandler(string message);
    internal class Publisher
    {
        public event MyEventHandler Handler; // holds all methods(subscriber)

        public void Notify(string message)
        {
            Handler?.Invoke(message);
        }
    }
}
