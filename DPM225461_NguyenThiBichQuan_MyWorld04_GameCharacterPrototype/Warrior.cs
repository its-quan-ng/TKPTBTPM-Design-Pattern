using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld04_GameCharacterPrototype
{
    class Warrior : CharacterPrototype
    {
        public int Defense { get; set; }
        public string Weapon { get; set; }
        public Warrior(string name, int health, int attackPower, int defense, string weapon) : base(name, health, attackPower)
        {
            this.Defense = defense;
            this.Weapon = weapon;
        }

        public override CharacterPrototype Clone()
        {
            Console.WriteLine("Cloning Warrior: {0}", Name);
            return this.MemberwiseClone() as CharacterPrototype;
        }

        public override void ShowStats()
        {
            Console.WriteLine("\n--- WARRIOR ---");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Health: {0} HP", Health);
            Console.WriteLine("Attack: {0}", AttackPower);
            Console.WriteLine("Defense: {0}", Defense);
            Console.WriteLine("Weapon: {0}", Weapon);
        }


    }
}
