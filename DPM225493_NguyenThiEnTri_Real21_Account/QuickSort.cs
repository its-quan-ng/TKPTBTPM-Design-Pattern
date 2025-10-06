using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThiEnTri_Real21_Account
{
    internal class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();  
            Console.WriteLine("QuickSorted list ");
        }
    }
}
