using System;
using ConsoleApp1.Weapon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kod : Character
    {
        public Kod(int level, Skill skill, int maxHealth = 780) : base("Kod", "male",level, 10000, maxHealth, skill)
        {
            equipWeapon = new Sword(20);
            equipMagic = new Magic("wind", 30, 5);
        }
    }
}
