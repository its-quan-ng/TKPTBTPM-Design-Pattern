using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real01_ContinentFactory
{
    class Bear : Omnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Rabbit
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
