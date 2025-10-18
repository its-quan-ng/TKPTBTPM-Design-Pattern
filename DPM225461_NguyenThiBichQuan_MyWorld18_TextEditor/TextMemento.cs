using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld18_TextEditor
{
    internal class TextMemento
    {
        private string content;

        public TextMemento(string content)
        {
            this.content = content;
        }

        public string Content
        {
            get { return content; }
        }
    }
}
