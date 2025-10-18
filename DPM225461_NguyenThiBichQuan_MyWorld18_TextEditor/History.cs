using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld18_TextEditor
{
    internal class History
    {
        private Stack<TextMemento> mementos = new Stack<TextMemento>();

        public void Push(TextMemento memento)
        {
            mementos.Push(memento);
        }

        public TextMemento Pop()
        {
            if (mementos.Count > 0)
            {
                return mementos.Pop();
            }
            Console.WriteLine("No more undo history!");
            return null;
        }
    }
}
