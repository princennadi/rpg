using ConsoleApp1.Scenery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Narrarator
    {
        private Character hero;
        public Character Hero { get { return hero; } }
        

        public void createHero()
        {
            Console.WriteLine("Enter your hero's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Is " + name + " boy or girl? ");
            string gender = Console.ReadLine();
            Console.WriteLine("How old is " + name + "?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What type of hero does " + name + " want to be? ");
            Console.WriteLine("HINT: type in ogre, sorcerer, or elf");
            string heroType = Console.ReadLine();
            if (heroType == "ogre")
            {
                hero = new OgreH(name, gender, age);
            }
            else if (heroType == "sorcerer")
            {
                hero = new SorcererH(name, gender, age);
            }
            else if (heroType == "ogre")
            {
                hero = new ElfH(name, gender, age);
            }
            else if (heroType == "God")
            {
                hero = new GodH("prince", "omnipotent", 9000);
            }

            

        }

        public Character createVillian()
        {
            Console.WriteLine("What level is the villian?");
            int lev = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What do you want the villians speed to be?");
            int dex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in the villians intelligence");
            int smarts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter villians strength");
            int hits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the villians magic");
            int magical = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter villians max health");
            int maxLife = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What type of villian do you want to make?");
            Console.WriteLine("HINT: type in Kod, Mega Wolf, King Piller, or Dark Elf");
            string vil = Console.ReadLine();
            if (vil == "Kod")
            {
                return new Kod(lev, new Skill(smarts, hits, dex, magical), maxLife);
            }
            else if (vil == "Mega Wolf")
            {
                return new MegaWolf(lev, new Skill(smarts, hits, dex, magical), maxLife);
            }
            else if (vil == "King Piller")
            {
                return new KingPiller(lev, new Skill(smarts, hits, dex, magical), maxLife);
            }
            else if (vil == "Dark Elf")
            {
                return new DarkElf(lev, new Skill(smarts, hits, dex, magical), maxLife);
            }
            else
            {
                return null;
            }
        }
        public Scenery.SceneryBase newScene()
        {
            Console.WriteLine("Type in the title");
            string storyName = Console.ReadLine();
            Console.WriteLine("How many quests do you want?");
            Console.WriteLine("type in the intro");
            string start = Console.ReadLine();
            Console.WriteLine("type in the outro");
            string end = Console.ReadLine();
            int questNum = Convert.ToInt32(Console.ReadLine());
            List<Quests.QuestBase> quests = new List<Quests.QuestBase>();
            for (int i = questNum; i < questNum; i++)
            {
                Console.WriteLine("type in the title");
                string nametitle = Console.ReadLine();
                Console.WriteLine("type in the challenge");
                string chal = Console.ReadLine();
                Console.WriteLine("type in the target");
                int targ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("type in the name of the enemy");
                string vil = Console.ReadLine();
                Character enemy;  
                if (vil == "Kod")
                {
                    enemy = new Kod(1, new Skill(5, 6, 7, 8));
                }
                else if (vil == "Mega Wolf")
                {
                    enemy = new Kod(6, new Skill(3, 6, 10, 5));
                }
                else if (vil == "King Piller")
                {
                    enemy = new Kod(4, new Skill(8, 4, 7, 3));
                }
                else if (vil == "Dark Elf")
                {
                    enemy = new Kod(2, new Skill(6, 2, 5, 9));
                }
                else
                {
                    enemy =  null;
                }
                quests.Add(new Quests.QuestBase(nametitle, chal, targ, enemy));
            }
           Stories.StoryBase story = new Stories.StoryBase(storyName, quests, start, end);
            Console.WriteLine("type in the name of the scene");
            string sceneName = Console.ReadLine();
            return new Scenery.Forest(sceneName, story);
        }
    }
} 
