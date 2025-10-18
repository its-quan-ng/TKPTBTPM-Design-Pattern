using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld13_RefundHandler
{
    internal class AgentHandler : RefundHandler
    {
        private const int Limit = 200000;

        public override void Handle(int amount, string orderId)
        {
            if (amount <= Limit)
            {
                Console.WriteLine("[Agent] Approved refund {0:n0} VND for {1}", amount, orderId);
            }
            else if (_next != null)
            {
                Console.WriteLine("[Agent] Escalate {0:n0} VND for {1}", amount, orderId);
                _next.Handle(amount, orderId);
            }
        }
    }
}
