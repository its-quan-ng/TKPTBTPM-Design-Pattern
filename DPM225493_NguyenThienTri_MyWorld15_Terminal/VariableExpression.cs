using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld15_Terminal
{
    internal class VariableExpression : AbstractExpression
    {
        private readonly string _name;
        public VariableExpression(string name) { _name = name; }

        public override int Interpret(Context context)
        {
            return context.GetValue(_name);
        }
    }
}
