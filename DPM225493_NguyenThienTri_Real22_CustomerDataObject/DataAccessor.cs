using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Real22_CustomerDataObject
{
    internal abstract class DataAccessor
    {
        public abstract void Connect();
        public abstract void Select();
        public abstract void Process(int top);
        public abstract void Disconnect();
        
        public void Run(int top)
        {
            Connect();
            Select();
            Process(top);
            Disconnect();
        }
    }
}
