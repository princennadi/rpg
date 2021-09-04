using System;
using ConsoleApp1.Weapon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class MegaWolf : Character
    {
        public MegaWolf(int level, Skill skill, int maxHealth = 500) : base("Mega Wolf", "male" ,level, 132, 500, skill)
        {
            equipWeapon = new Sword(20);
            equipMagic = new Magic("wind", 30, 5);
        }
    }
}
