using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Myworld05_Logger
{
    internal class OrderService
    {
        private readonly Logger _logger;

        public OrderService()
        {
            _logger = Logger.Instance();
        }

        public void CreateOrder(string orderId, decimal amount)
        {
            _logger.Log(LogLevel.Info, $"Creating order {orderId} with amount {amount:n0} VND");
            // ... nghiệp vụ tạo đơn hàng (giả lập)
            _logger.Log(LogLevel.Info, $"Order {orderId} created successfully");
        }
    }
}
