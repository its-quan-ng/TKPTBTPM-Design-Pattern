using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld20_VendingMachine
{
    internal class HasCoinState : IState
    {
        private VendingMachine machine;

        public HasCoinState(VendingMachine machine)
        {
            this.machine = machine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Coin already inserted!");
        }

        public void SelectProduct()
        {
            Console.WriteLine("Product selected");
            machine.SetState(machine.SoldState);
            machine.Dispense();
        }

        public void Dispense()
        {
            Console.WriteLine("Select product first!");
        }
    }
}
