using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld04_GameCharacterPrototype
{
    abstract class CharacterPrototype
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        protected CharacterPrototype(string name, int health, int attackPower)
        {
            this.Name = name;
            this.Health = health;
            this.AttackPower = attackPower;
        }

        public abstract CharacterPrototype Clone();

        // Method
        public abstract void ShowStats();
    }
}
