using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real13_Approver
{
    public class Program
    {
        public static void Main(string[] args)
        {
  
            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();
            larry.SetSuccessor(sam);
            sam.SetSuccessor(tammy);
          
            Purchase p = new Purchase(2034, 350.00, "Supplies");
            larry.ProcessRequest(p);
            p = new Purchase(2035, 32590.10, "Project X");
            larry.ProcessRequest(p);
            p = new Purchase(2036, 122100.00, "Project Y");
            larry.ProcessRequest(p);
         
            Console.ReadKey();
        }
    }
}
