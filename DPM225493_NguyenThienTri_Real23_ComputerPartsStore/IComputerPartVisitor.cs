using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Real23_ComputerPartsStore
{
    interface IComputerPartVisitor
    {
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Monitor monitor);
    }
}
