using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld10_ComputerStartupSystem
{
    class ComputerFacade
    {
        private CPU cpu;
        private Memory memory;
        private HardDrive hardDrive;

        public ComputerFacade()
        {
            cpu = new CPU();
            memory = new Memory();
            hardDrive = new HardDrive();
        }

        public void Start()
        {
            Console.WriteLine("=== STARTING COMPUTER ===\n");

            cpu.Freeze();
            string bootData = hardDrive.Read("boot sector", 1024);
            memory.Load("0x00", bootData);
            cpu.Jump("0x00");
            cpu.Execute();

            Console.WriteLine("\n=== COMPUTER STARTED SUCCESSFULLY ===");
        }
    }
}
