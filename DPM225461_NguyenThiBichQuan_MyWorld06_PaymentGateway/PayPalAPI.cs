using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld06_PaymentGateway
{
    class PayPalAPI
    {
        public void SendPayment(double money, string email)
        {
            Console.WriteLine("PayPal: Processing ${0} to {1}", money, email);
            Console.WriteLine("PayPal: Payment successful!");
        }

        public bool CheckEmail(string email)
        {
            Console.WriteLine("PayPal: Validating email {0}", email);
            return email.Contains("@");
        }
    }
}
