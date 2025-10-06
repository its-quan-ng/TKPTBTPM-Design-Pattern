using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Real23_ComputerPartsStore
{
    internal class NameVisitor : IComputerPartVisitor
    {
        private List<string> names = new List<string>();
        public IEnumerable<string> Names => names;
        public void Visit(Mouse mouse)
        {
            names.Add("Mouse");
        }
        public void Visit(Keyboard keyboard)
        {
            names.Add("Keyboard");
        }
        public void Visit(Monitor monitor)
        {
            names.Add("Monitor");
        }
    }
}
