using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld07_Implementor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abstraction
            Notification notify = new BasicNotification();

            // Gắn Implementor = Email và gọi
            notify.Channel = new EmailChannel("user@example.com");
            notify.Send("Xác nhận đơn hàng", "Đơn #A01 đã được xác nhận.");

            // Đổi Implementor = SMS mà không đổi Abstraction
            notify.Channel = new SmsChannel("0912345678");
            notify.Send("Mã OTP", "Mã của bạn là 482916.");

            // Dùng RefinedAbstraction (có logic bổ sung cho 'khẩn')
            Notification urgent = new UrgentNotification();
            urgent.Channel = new SmsChannel("0987654321");
            urgent.Send("Cảnh báo tồn kho", "Kho áo thun size M xuống dưới ngưỡng.");

            Console.WriteLine("=== DONE ===");
            Console.ReadLine(); // giữ console để xem output
        }
    }
}
