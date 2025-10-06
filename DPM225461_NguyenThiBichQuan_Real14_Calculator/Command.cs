using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real14_Calculator
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
