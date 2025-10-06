using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern20_State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());
            
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        
            Console.ReadKey();
        }
    }
}
