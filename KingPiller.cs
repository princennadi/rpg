using System;
using ConsoleApp1.Weapon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class KingPiller : Character
    {
        public KingPiller(int level, Skill skill, int maxHealth = 550) : base("King Piller", "male" ,level, 1000, 550, skill)
        {
            equipWeapon = new Sword(20);
            equipMagic = new Magic("wind", 30, 5);
        }
    }
}
