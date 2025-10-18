using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld11_Badges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new BadgeFactory();

            // Danh sách đơn hàng: (Status, OrderId)
            var orders = new List<(string status, int orderId)>
            {
                ("PAID",    1001),
                ("PENDING", 1002),
                ("PAID",    1003),   // sẽ tái sử dụng instance "PAID"
                ("CANCEL",  1004),
                ("PENDING", 1005),   // sẽ tái sử dụng instance "PENDING"
            };

            Console.WriteLine("=== Flyweight: Order Status Badges ===");

            foreach (var o in orders)
            {
                var badge = factory.GetBadge(o.status);
                badge.Operation(o.orderId); // extrinsic state = orderId
            }

            // Ví dụ 1 badge không-chia-sẻ (unshared) cho trạng thái đặc biệt
            var custom = new CustomBadge("REFUND-IN-REVIEW");
            custom.Operation(1010);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Badge instances cached = {0}", factory.CacheCount);

            Console.WriteLine("=== DONE ===");
            Console.ReadLine(); // giữ console để xem kết quả
        }
    }
 
}
