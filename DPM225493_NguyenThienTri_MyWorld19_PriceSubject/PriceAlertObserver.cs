using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld19_PriceSubject
{
    internal class PriceAlertObserver : Observer
    {
        private readonly PriceSubject _subject;
        private readonly string _name;
        private readonly decimal _threshold;

        public PriceAlertObserver(PriceSubject subject, string name, decimal threshold)
        {
            _subject = subject;
            _name = name;
            _threshold = threshold;
        }

        public override void Update()
        {
            if (_subject.Price <= _threshold)
            {
                Console.WriteLine($"[ALERT:{_name}] {_subject.ProductName} <= {_threshold:n0} VND (now: {_subject.Price:n0})");
            }
            else
            {
                Console.WriteLine($"[ALERT:{_name}] No alert (now: {_subject.Price:n0})");
            }
        }
    }
}
