using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld15_Terminal
{
    internal class Context
    {
        private readonly IDictionary<string, int> _vars;

        public Context(IDictionary<string, int> variables)
        {
            _vars = variables ?? new Dictionary<string, int>();
        }

        public int GetValue(string name)
        {
            if (!_vars.ContainsKey(name))
                throw new InvalidOperationException($"Unknown variable '{name}'.");
            return _vars[name];
        }
    }
}
