using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld19_PriceSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subject = new PriceSubject("Laptop X");

            // Đăng ký observers
            subject.Attach(new ConsoleDashboardObserver(subject, "Dashboard#1"));
            subject.Attach(new PriceAlertObserver(subject, "Alert#399k", 399000m));
            subject.Attach(new PriceAlertObserver(subject, "Alert#350k", 350000m));

            Console.WriteLine("=== Observer: Product Price Tracking ===");

            // Đổi giá & thông báo
            subject.Price = 459000m; subject.Notify();
            subject.Price = 389000m; subject.Notify();
            subject.Price = 349000m; subject.Notify();

            Console.WriteLine("=== DONE ===");
            Console.ReadLine();
        }
    }
    
}
