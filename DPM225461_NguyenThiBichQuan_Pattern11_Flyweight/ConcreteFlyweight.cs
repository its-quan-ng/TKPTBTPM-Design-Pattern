using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Pattern11_Flyweight
{
    public class ConcreteFlyweight: Flyweight
    {
        public override void Operation(int extrinsicState)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicState);
        }
    }
}
