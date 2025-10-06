using System;
using System.Collections.Generic;

namespace DPM225461_NguyenThiBichQuan_Real08_DrawingElement
{
    public class CompositeElement : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();

        public CompositeElement(string name) : base(name)
        {
        }
        public override void Add(DrawingElement d)
        {
           elements.Add(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + ' ' +  name);
            foreach (var element in elements)
            {
                element.Display(indent + 2);
            }
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
    }
}
