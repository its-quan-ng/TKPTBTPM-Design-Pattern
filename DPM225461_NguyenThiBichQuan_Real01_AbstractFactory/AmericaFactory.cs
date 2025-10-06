
namespace DPM225461_NguyenThiBichQuan_Real01_ContinentFactory
{
    class AmericaFactory : ContinentFactory
    {
        public override Omnivore CreateOmnivore()
        {
            return new Bear();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Rabbit();
        }
    }
}
