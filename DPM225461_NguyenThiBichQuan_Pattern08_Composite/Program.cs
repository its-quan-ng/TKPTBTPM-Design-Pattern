﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Pattern08_Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);
            
            root.Add(new Leaf("Leaf C"));
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);
            root.Display(1);
            Console.ReadKey();
        }
    }
}
