using DPM225493_NguyenThienTri_MyWorld17_AirTraffic.Colleagues;
using DPM225493_NguyenThienTri_MyWorld17_AirTraffic.MediatorNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld17_AirTraffic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirTrafficMediator tower = new ControlTowerMediator();

            var a1 = new PassengerJet("VN123", tower);
            var a2 = new CargoPlane("CX777", tower);

            tower.Register(a1);
            tower.Register(a2);

            a1.RequestLanding();
            a2.RequestLanding();
            a1.Landed();
            a2.RequestLanding();
            a2.Landed();

            a1.RequestTakeoff();
            a2.RequestTakeoff();
            a1.TookOff();
            a2.RequestTakeoff();
            a2.TookOff();

            Console.ReadLine();
        }
    }
}
