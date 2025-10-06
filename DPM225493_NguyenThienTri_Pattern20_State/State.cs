using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern20_State
{
    internal abstract class State
    {
        public abstract void Handle(Context context);

    }
}
