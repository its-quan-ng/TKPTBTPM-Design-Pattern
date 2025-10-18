using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Myworld05_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger1 = Logger.Instance();
            var logger2 = Logger.Instance();

            Console.WriteLine("Same instance? " + (logger1 == logger2)); // True

            // Gọi 2 service khác nhau – cả hai đều ghi qua cùng 1 Logger
            var order = new OrderService();
            order.CreateOrder("INV-2025-0001", 499000m);

            var auth = new AuthService();
            auth.Login("user@example.com");

            logger1.Log(LogLevel.Info, "App finished.");

            Console.WriteLine("=== DONE ===");
            Console.ReadLine(); // giữ console để xem output
        }
    }
    }

