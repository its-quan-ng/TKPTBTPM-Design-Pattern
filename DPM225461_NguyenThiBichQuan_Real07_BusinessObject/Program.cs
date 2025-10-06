using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real07_BusinessObject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customers = new Customers();

            customers.Data = new CustomersData("Hong Kong");

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Irene Bae");
            customers.ShowAll();

            Console.ReadKey();
        }
    }
}
