using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern23_Visitor
{
    internal class Doctor : IVisitor
    {
        public string Name { get; set; }
       
        public Doctor(string name)
        {
            Name = name;
        }
       
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Doctor: {Name} did the health checkup of the child: {kid.KidName}");
        }
    }
}
