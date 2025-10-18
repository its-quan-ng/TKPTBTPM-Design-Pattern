using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld13_RefundHandler
{
    internal class DirectorHandler : RefundHandler
    {
        public override void Handle(int amount, string orderId)
        {
            // Ở ví dụ này, ta giả sử Director luôn duyệt (hoặc có thể từ chối theo rule riêng)
            Console.WriteLine("[Director] FINAL decision: Approved refund {0:n0} VND for {1}", amount, orderId);
        }
    }
}
