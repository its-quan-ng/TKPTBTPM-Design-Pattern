using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld21_Shipment
{
    public class StandardShipping : IShippingStrategy
    {
        public decimal Calculate(Shipment s)
        {
            decimal baseFee = 15000m;
            decimal distance = 2000m * s.DistanceKm;
            decimal weight = 3000m * s.WeightKg;
            return baseFee + distance + weight;
        }
    }
}
