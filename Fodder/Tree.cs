using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fodder
{
    class Tree:Character
    {
        public Tree(): base ("Tree", "female", 1, 10, 150, new Skill(0,0,0,0))
        {
            equipMagic = null;
            equipWeapon = null;
        }
    }
}
