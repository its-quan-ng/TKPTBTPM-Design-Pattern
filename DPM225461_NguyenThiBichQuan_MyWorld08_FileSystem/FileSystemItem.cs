using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld08_FileSystem
{
    abstract class FileSystemItem
    {
        protected string name;

        public FileSystemItem(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
        public abstract void Add(FileSystemItem item);
        public abstract void Remove(FileSystemItem item);
    }
}
