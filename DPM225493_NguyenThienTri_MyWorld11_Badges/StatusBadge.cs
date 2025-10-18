using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld11_Badges
{
    internal class StatusBadge : Badge
    {
        // Intrinsic state: tên trạng thái & ký hiệu hiển thị
        private readonly string _status;
        private readonly string _symbol;

        public StatusBadge(string status)
        {
            _status = status.ToUpperInvariant();
            switch (_status)
            {
                case "PAID":
                    _symbol = "✔";
                    break;
                case "PENDING":
                    _symbol = "⏳";
                    break;
                case "CANCEL":
                    _symbol = "✖";
                    break;
                default:
                    _symbol = "•";
                    break;
            }
        }

        public override void Operation(int orderId)
        {
            // extrinsic = orderId
            Console.WriteLine($"[{_symbol}] Order #{orderId} -> Status = {_status}");
        }
    }
}
