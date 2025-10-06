using System;

namespace DPM225461_NguyenThiBichQuan_Pattern03_FactoryMethod
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                 product.GetType().Name);
            }
            Console.ReadKey();
        }
    }
}
