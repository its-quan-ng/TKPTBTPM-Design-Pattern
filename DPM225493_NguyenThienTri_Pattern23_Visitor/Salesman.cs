using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern23_Visitor
{
    internal class Salesman : IVisitor
    {
        public string Name { get; set; }
        
        public Salesman(string name)
        {
            Name = name;
        }
        
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Salesman: {Name} give a school bag to the child: {kid.KidName}");
        }
    }
}
