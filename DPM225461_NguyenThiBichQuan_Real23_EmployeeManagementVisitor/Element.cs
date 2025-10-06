using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real23_EmployeeManagementVisitor
{
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
