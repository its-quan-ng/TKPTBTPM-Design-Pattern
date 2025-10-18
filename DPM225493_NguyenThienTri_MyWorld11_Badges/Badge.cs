using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld11_Badges
{
    internal abstract class Badge
    {
        // extrinsic state truyền vào lúc gọi
        public abstract void Operation(int orderId);
    }
}
