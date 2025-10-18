using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld07_Implementor
{
    internal class Notification
    {
        protected Channel _channel;

        public Channel Channel
        {
            set { _channel = value; }
        }

        public virtual void Send(string title, string content)
        {
            _channel.Send(title, content);
        }
    }
}
