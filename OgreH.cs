using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    class OgreH : Character
    {
        public OgreH(string name, string gender, int age) : base(name, gender, 1, age, 500, new Skill(9, 25, 7, 2))
        {
            equipMagic = new Magic("Smelly", 25, 4);
        }
    }
}
