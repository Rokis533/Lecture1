using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstractionsTopic
{
    internal class CreditCardProcessor : PaymentProcessor
    {
        public string CardNumber { get; set; }


        public override void Process()
        {
            Console.WriteLine($"Processing credit card {CardNumber} with amount {Amount}");

            for (int i = 0; i < 100; i++)
            {
                Console.Write("0");
                Thread.Sleep(300);
            }
        }
        public void Test()
        {
            Console.WriteLine();
        }
    }
}
