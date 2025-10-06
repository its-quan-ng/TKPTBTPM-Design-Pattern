using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Real23_ComputerPartsStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var computerParts = new List<IComputerPart>
            {
                new Mouse(),
                new Keyboard(),
                new Monitor()
            };
            var priceVisitor = new PriceVisitor();
            var nameVisitor = new NameVisitor();
            foreach (var part in computerParts)
            {
                part.Accept(priceVisitor);
                part.Accept(nameVisitor);
            }
            Console.WriteLine($"Total Price: {priceVisitor.TotalPrice}");
            Console.WriteLine($"Part Names: {string.Join(", ", nameVisitor.Names)}");
            Console.ReadKey();
        }
    }
    }
