using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld14_RemoteControl
{
    internal class RemoteControl
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            Console.Write("Remote: Button pressed → ");
            command.Execute();
        }

        public void PressUndo()
        {
            Console.Write("Remote: Undo pressed → ");
            command.Undo();
        }
    }
}
