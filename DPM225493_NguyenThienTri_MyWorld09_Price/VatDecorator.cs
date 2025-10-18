using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld09_Price
{
    internal class VatDecorator : PriceDecorator
    {
        private readonly decimal _percent; // 0.10 = 10%

        public VatDecorator(decimal percent)
        {
            _percent = percent;
        }

        public override decimal Calculate()
        {
            var baseAmount = base.Calculate();
            var vat = baseAmount * _percent;
            var after = baseAmount + vat;

            Console.WriteLine("VAT {0}%: +{1:n0} VND (thành {2:n0})",
                _percent * 100m, vat, after);

            return after;
        }
    }
}
