using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Pattern04_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("Red");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
        }
    }
}
