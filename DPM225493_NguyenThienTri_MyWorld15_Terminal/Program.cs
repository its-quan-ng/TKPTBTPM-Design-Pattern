using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld15_Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Context: giá trị biến (có thể lấy từ DB/config)
            var context = new Context(new Dictionary<string, int>
            {
                { "a", 10 },
                { "b", 3  },
                { "price", 499000 },
                { "qty", 2 }
            });

            // Một số biểu thức demo
            var formulas = new[]
            {
                "1 + 2 * 3",                 // 7
                "(1 + 2) * 3",               // 9
                "a + b * 4",                 // 10 + 3*4 = 22
                "price * qty + 30000",       // 499000*2 + 30000
                "price * (qty - 1) / b"      // 499000*(2-1)/3
            };

            Console.WriteLine("=== Interpreter: Mini Calculator ===");
            foreach (var f in formulas)
            {
                try
                {
                    var expr = new Parser(f).ParseExpression(); // build AST
                    int value = expr.Interpret(context);         // evaluate
                    Console.WriteLine($"{f} = {value:n0}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{f} -> ERROR: {ex.Message}");
                }
            }

            Console.WriteLine("=== DONE ===");
            Console.ReadLine(); // giữ console mở
        }
    }
    
}
