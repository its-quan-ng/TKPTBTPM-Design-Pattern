using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld09_Price
{
    internal class ShippingDecorator : PriceDecorator
    {
        private readonly decimal _fee; // phí ship cố định

        public ShippingDecorator(decimal fee)
        {
            _fee = fee;
        }

        public override decimal Calculate()
        {
            var baseAmount = base.Calculate();
            var after = baseAmount + _fee;

            Console.WriteLine("Phí vận chuyển: +{0:n0} VND (thành {1:n0})",
                _fee, after);

            return after;
        }
    }
}
