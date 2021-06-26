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
        public Kod(int level) : base("Kod", level, 10000, 780, new Skill(11, 30, 15, 12))
        {
            equipWeapon = new Sword(20);
        }
    }
}
