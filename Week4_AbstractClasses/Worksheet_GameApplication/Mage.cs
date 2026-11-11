using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClasses.Worksheet_GameApplication
{
    /*
     * ial health of 125, initial mana of 200 and damage of 100.
     */
    public class Mage: Character
    {
        public Mage(): 
            base(300, 100, 75 )
        {
        }

        public override void Attack(Character target)
        {
            // he uses 100 mana and deals twice his default damage
            this.Mana -= 100;
            target.Health -= (Damage * 2);
        }
    }
}
