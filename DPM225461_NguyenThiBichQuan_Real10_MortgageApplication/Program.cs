using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real10_MortgageApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();
            Customer customer = new Customer("Irene Bae");
            bool eligible = mortgage.IsEligible(customer, 903000);
            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approve" : "Reject"));
            Console.ReadKey();
        }
    }
}
