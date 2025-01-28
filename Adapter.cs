using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class Adapter
    {
    }

    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount, string destinationAccount);
    }

    public class IntrernalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount, string destinationAccount)
        {
            Console.WriteLine($"Processing payment of {amount} to {destinationAccount}");
        }
    }

    public class ThirdPartyPaymentProcessor
    {
        public void Pay(decimal amount, string destinationAccount)
        {
            Console.WriteLine($"Paying {amount} to {destinationAccount}");
        }
    }

    public class PaymentAdapter(ThirdPartyPaymentProcessor thirdPartyPaymentProcessor) : IPaymentProcessor
    {
       
        public void ProcessPayment(decimal amount, string destinationAccount)
        {
            thirdPartyPaymentProcessor.Pay(amount, destinationAccount);
        }
    }

}
