using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld15_Terminal
{
    internal class SubExpression : AbstractExpression
    {
        private readonly AbstractExpression _left;
        private readonly AbstractExpression _right;

        public SubExpression(AbstractExpression left, AbstractExpression right)
        {
            _left = left; _right = right;
        }

        public override int Interpret(Context context)
        {
            return _left.Interpret(context) - _right.Interpret(context);
        }
    }
}
