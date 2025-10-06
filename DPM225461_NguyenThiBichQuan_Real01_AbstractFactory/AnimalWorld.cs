using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real01_ContinentFactory
{
    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Omnivore _omnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _omnivore = factory.CreateOmnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void Run()
        {
            _omnivore.Eat(_herbivore);
        }
    }
}
