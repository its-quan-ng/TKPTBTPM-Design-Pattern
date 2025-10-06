using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Pattern08_Composite
{
    public class Composite : Component
    {
        List<Component> children = new List<Component>();
        
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
           Console.WriteLine(new String('-', depth) + name);
          foreach (Component component in children)
              {
                component.Display(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
    }
}
