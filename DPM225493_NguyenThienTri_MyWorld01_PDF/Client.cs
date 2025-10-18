using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App01_PDF
{
    internal class Client
    {
        private readonly ReportData _data;
        private readonly ReportExporter _exporter;

        public Client(ReportFactory factory, string title, IList<string> lines, string outputFolder)
        {
            _data = factory.CreateReportData(title, lines);
            _exporter = factory.CreateReportExporter(outputFolder);
        }

        public void Run()
        {
            _exporter.Interact(_data);
        }
    }
}
