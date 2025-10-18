using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DPM225493_NguyenThienTri_MyWorld15_Terminal.Lexer;

namespace DPM225493_NguyenThienTri_MyWorld15_Terminal
{
    internal class Parser
    {
        private readonly Lexer _lx;
        private Token _look;

        public Parser(string text)
        {
            _lx = new Lexer(text);
            _look = _lx.Next();
        }

        public AbstractExpression ParseExpression()
        {
            // Expr := Term { (+|-) Term }*
            var left = ParseTerm();
            while (_look.Type == TokenType.Plus || _look.Type == TokenType.Minus)
            {
                var op = _look.Type;
                Consume();
                var right = ParseTerm();
                left = (op == TokenType.Plus)
                    ? (AbstractExpression)new AddExpression(left, right)
                    : new SubExpression(left, right);
            }
            Expect(TokenType.End);
            return left;
        }

        // Term := Factor { (*|/) Factor }*
        private AbstractExpression ParseTerm()
        {
            var left = ParseFactor();
            while (_look.Type == TokenType.Star || _look.Type == TokenType.Slash)
            {
                var op = _look.Type;
                Consume();
                var right = ParseFactor();
                left = (op == TokenType.Star)
                    ? (AbstractExpression)new MulExpression(left, right)
                    : new DivExpression(left, right);
            }
            return left;
        }

        // Factor := Number | Identifier | '(' Expr ')'
        private AbstractExpression ParseFactor()
        {
            if (_look.Type == TokenType.Number)
            {
                int val = int.Parse(_look.Text);
                Consume();
                return new LiteralExpression(val);
            }
            if (_look.Type == TokenType.Identifier)
            {
                string name = _look.Text;
                Consume();
                return new VariableExpression(name);
            }
            if (_look.Type == TokenType.LParen)
            {
                Consume(); // '('
                var e = ParseTermOrExpr(); // cho phép biểu thức đầy đủ trong ngoặc
                Expect(TokenType.RParen);
                return e;
            }
            throw new InvalidOperationException("Unexpected token: " + _look);
        }

        // Cho phép biểu thức cộng/trừ bên trong ngoặc
        private AbstractExpression ParseTermOrExpr()
        {
            var save = _look;
            var e = ParseExpressionCore();
            return e;
        }

        // Parse lại từ đầu quy tắc Expr nhưng không Expect(End)
        private AbstractExpression ParseExpressionCore()
        {
            var left = ParseTerm();
            while (_look.Type == TokenType.Plus || _look.Type == TokenType.Minus)
            {
                var op = _look.Type;
                Consume();
                var right = ParseTerm();
                left = (op == TokenType.Plus)
                    ? (AbstractExpression)new AddExpression(left, right)
                    : new SubExpression(left, right);
            }
            return left;
        }

        private void Expect(TokenType t)
        {
            if (_look.Type != t)
                throw new InvalidOperationException($"Expected {t} but got {_look}");
            Consume();
        }

        private void Consume() { _look = _lx.Next(); }
    }
}
