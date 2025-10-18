using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld10_ComputerStartupSystem
{
    class CPU
    {
        public void Freeze()
        {
            Console.WriteLine("CPU: Freezing processor...");
        }

        public void Jump(string position)
        {
            Console.WriteLine("CPU: Jumping to position {0}", position);
        }

        public void Execute()
        {
            Console.WriteLine("CPU: Executing instructions...");
        }
    }
}
