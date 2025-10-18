using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App01_PDF
{
    internal class ExcelReportExporter : ReportExporter
    {
        private readonly string _folder;
        public ExcelReportExporter(string folder)
        {
            _folder = folder;
        }

        public override void Interact(ReportData data)
        {
            // Giả lập xuất Excel (thực tế có thể dùng EPPlus, ClosedXML)
            var file = System.IO.Path.Combine(_folder, $"{Sanitize(data.Title)}.xlsx");
            Console.WriteLine("[Excel] Tạo workbook & sheet...");
            Console.WriteLine("[Excel] Tiêu đề: " + data.Title);
            for (int i = 0; i < data.Lines.Count; i++)
                Console.WriteLine("[Excel] Row " + (i + 1) + ": " + data.Lines[i]);
            Console.WriteLine("[Excel] Lưu file: " + file);
            Console.WriteLine();
        }

        private string Sanitize(string s)
        {
            foreach (var c in System.IO.Path.GetInvalidFileNameChars())
                s = s.Replace(c.ToString(), "");
            return s.Replace(" ", "_");
        }
    }
}

