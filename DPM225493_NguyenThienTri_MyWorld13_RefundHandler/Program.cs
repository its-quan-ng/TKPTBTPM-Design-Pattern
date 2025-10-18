using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld13_RefundHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            RefundHandler h1 = new AgentHandler();        // <= 200,000 VND
            RefundHandler h2 = new SupervisorHandler();   // <= 1,000,000 VND
            RefundHandler h3 = new ManagerHandler();      // <= 5,000,000 VND
            RefundHandler h4 = new DirectorHandler();     // > 5,000,000 VND (quyết định cuối)

            h1.SetNext(h2);
            h2.SetNext(h3);
            h3.SetNext(h4);

            // Một số yêu cầu hoàn tiền (đơn vị: VND)
            int[] requests = { 120000, 350000, 980000, 2000000, 7200000, 50000 };

            Console.WriteLine("=== Chain of Responsibility: Refund Approval ===");
            foreach (int amount in requests)
            {
                h1.Handle(amount, "INV-" + amount); // truyền cả mã đơn cho dễ theo dõi
            }

            Console.WriteLine("=== DONE ===");
            Console.ReadLine(); // giữ console để xem kết quả
        }
    }
    
}
