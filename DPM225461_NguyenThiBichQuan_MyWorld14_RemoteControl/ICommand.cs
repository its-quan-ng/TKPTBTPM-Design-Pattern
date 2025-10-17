using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld14_RemoteControl
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
