using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld04_GameCharacterPrototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            CharacterManager manager = new CharacterManager();
            manager["warrior"] = new Warrior("Template Warrior", 1200, 150, 100, "Iron Sword");
            manager["mage"] = new Mage("Template Mage", 700, 60, 600, 250, "Fireball");
            manager["archer"] = new Archer("Template Archer", 850, 120, 70, "Fire Arrow");

            Console.WriteLine("=== CLONING CHARACTERS ===\n");

            Warrior warrior1 = (Warrior)manager["warrior"].Clone();
            warrior1.Name = "Orc Warrior";
            warrior1.ShowStats();

            Warrior warrior2 = (Warrior)manager["warrior"].Clone();
            warrior2.Name = "Elite Warrior";
            warrior2.Health = 1500;
            warrior2.ShowStats();

            Mage mage1 = (Mage)manager["mage"].Clone();
            mage1.Name = "Dark Mage";
            mage1.Spell = "Lightning Storm";
            mage1.ShowStats();

            Mage mage2 = (Mage)manager["mage"].Clone();
            mage2.Name = "Ice Mage";
            mage2.Spell = "Blizzard";
            mage2.ShowStats();

            Archer archer1 = (Archer)manager["archer"].Clone();
            archer1.Name = "Sniper";
            archer1.Range = 100;
            archer1.ShowStats();

            Console.ReadKey();
        }
    }
}
