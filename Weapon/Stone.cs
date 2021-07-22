using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Weapon
{
   public class Stone : Weapons
    {
        public Stone(int damage = 5) : base("Stone", 0.80, damage)
        {

        }
        public override int passiveDamage()
        {
            return 1;
        }

        public override int activeDamage()
        {
            if (base.activeDamage() == 1)
            {
                return 2 * getDamage;
            }
            else
            {
                return 2 * getDamage;
            }
        }
    }
}
