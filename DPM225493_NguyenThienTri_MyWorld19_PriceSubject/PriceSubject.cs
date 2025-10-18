using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld19_PriceSubject
{
    internal class PriceSubject : Subject
    {
        public string ProductName { get; private set; }

        // state được theo dõi
        public decimal Price { get; set; }

        public PriceSubject(string productName)
        {
            ProductName = productName ?? "Unknown";
        }
    }
}
