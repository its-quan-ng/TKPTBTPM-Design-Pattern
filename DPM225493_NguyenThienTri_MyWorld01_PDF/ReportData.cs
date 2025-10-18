using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App01_PDF
{
    abstract class ReportData
    {
        public string Title { get; protected set; }
        public IList<string> Lines { get; protected set; }
    }
}
