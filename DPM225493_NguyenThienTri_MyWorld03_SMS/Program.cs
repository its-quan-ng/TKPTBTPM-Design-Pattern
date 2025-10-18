using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App03_SMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotifierCreator[] creators = new NotifierCreator[]
            {
                new EmailNotifierCreator(),
                new SmsNotifierCreator()
            };

            // Tạo Notifier từ từng Creator và gọi hành vi thực tế
            foreach (var creator in creators)
            {
                Notifier notifier = creator.FactoryMethod();
                Console.WriteLine("Created {0}", notifier.GetType().Name);
                notifier.Notify("Đơn hàng #A01 đã xác nhận.");
            }

            Console.WriteLine("=== DONE ===");
            Console.ReadLine(); // giữ cửa sổ để xem output
        }
    }
   }
