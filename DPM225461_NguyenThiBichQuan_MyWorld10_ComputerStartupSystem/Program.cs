using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld10_ComputerStartupSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComputerFacade computer = new ComputerFacade();
            computer.Start();
            Console.ReadKey();
        }
    }
}
