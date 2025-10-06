using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real06_ChemicalCompound
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Compound unknown = new Compound();
            unknown.Display();
            RichCompound water = new RichCompound("Water");
            water.Display();
            RichCompound benzene = new RichCompound("Benzene");
            benzene.Display();
            RichCompound alcohol = new RichCompound("Alcohol");
            alcohol.Display();
            Console.ReadKey();
        }
    }
}
