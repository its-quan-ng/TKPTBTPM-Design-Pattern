using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_MyWorld11_Badges
{
    internal class BadgeFactory
    {
        private readonly Dictionary<string, Badge> _cache = new Dictionary<string, Badge>();

        public int CacheCount => _cache.Count;

        public Badge GetBadge(string status)
        {
            var key = (status ?? "").ToUpperInvariant();

            if (_cache.TryGetValue(key, out var existing))
            {
                //Console.WriteLine($"Reusing badge '{key}'");
                return existing;
            }

            var created = new StatusBadge(key);
            _cache[key] = created;
            //Console.WriteLine($"Created new badge '{key}'");
            return created;
        }
    }
}
