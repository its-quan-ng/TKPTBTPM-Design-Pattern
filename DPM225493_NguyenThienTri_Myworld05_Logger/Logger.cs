using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Myworld05_Logger
{
    internal class Logger
    {
        private static Logger _instance;

        // Giữ nguyên tinh thần structural: constructor 'protected'
        protected Logger() { }

        // Phương thức truy xuất Singleton (lazy init – không thread-safe, đơn giản)
        public static Logger Instance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Log(LogLevel level, string message)
        {
            var ts = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"[{ts}] [{level}] {message}");
        }
    }
}
