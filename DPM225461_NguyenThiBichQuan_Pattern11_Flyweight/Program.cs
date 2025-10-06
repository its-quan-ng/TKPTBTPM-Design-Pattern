using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Pattern11_Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int extrinsicState = 22;

            FlyweightFactory factory = new FlyweightFactory();
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicState);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicState);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicState);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicState);
            Console.ReadKey();

        }
    }
}
