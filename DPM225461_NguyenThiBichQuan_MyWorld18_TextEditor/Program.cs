using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld18_TextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            History history = new History();

            editor.Write("Hello");
            history.Push(editor.Save());

            editor.Write(" World");
            history.Push(editor.Save());

            editor.Write("!!!");

            Console.WriteLine("\n--- Undo 1 ---");
            editor.Restore(history.Pop());

            Console.WriteLine("\n--- Undo 2 ---");
            editor.Restore(history.Pop());

            Console.ReadKey();
        }
    }
}
