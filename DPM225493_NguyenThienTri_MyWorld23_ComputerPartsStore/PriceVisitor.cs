using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Real23_ComputerPartsStore
{
    internal class PriceVisitor : IComputerPartVisitor
    {
        private double totalPrice = 0;
        public double TotalPrice => totalPrice;
        public void Visit(Mouse mouse)
        {
            totalPrice += 25; // Example price for Mouse
        }
        public void Visit(Keyboard keyboard)
        {
            totalPrice += 50; // Example price for Keyboard
        }
        public void Visit(Monitor monitor)
        {
            totalPrice += 100; // Example price for Monitor
        }
    }
}
