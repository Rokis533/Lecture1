using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTopic
{
    internal static class CardExtentionMethods
    {
        public static PaypalProcessor CreditCardToPaypal(this CreditCardProcessor creditCard)
        {
            return new PaypalProcessor
            {
                TransactionId = creditCard.TransactionId,
                Amount = creditCard.Amount,
            };
        }
    }
}
