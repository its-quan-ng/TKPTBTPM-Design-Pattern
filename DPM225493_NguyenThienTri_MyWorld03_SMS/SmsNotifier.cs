using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App03_SMS
{
    internal class SmsNotifier : Notifier
    {
        public override void Notify(string message)
        {
            // Giả lập gửi SMS (in ra console)
            Console.WriteLine("[SMS] To: 0912345678 | Content: " + message);
        }
    }
}
