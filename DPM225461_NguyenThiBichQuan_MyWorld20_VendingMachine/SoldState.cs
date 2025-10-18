using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld20_VendingMachine
{
    internal class SoldState : IState
    {
        private VendingMachine machine;

        public SoldState(VendingMachine machine)
        {
            this.machine = machine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Please wait, dispensing...");
        }

        public void SelectProduct()
        {
            Console.WriteLine("Please wait, dispensing...");
        }

        public void Dispense()
        {
            machine.ReleaseProduct();

            if (machine.ProductCount > 0)
            {
                Console.WriteLine("Ready for next customer\n");
                machine.SetState(machine.NoCoinState);
            }
            else
            {
                Console.WriteLine("Machine is now empty!\n");
            }
        }
    }
}
