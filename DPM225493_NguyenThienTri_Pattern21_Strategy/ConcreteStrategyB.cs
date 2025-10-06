using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern21_Strategy
{
    internal class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
                "Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}
