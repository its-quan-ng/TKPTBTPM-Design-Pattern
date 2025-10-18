using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld07_Implementor
{
    internal class SmsChannel : Channel
    {
        private readonly string _phone;
        public SmsChannel(string phone) => _phone = phone;

        public override void Send(string title, string content)
        {
            // Với SMS ta gộp title + content cho gọn
            Console.WriteLine($"[SMS] To={_phone} | Msg={title}: {content}");
        }
    }
}
