using DPM225493_NguyenThienTri_MyWorld17_AirTraffic.Colleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld17_AirTraffic.MediatorNS
{
    public class ControlTowerMediator : AirTrafficMediator
    {
        private bool _runwayBusy;
        private string _current;
        private readonly Dictionary<string, Aircraft> _fleet =
            new Dictionary<string, Aircraft>(StringComparer.OrdinalIgnoreCase);

        public override void Register(Aircraft aircraft)
        {
            if (aircraft == null || string.IsNullOrWhiteSpace(aircraft.CallSign)) return;
            if (!_fleet.ContainsKey(aircraft.CallSign)) _fleet.Add(aircraft.CallSign, aircraft);
        }

        public override void RequestLanding(Aircraft aircraft)
        {
            if (!_runwayBusy)
            {
                _runwayBusy = true;
                _current = aircraft.CallSign;
                aircraft.Receive("[TOWER] Cleared to land.");
            }
            else
            {
                aircraft.Receive("[TOWER] Runway busy. Hold pattern and standby.");
            }
        }

        public override void RequestTakeoff(Aircraft aircraft)
        {
            if (!_runwayBusy)
            {
                _runwayBusy = true;
                _current = aircraft.CallSign;
                aircraft.Receive("[TOWER] Cleared for takeoff, runway 25.");
            }
            else
            {
                aircraft.Receive("[TOWER] Unable takeoff now. Line up and wait.");
            }
        }

        public override void RunwayFreed(Aircraft aircraft)
        {
            if (_runwayBusy && string.Equals(_current, aircraft.CallSign, StringComparison.OrdinalIgnoreCase))
            {
                _runwayBusy = false;
                _current = null;
                foreach (var kv in _fleet) kv.Value.Receive("[TOWER] Runway is now free.");
            }
        }
    }
}
