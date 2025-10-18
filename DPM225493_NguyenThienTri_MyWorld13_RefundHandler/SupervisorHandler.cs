using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld13_RefundHandler
{
    internal class SupervisorHandler : RefundHandler
    {
        private const int Limit = 1000000;

        public override void Handle(int amount, string orderId)
        {
            if (amount <= Limit)
            {
                Console.WriteLine("[Supervisor] Approved refund {0:n0} VND for {1}", amount, orderId);
            }
            else if (_next != null)
            {
                Console.WriteLine("[Supervisor] Escalate {0:n0} VND for {1}", amount, orderId);
                _next.Handle(amount, orderId);
            }
        }
    }
}
