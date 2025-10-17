using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld06_PaymentGateway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Using PayPal ---");
            IPaymentProcessor paypalProcessor = new PayPalAdapter();

            if (paypalProcessor.ValidateAccount("customer@gmail.com"))
            {
                paypalProcessor.ProcessPayment(100.50m, "customer@gmail.com");
            }

            Console.WriteLine("\n--- Using MoMo ---");

            IPaymentProcessor momoProcessor = new MoMoAdapter();

            if (momoProcessor.ValidateAccount("0901234567"))
            {
                momoProcessor.ProcessPayment(100.50m, "0901234567");
            }

            Console.ReadKey();
        }
    }
}
