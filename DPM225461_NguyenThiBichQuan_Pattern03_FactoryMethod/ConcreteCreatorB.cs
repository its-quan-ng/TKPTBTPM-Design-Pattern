
namespace DPM225461_NguyenThiBichQuan_Pattern03_FactoryMethod
{
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
