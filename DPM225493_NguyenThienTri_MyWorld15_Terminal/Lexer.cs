using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld15_Terminal
{
    public enum TokenType { Number, Identifier, Plus, Minus, Star, Slash, LParen, RParen, End }

    public struct Token
    {
        public TokenType Type;
        public string Text;
        public Token(TokenType t, string s) { Type = t; Text = s; }
        public override string ToString() { return $"{Type}:{Text}"; }
    }

    public class Lexer
    {
        private readonly string _src;
        private int _pos;

        public Lexer(string src) { _src = src ?? ""; _pos = 0; }

        public Token Next()
        {
            SkipWs();
            if (_pos >= _src.Length) return new Token(TokenType.End, "");

            char c = _src[_pos];

            if (char.IsDigit(c))
            {
                string num = ReadWhile(ch => char.IsDigit(ch));
                return new Token(TokenType.Number, num);
            }
            if (char.IsLetter(c) || c == '_')
            {
                string id = ReadWhile(ch => char.IsLetterOrDigit(ch) || ch == '_');
                return new Token(TokenType.Identifier, id);
            }
            _pos++;
            switch (c)
            {
                case '+': return new Token(TokenType.Plus, "+");
                case '-': return new Token(TokenType.Minus, "-");
                case '*': return new Token(TokenType.Star, "*");
                case '/': return new Token(TokenType.Slash, "/");
                case '(': return new Token(TokenType.LParen, "(");
                case ')': return new Token(TokenType.RParen, ")");
            }

            throw new InvalidOperationException("Unexpected char: " + c);
        }

        private void SkipWs()
        {
            while (_pos < _src.Length && char.IsWhiteSpace(_src[_pos])) _pos++;
        }

        private string ReadWhile(Func<char, bool> pred)
        {
            int start = _pos;
            while (_pos < _src.Length && pred(_src[_pos])) _pos++;
            return _src.Substring(start, _pos - start);
        }
    }
}
