using ConsoleApp1.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    class ElfH : Character
    {
        public ElfH(string name, string gender, int age) : base(name, gender, 1, age, 500, new Skill(4, 20, 9, 5))
        {
            equipMagic = new Magic("Earth", 30, 5);
        }
    }
}
