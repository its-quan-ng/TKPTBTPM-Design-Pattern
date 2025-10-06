using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThiEnTri_Real21_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");
            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
            // Wait for user
            Console.ReadKey();
        }
    }
}
