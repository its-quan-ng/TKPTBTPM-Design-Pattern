using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Pattern06_Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();
            Console.ReadKey();
        }
    }
}
