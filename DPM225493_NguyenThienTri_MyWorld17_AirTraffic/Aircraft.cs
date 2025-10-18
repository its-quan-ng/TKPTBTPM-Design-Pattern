using DPM225493_NguyenThienTri_MyWorld17_AirTraffic.MediatorNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld17_AirTraffic.Colleagues
{
    public abstract class Aircraft
    {
        protected readonly AirTrafficMediator _tower;
        public string CallSign { get; private set; }

        protected Aircraft(string callSign, AirTrafficMediator tower)
        {
            CallSign = callSign;
            _tower = tower;
        }

        public void RequestLanding()
        {
            Console.WriteLine($"{CallSign}: Requesting landing.");
            _tower.RequestLanding(this);
        }

        public void RequestTakeoff()
        {
            Console.WriteLine($"{CallSign}: Requesting takeoff.");
            _tower.RequestTakeoff(this);
        }

        public void Landed()
        {
            Console.WriteLine($"{CallSign}: Landed, runway vacated.");
            _tower.RunwayFreed(this);
        }

        public void TookOff()
        {
            Console.WriteLine($"{CallSign}: Airborne, runway vacated.");
            _tower.RunwayFreed(this);
        }

        public abstract void Receive(string message);
    }
}

