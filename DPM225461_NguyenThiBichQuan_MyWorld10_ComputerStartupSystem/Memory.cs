using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld10_ComputerStartupSystem
{
    public class Memory
    {
        public void Load(string position, string data)
        {
            Console.WriteLine("Memory: Loading '{0}' from position {1}", data, position);
        }
    }
}
