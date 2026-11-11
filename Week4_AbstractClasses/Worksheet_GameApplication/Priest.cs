using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractClasses.Worksheet_GameApplication
{
    public class Priest : Character, IHeal
    {
        public Priest() : base(200, 125, 100) { }
        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
            this.Health += this.Damage/10;// Convert.ToInt32( Math.Round(0.1 * this.Damage));
        }
        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }
    }
}
