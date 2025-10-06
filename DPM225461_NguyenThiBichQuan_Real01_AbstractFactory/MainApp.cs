using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real01_ContinentFactory
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            ContinentFactory america = new AmericaFactory();
            AnimalWorld world = new AnimalWorld(america);
            world.Run();

            ContinentFactory africa = new AfricaFactory();
            world = new AnimalWorld(africa);
            world.Run();

            Console.ReadKey();
        }
    }
}
