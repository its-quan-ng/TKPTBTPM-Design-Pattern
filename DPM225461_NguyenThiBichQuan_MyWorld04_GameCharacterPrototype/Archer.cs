using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld04_GameCharacterPrototype
{
    class Archer : CharacterPrototype
    {
        public int Range { get; set; }
        public string ArrowType { get; set; }
        public Archer(string name, int health, int attackPower, int range, string arrowType) : base(name, health, attackPower)
        {
            this.Range = range;
            this.ArrowType = arrowType;
        }

        public override CharacterPrototype Clone()
        {
            Console.WriteLine("Cloning Archer: {0}", Name);
            return this.MemberwiseClone() as CharacterPrototype;
        }

        public override void ShowStats()
        {
            Console.WriteLine("\n--- ARCHER ---");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Health: {0} HP", Health);
            Console.WriteLine("Attack: {0}", AttackPower);
            Console.WriteLine("Range: {0} meters", Range);
            Console.WriteLine("Arrow Type: {0}", ArrowType);
        }
    }
}
