using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Weapon
{
   public class Stick : Weapons
    {
        public Stick(int damage = 3) : base("Sword", 0.80, damage)
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
