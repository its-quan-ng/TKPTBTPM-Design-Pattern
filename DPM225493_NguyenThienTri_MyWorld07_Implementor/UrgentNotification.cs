using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld07_Implementor
{
    internal class UrgentNotification : Notification
    {
        public override void Send(string title, string content)
        {
            // Thêm tiền tố [URGENT] cho thông báo khẩn
            base.Send("[URGENT] " + title, content);
        }
    }
}
