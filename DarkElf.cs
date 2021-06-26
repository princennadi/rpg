using ConsoleApp1.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DarkElf: Character
    {
        public DarkElf(int level) : base("Dark Elf", level, 560, 300, new Skill(15, 4, 2, 7))
        {
            equipWeapon = new Sword(20);
        }
    }
}
