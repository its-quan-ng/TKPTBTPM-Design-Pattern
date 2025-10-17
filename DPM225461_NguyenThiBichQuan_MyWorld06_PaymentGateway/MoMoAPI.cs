using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld06_PaymentGateway
{
    internal class MoMoAPI
    {
        public void SendPayment(int money, string phone)
        {
            Console.WriteLine("MoMo: Processing{0} VND for phone {1}", phone, money);
            Console.WriteLine("MoMo: Payment successful!");
        }

        public bool CheckingPhoneNumber(string phone)
        {
            Console.WriteLine("MoMo: Check phone number {0}", phone);
            return phone.Length == 10;
        }
    }
}
