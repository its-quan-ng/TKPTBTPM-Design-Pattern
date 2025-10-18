using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld21_Shipment
{
    public class ExpressShipping : IShippingStrategy
    {
        public decimal Calculate(Shipment s)
        {
            decimal baseFee = 30000m;
            decimal distance = 3500m * s.DistanceKm;
            decimal weight = 4500m * s.WeightKg;
            return baseFee + distance + weight;
        }
    }
}
