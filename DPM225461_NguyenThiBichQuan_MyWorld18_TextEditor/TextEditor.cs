using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld18_TextEditor
{
    internal class TextEditor
    {
        private string content = "";

        public void Write(string text)
        {
            content += text;
            Console.WriteLine("Current: \"{0}\"", content);
        }

        public void ShowContent()
        {
            Console.WriteLine("Editor content: \"{0}\"", content);
        }

        public TextMemento Save()
        {
            Console.WriteLine("Saving...");
            return new TextMemento(content);
        }

        public void Restore(TextMemento memento)
        {
            content = memento.Content;
            Console.WriteLine("Restored to: \"{0}\"", content);
        }
    }
}
