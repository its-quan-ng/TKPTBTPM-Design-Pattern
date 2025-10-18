using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App01_PDF
{
    internal class PdfReportExporter : ReportExporter
    {
        private readonly string _folder;
        public PdfReportExporter(string folder)
        {
            _folder = folder;
        }

        public override void Interact(ReportData data)
        {
            // Giả lập xuất PDF (thực tế bạn sẽ dùng iTextSharp, QuestPDF, v.v.)
            var file = System.IO.Path.Combine(_folder, $"{Sanitize(data.Title)}.pdf");
            Console.WriteLine("[PDF] Bắt đầu render...");
            Console.WriteLine("[PDF] Tiêu đề: " + data.Title);
            foreach (var line in data.Lines)
                Console.WriteLine("[PDF] + " + line);
            Console.WriteLine("[PDF] Lưu file: " + file);
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
