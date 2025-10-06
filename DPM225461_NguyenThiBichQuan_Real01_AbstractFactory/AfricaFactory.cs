using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real01_ContinentFactory
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Impala();
        }

        public override Omnivore CreateOmnivore()
        {
            return new Baboon();
        }
    }
}
