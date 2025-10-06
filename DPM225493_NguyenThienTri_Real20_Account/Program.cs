using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Real20_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Jim Johnson");
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            Console.ReadKey();
        }
    }
}
