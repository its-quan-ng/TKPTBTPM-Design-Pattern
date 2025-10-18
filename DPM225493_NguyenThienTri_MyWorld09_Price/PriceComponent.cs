using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld09_Price
{
    internal abstract class PriceComponent
    {
        // Trả về số tiền sau khi áp dụng logic của lớp hiện tại
        public abstract decimal Calculate();
    }
}
