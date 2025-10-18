using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld21_Shipment
{
    internal class ShippingCostCalculator
    {
        private IShippingStrategy _strategy;

        public ShippingCostCalculator(IShippingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IShippingStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal Calculate(Shipment shipment)
        {
            return _strategy.Calculate(shipment);
        }
    }
}
