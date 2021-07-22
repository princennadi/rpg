using ConsoleApp1.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GodH:Character
    {
        public GodH(string name, string gender, int age) : base(name, gender, 1, age, 500, new Skill(100, 100, 100, 100))
        {
            equipWeapon = new Excalibur(500);
            equipMagic = new Magic("InstaKill", 1000, 0);
        }
    }
}
