using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld08_FileSystem
{
    internal class File : FileSystemItem
    {
        private int size; // KB

        public File(string name, int size) : base(name)
        {
            this.size = size;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name + " (" + size + " KB)");
        }

        public override void Add(FileSystemItem item)
        {
            Console.WriteLine("Cannot add to a file!");
        }

        public override void Remove(FileSystemItem item)
        {
            Console.WriteLine("Cannot remove from a file!");
        }
    }
}
