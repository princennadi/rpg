using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SorcererH : Character
    {
        public SorcererH(string name, string gender, int age) : base(name, gender, 1, age, 500, new Skill(5, 10, 7, 18))
        {
            equipMagic = new Magic("Dark Magic", 65, 5);
        }
    }
}
