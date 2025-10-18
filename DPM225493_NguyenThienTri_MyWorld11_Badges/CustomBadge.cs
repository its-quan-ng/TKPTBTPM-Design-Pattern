using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld11_Badges
{
    internal class CustomBadge : Badge
    {
        private readonly string _label;

        public CustomBadge(string label)
        {
            _label = label;
        }

        public override void Operation(int orderId)
        {
            Console.WriteLine($"[★] Order #{orderId} -> Custom = {_label}");
        }
    }
}
