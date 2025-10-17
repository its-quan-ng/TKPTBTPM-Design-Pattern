using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld10_ComputerStartupSystem
{
    class HardDrive
    {
        public string Read(string sector, int size)
        {
            Console.WriteLine("HardDrive: Reading {0} bytes from sector {1}", size, sector);
            return "boot data";
        }
    }
}
