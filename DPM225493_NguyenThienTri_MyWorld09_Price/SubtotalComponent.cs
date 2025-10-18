using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld09_Price
{
    internal class SubtotalComponent : PriceComponent
    {
        private readonly decimal _subtotal;

        public SubtotalComponent(decimal subtotal)
        {
            _subtotal = subtotal;
        }

        public override decimal Calculate()
        {
            Console.WriteLine("Tiền hàng (Subtotal): {0:n0} VND", _subtotal);
            return _subtotal;
        }
    }
}
