using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Myworld05_Logger
{
    internal class AuthService
    {
        private readonly Logger _logger;

        public AuthService()
        {
            _logger = Logger.Instance();
        }

        public void Login(string email)
        {
            _logger.Log(LogLevel.Info, $"User '{email}' is logging in...");
            // ... nghiệp vụ đăng nhập (giả lập)
            _logger.Log(LogLevel.Info, $"User '{email}' logged in");
        }
}
}
