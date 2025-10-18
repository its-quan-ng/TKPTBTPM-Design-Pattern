using DPM225493_NguyenThienTri_MyWorld17_AirTraffic.Colleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld17_AirTraffic.MediatorNS
{
    public abstract class AirTrafficMediator
    {
        public abstract void Register(Aircraft aircraft);
        public abstract void RequestLanding(Aircraft aircraft);
        public abstract void RequestTakeoff(Aircraft aircraft);
        public abstract void RunwayFreed(Aircraft aircraft);
    }
}
