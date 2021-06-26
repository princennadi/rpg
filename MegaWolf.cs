using System;
using ConsoleApp1.Weapon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MegaWolf : Character
    {
        public MegaWolf(int level) : base("Mega Wolf", level, 132, 500, new Skill(4, 20, 9, 2))
        {
            equipWeapon = new Sword(20);
        }
    }
}
