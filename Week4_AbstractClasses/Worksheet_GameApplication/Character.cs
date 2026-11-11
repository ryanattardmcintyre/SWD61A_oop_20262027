using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClasses.Worksheet_GameApplication
{
    public abstract class Character : IAttack
    {
        protected Character(int mana, int health, int damage)
        {
            Mana = mana;
            Health = health;
            Damage = damage;
        }

        public int Mana { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public abstract void Attack(Character target);
        
    }
}
