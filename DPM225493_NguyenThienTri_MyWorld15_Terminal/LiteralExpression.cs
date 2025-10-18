using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld15_Terminal
{
    internal class LiteralExpression : AbstractExpression
    {
        private readonly int _value;
        public LiteralExpression(int value) { _value = value; }

        public override int Interpret(Context context) => _value;
    }
}
