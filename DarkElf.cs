using ConsoleApp1.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class DarkElf: Character
    {
        public DarkElf(int level, Skill skill, int maxHealth = 300) : base("Dark Elf", "female", level, 560, 300, skill)
        {
            equipWeapon = new Sword(20);
            equipMagic = new Magic("earth", 50, 5);
        }
    }
}
