using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Real22_CustomerDataObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccessor categories = new Categories();
            categories.Run(5);
            DataAccessor products = new Products();
            products.Run(3);
            
            Console.ReadKey();
        }
    }
    }
