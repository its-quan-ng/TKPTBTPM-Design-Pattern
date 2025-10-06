using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real11_Character
{
    public class CharacterFactory
    {
        private Dictionary<char, Character> characters = new Dictionary<char, Character>();
            public CharacterFactory()
            {
                characters.Add('A', new CharacterA());
                characters.Add('B', new CharacterB());
                characters.Add('Z', new CharacterZ());
            }
    
            public Character GetCharacter(char key)
            {
                Character character = null;
                if (characters.ContainsKey(key))
                {
                    return characters[key];
                }
                else
                {
                switch (key)
                {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                    //...
                    case 'Z': character = new CharacterZ(); break;
                }
                characters.Add(key, character);
                return character;
                }
            }
    }
}
