using System;

namespace DPM225461_NguyenThiBichQuan_Real08_DrawingElement
{
    public class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
           Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + ' ' + name);
        }

        public override void Remove(DrawingElement d)
        {
            Console.WriteLine("Cannot remove from a PrimitiveElement");
        }
    }
}
