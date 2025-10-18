using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld12_ImageLoader
{
    public class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ImageProxy("vacation_4K.jpg");

            Console.WriteLine("\n--- Displaying image1 (1st time - slow) ---");
            image.Display();

            Console.WriteLine("\n--- Displaying image1 (2nd time - fast) ---");
            image.Display();

            Console.WriteLine("\n=== END ===");
            Console.ReadKey();
        }
    }
}
