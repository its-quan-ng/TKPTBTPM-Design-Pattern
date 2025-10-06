using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Pattern12_Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();
            Console.ReadKey();
        }
    }
}
