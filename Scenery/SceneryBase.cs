using ConsoleApp1.Stories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Scenery
{
    public abstract class SceneryBase
    {
        private string name;
        private List<Weapons> availableWeapons;
        private StoryBase story;
        private List<Weapons> weapons;
        public string Name  { get { return name; } }
        public List<Weapons> AvailableWeapons { get { return availableWeapons; } }
        public List<Weapons> Weapons2 { get { return weapons; } }
        public StoryBase Story { get { return story; } }


        public SceneryBase (string name, List<Weapons> availableWeapons, StoryBase story, List<Weapons> weapons)
        {
            this.name = name;
            this.availableWeapons = availableWeapons;
            this.story = story;
            this.weapons = weapons;
        }
    }
}
