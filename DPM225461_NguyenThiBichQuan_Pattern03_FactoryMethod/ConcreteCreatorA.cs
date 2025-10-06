
namespace DPM225461_NguyenThiBichQuan_Pattern03_FactoryMethod
{
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
