using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern23_Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            
            var visitor1 = new Doctor("James");
            
            school.PerformOperation(visitor1);
            Console.WriteLine();
            
            var visitor2 = new Salesman("John");
            
            school.PerformOperation(visitor2);
            Console.Read();
        }
    }
    }
