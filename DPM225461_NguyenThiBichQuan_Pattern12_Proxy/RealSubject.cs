using System;

namespace DPM225461_NguyenThiBichQuan_Pattern12_Proxy
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}
