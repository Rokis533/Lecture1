
namespace AbstractionsTopic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardProcessor cardProcessor = new CreditCardProcessor()
            {
                Amount = 100,
                CardNumber = "LT15618656549546546"
            };

            PaypalProcessor paypalProcessor = new PaypalProcessor()
            {
                Amount = 965,
                Email = "Rokis@mail.com"
            };

            cardProcessor.StartProcess();
            PaypalProcessor paypal = cardProcessor.CreditCardToPaypal();















            List<PaymentProcessor> paymentProcessors = new List<PaymentProcessor>();
            paymentProcessors.Add(cardProcessor);
            paymentProcessors.Add(paypalProcessor);

            foreach (var processor in paymentProcessors)
            {
                processor.StartProcess();
                processor.Process();

                if (processor is CreditCardProcessor card)
                {
                    card.Test();
                }
            }
        }
    }


}
