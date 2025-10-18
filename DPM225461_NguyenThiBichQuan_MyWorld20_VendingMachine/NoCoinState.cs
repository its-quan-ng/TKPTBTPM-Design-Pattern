using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld20_VendingMachine
{
    internal class NoCoinState : IState
    {
        private VendingMachine machine;

        public NoCoinState(VendingMachine machine)
        {
            this.machine = machine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Coin inserted");
            machine.SetState(machine.HasCoinState);
        }

        public void SelectProduct()
        {
            Console.WriteLine("Insert coin first!");
        }

        public void Dispense()
        {
            Console.WriteLine("Insert coin first!");
        }
    }
}
