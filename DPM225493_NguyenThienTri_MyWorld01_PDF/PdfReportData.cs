using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App01_PDF
{
    internal class PdfReportData :ReportData
    {
        public PdfReportData(string title, IList<string> lines)
        {
            Title = title;
            Lines = lines;
        }
    }
}
