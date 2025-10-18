using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld06_PaymentGateway
{
    interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount, string accountInfo);
        bool ValidateAccount(string accountInfo);
    }
}
