using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld12_ImageLoader
{
    internal class HighResolutionImage : IImage
    {
        private string filename;

        public HighResolutionImage(string filename)
        {
            this.filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading high-resolution image: {0}", filename);
            Console.WriteLine("Reading from disk...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Image loaded successfully!\n");
        }

        public void Display()
        {
            Console.WriteLine("Displaying image: {0}\n", filename);
        }
    }
}
