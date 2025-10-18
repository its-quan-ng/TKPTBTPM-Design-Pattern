using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld13_RefundHandler
{
    internal abstract class RefundHandler
    {
        protected RefundHandler _next;

        public void SetNext(RefundHandler next)
        {
            _next = next;
        }

        // amount: số tiền hoàn, orderId: mã đơn (extrinsic info)
        public abstract void Handle(int amount, string orderId);
    }
}

