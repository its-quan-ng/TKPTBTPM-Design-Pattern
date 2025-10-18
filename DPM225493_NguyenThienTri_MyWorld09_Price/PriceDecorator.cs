using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld09_Price
{
    internal class PriceDecorator : PriceComponent
    {
        protected PriceComponent _component;

        public void SetComponent(PriceComponent component)
        {
            _component = component;
        }

        public override decimal Calculate()
        {
            return _component != null ? _component.Calculate() : 0m;
        }
    }
}
