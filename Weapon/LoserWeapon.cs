using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Weapon
{
    class LoserWeapon: Weapons
    {
        public LoserWeapon(int damage = -5) : base("L's all around", 2, damage)
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
