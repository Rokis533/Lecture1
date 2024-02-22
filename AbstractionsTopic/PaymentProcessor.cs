using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTopic
{
    internal abstract class PaymentProcessor
    {
        public string TransactionId { get; set; }
        public decimal Amount { get; set; }

        private string name;

        public void StartProcess()
        {
            TransactionId = Guid.NewGuid().ToString();
            Console.WriteLine($"Starting a transaction of {TransactionId}");
        }

        public abstract void Process();

    }
}
