using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App01_PDF
{
    abstract class ReportFactory
    {
        public abstract ReportData CreateReportData(string title, IList<string> lines);
        public abstract ReportExporter CreateReportExporter(string outputFolder);
    }
}
