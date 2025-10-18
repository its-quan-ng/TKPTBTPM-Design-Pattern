using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld07_Implementor
{
    internal class BasicNotification : Notification
    {
        public override void Send(string title, string content)
        {
            // có thể thêm định dạng nhẹ nếu muốn
            base.Send(title, content);
        }
    }
}
