using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClasses.Worksheet_GameApplication
{
    /*
     *  he uses 100 mana and deals twice his default damage
     */
    public class Warrior:Character
    {
        public Warrior():base(0, 300, 120)
        { }


        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
        }
    }
}
