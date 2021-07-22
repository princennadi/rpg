using ConsoleApp1.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenery
{
    class Forest:SceneryBase
    {
        public Forest(string name, Stories.StoryBase story): base (name, new List<Weapons>() {new Stick(), new Stone() }, story, new List<Weapons>() { new Sword(9), new Sword(14) })
        {

        }
    }
}
