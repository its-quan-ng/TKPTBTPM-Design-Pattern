using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld04_GameCharacterPrototype
{
    class CharacterManager
    {
        private Dictionary<string, CharacterPrototype> characters = new Dictionary<string, CharacterPrototype>();
        public CharacterPrototype this[string key]
        {
            get { return characters[key]; }
            set { characters.Add(key, value); }
        }

        public void ShowAllTemplates()
        {
            Console.WriteLine("\n=== CHARACTER TEMPLATES ===");
            foreach (var key in characters.Keys)
            {
                Console.WriteLine("- {0}", key);
            }
        }
    }

}
