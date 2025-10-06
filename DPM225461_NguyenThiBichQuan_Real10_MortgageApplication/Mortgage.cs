using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real10_MortgageApplication
{
    public class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();
        public bool IsEligible(Customer c, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", c.Name, amount);
            bool eligible = true;
            if (!bank.HasSufficientSavings(c, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(c))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(c))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}
