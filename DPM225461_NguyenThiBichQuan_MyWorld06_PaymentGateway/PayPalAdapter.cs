using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld06_PaymentGateway
{
    internal class PayPalAdapter : IPaymentProcessor
    {
        private PayPalAPI paypal;
        public PayPalAdapter()
        {
            paypal = new PayPalAPI();
        }

        public void ProcessPayment(decimal amount, string accountInfo)
        {
            paypal.SendPayment((double)amount, accountInfo);
        }

        public bool ValidateAccount(string accountInfo)
        {
            return paypal.CheckEmail(accountInfo);
        }
    }
}
