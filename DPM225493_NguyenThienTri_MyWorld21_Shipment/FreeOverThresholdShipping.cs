using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld21_Shipment
{
    public class FreeOverThresholdShipping : IShippingStrategy
    {
        private readonly decimal _minSubtotal;
        private readonly decimal _maxDistanceKm;
        private readonly decimal _maxWeightKg;
        private readonly IShippingStrategy _fallback;

        public FreeOverThresholdShipping(
            decimal minSubtotal, decimal maxDistanceKm, decimal maxWeightKg, IShippingStrategy fallback)
        {
            _minSubtotal = minSubtotal;
            _maxDistanceKm = maxDistanceKm;
            _maxWeightKg = maxWeightKg;
            _fallback = fallback;
        }

        public decimal Calculate(Shipment s)
        {
            bool qualified =
                s.Subtotal >= _minSubtotal &&
                s.DistanceKm <= _maxDistanceKm &&
                s.WeightKg <= _maxWeightKg;

            return qualified ? 0m : _fallback.Calculate(s);
        }
    }
}
