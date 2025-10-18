using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld14_RemoteControl
{
    internal class Light
    {
        private string location;
        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine("{0} Light is ON", location);
        }

        public void Off()
        {
            Console.WriteLine("{0} Light is OFF", location);
        }
    }
}
