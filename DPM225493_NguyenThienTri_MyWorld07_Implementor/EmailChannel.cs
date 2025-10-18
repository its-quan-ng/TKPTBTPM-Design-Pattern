using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld07_Implementor
{
    internal class EmailChannel : Channel
    {
        private readonly string _toEmail;
        public EmailChannel(string toEmail) => _toEmail = toEmail;

        public override void Send(string title, string content)
        {
            Console.WriteLine($"[EMAIL] To={_toEmail} | Title={title} | Body={content}");
        }
    }
}
