using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld08_FileSystem
{
    internal class Folder : FileSystemItem
    {
        private List<FileSystemItem> items = new List<FileSystemItem>();

        public Folder(string name) : base(name)
        {
        }

        public override void Add(FileSystemItem item)
        {
            items.Add(item);
        }

        public override void Remove(FileSystemItem item)
        {
            items.Remove(item);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name + " (Folder)");
            foreach (FileSystemItem item in items)
            {
                item.Display(depth + 2);
            }
        }
    }
}
