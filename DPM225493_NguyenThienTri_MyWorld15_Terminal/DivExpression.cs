using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld15_Terminal
{
    internal class DivExpression : AbstractExpression
    {
        private readonly AbstractExpression _left;
        private readonly AbstractExpression _right;

        public DivExpression(AbstractExpression left, AbstractExpression right)
        {
            _left = left; _right = right;
        }

        public override int Interpret(Context context)
        {
            int r = _right.Interpret(context);
            if (r == 0) throw new DivideByZeroException("Division by zero.");
            return _left.Interpret(context) / r; // chia nguyên
        }
    }
}
