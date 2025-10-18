using DPM225493_NguyenThienTri_MyWorld17_AirTraffic.MediatorNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld17_AirTraffic.Colleagues
{
    public class CargoPlane : Aircraft
    {
        public CargoPlane(string callSign, AirTrafficMediator tower) : base(callSign, tower) { }

        public override void Receive(string message)
        {
            Console.WriteLine($"{CallSign} [CargoPlane] <= {message}");
        }
    }
}
