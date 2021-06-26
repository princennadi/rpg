using System;
using ConsoleApp1.Weapon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class KingPiller : Character
    {
        public KingPiller(int level) : base("King Piller", level, 1000, 550, new Skill(8, 6, 25, 10))
        {
            equipWeapon = new Sword(20);
        }
    }
}
