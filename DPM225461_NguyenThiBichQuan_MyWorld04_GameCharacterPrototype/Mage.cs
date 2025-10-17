using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld04_GameCharacterPrototype
{
    class Mage : CharacterPrototype
    {
        public int Mana { get; set; }
        public int MagicPower { get; set; }
        public string Spell { get; set; }
        public Mage(string name, int health, int attackPower, int mana, int magicPower, string spell) : base(name, health, attackPower)
        {
            this.Mana = mana;
            this.MagicPower = magicPower;
            this.Spell = spell;
        }

        public override CharacterPrototype Clone()
        {
            Console.WriteLine("Cloning Mage: {0}", Name);
            return this.MemberwiseClone() as CharacterPrototype;
        }

        public override void ShowStats()
        {
            Console.WriteLine("\n--- MAGE ---");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Health: {0} HP", Health);
            Console.WriteLine("Attack: {0}", AttackPower);
            Console.WriteLine("Mana: {0} MP", Mana);
            Console.WriteLine("Magic Power: {0}", MagicPower);
            Console.WriteLine("Spell: {0}", Spell);
        }
    }
}
