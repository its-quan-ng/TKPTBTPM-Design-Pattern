using System;
using System.Collections.Generic;

namespace DPM225461_NguyenThiBichQuan_Pattern08_Composite
{
    public abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}
