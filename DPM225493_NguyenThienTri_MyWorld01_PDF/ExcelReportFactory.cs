using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App01_PDF
{
    internal class ExcelReportFactory :ReportFactory
    {
        public override ReportData CreateReportData(string title, IList<string> lines)
        {
            return new ExcelReportData(title, lines);
        }

        public override ReportExporter CreateReportExporter(string outputFolder)
        {
            return new ExcelReportExporter(outputFolder);
        }
    }
}
