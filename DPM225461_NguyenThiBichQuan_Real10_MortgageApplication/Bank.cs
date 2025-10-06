using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real10_MortgageApplication
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for customer " + c.Name);
            return true;
        }
    }
}
