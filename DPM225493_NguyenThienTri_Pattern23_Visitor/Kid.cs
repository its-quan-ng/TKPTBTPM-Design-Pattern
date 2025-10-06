using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern23_Visitor
{
    internal class Kid : IElement
    {
        public string KidName { get; set; }
      
        public Kid(string name)
        {
            KidName = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
