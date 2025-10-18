using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld12_ImageLoader
{
    internal class ImageProxy : IImage
    {
        private string filename;
        private HighResolutionImage realImage;

        public ImageProxy(string filename)
        {
            this.filename = filename;
            Console.WriteLine("ImageProxy created for: {0}", filename);
            Console.WriteLine("(Image not loaded yet - Lazy Loading)\n");
        }

        public void Display()
        {
            if (realImage == null)
            {
                Console.WriteLine("--- First time access ---");
                realImage = new HighResolutionImage(filename);
            }
            else
            {
                Console.WriteLine("--- Using cached image (Fast!) ---\n");
            }

            realImage.Display();
        }
    }
}
