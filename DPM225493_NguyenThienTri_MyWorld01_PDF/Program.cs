using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App01_PDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO XUẤT BÁO CÁO (Abstract Factory) ===\n");

            // Dữ liệu thực tế: báo cáo đơn hàng trong ngày
            var lines = new List<string>
        {
            "HĐ #INV-001 | Khách: Nguyen Van A | Tổng: 499,000đ",
            "HĐ #INV-002 | Khách: Tran Thi B | Tổng: 259,000đ",
            "HĐ #INV-003 | Khách: Le Van C  | Tổng: 799,000đ"
        };
            var title = "Bao cao don hang ngay 2025-10-18";
            var output = Environment.CurrentDirectory; // lưu ngay thư mục chạy

            // 1) Xuất PDF
            ReportFactory factory1 = new PdfReportFactory();
            var client1 = new Client(factory1, title, lines, output);
            client1.Run();

            // 2) Xuất Excel (không đổi code nghiệp vụ)
            ReportFactory factory2 = new ExcelReportFactory();
            var client2 = new Client(factory2, title, lines, output);
            client2.Run();

            Console.WriteLine("Hoàn tất. Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
    }
