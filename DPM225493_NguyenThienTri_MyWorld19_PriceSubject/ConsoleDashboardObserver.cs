using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld19_PriceSubject
{
    internal class ConsoleDashboardObserver : Observer
    {
        private readonly PriceSubject _subject;
        private readonly string _name;

        public ConsoleDashboardObserver(PriceSubject subject, string name)
        {
            _subject = subject;
            _name = name;
        }

        public override void Update()
        {
            Console.WriteLine($"[{_name}] {_subject.ProductName} new price: {_subject.Price:n0} VND");
        }
    }
}
