using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld09_Price
{
    internal class DiscountDecorator : PriceDecorator
    {
        private readonly decimal _percent; // 0.10 = 10%

        public DiscountDecorator(decimal percent)
        {
            _percent = percent;
        }

        public override decimal Calculate()
        {
            var baseAmount = base.Calculate();
            var discount = baseAmount * _percent;
            var after = baseAmount - discount;

            Console.WriteLine("Giảm giá {0}%: -{1:n0} VND (còn {2:n0})",
                _percent * 100m, discount, after);

            return after;
        }
    }
}
