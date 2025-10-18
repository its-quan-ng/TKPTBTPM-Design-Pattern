using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld21_Shipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Đơn hàng mẫu
            var shipment = new Shipment
            {
                Subtotal = 499000m, // VND
                DistanceKm = 12m,     // km
                WeightKg = 1.5m     // kg
            };

            // 1) Vận chuyển chuẩn
            var calc = new ShippingCostCalculator(new StandardShipping());
            Console.WriteLine("Standard = {0:n0} VND", calc.Calculate(shipment));

            // 2) Vận chuyển nhanh
            calc.SetStrategy(new ExpressShipping());
            Console.WriteLine("Express  = {0:n0} VND", calc.Calculate(shipment));

            // 3) Miễn phí nếu đơn ≥ 400k, trong bán kính 15km, cân nặng ≤ 2kg
            calc.SetStrategy(new FreeOverThresholdShipping(
                minSubtotal: 400000m, maxDistanceKm: 15m, maxWeightKg: 2m, fallback: new StandardShipping()));
            Console.WriteLine("Promo    = {0:n0} VND", calc.Calculate(shipment));

            Console.WriteLine("=== DONE ===");
            Console.ReadLine(); // giữ console
        }
    }
    }

