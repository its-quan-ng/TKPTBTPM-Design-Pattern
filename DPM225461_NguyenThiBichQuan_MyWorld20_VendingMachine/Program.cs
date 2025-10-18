using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld20_VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine(3);
            Console.WriteLine("Machine loaded with 3 products\n");

            Console.WriteLine("--- Customer 1 ---");
            machine.InsertCoin();
            machine.SelectProduct();

            Console.WriteLine("--- Customer 2 ---");
            machine.SelectProduct();

            Console.WriteLine("--- Customer 3 ---");
            machine.InsertCoin();
            machine.SelectProduct();

            Console.ReadKey();
        }
    }
}
