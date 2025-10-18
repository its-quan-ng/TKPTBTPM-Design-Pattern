using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld09_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thành phần lõi: tiền hàng (subtotal)
            var subtotal = new SubtotalComponent(499000m); // 499.000 VND

            // Các decorator thực tế
            var discount = new DiscountDecorator(0.10m);  // giảm 10%
            var vat = new VatDecorator(0.10m);       // VAT 10%
            var ship = new ShippingDecorator(30000m); // phí ship 30.000

            // Ghép chuỗi decorator giống structural code:
            // ship( vat( discount( subtotal ) ) )
            discount.SetComponent(subtotal);
            vat.SetComponent(discount);
            ship.SetComponent(vat);

            // Gọi tính toán & in breakdown
            Console.WriteLine("=== HÓA ĐƠN ===");
            decimal total = ship.Calculate();
            Console.WriteLine("------------------------------");
            Console.WriteLine("TỔNG PHẢI TRẢ: {0:n0} VND", total);

            Console.WriteLine("=== DONE ===");
            Console.ReadLine(); // giữ console để xem kết quả
        }
    }
    }

