using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld21_Shipment
{
    public interface IShippingStrategy
    {
        decimal Calculate(Shipment shipment);

    }
}
