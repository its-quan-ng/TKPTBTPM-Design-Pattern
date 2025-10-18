using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App03_SMS
{
    internal class EmailNotifier : Notifier
    {
        public override void Notify(string message)
        {
            // Giả lập gửi email (in ra console)
            Console.WriteLine("[Email] To: user@example.com | Content: " + message);
        }
    }
}
