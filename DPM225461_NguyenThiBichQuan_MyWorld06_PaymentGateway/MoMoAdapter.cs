using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld06_PaymentGateway
{
    internal class MoMoAdapter : IPaymentProcessor
    {
        private MoMoAPI momo;
        public MoMoAdapter()
        {
            momo = new MoMoAPI();
        }
        public void ProcessPayment(decimal amount, string accountInfo)
        {
            int money  = (int)(amount * 25000);
            momo.SendPayment(money, accountInfo);
        }
        public bool ValidateAccount(string accountInfo)
        {
            return momo.CheckingPhoneNumber(accountInfo);
        }
    }
}
