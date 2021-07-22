using ConsoleApp1.Scenery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum AttackActions
    {
        Active,
        Passive,
        Miss,
        SelfDamage,
    }
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
            int questNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("type in the intro");
            string start = Console.ReadLine();
            Console.WriteLine("type in the outro");
            string end = Console.ReadLine();       
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
        static Character Battle(IEnumerable<Character> fighter)
        {
            Character winner = null;
            IEnumerable<Character> combatant = fighter;
            Random rand = new Random();
            if (combatant.Count() < 2)
            {
                return null;
            }
            else
            {
                while (true)
                {

                    Character temporary = Dice(combatant.ToArray());
                    Console.WriteLine(temporary.ToString() + " is attacking");
                    string command = "";
                    Console.WriteLine("What attack do you want to do?" + " HINT: enter magic or physical");
                    command = Console.ReadLine();
                    AttackActions actions;
                    AttackType type = AttackType.physical;
                    if (command == "magic")
                    {
                        actions = Dice(rand);
                        type = AttackType.magic;
                    }
                    else if (command == "physical")
                    {
                        actions = Dice(rand);
                        type = AttackType.physical;
                    }
                    else
                    {
                        combatant = combatant.Where(x => x != temporary);
                        Console.WriteLine(temporary.ToString() + " ran away.");
                        continue;
                    }


                    int AttackerIndex = combatant.ToList().FindIndex(temp => temporary == temp);
                    int damage = combatant.ToList()[AttackerIndex].Attack(AttackAction.passive, type);
                    if (actions == AttackActions.Active)
                    {
                        damage = combatant.ToList()[AttackerIndex].Attack(AttackAction.active, type);
                    }
                    else if (actions == AttackActions.Passive)
                    {
                        damage = combatant.ToList()[AttackerIndex].Attack(AttackAction.passive, type);
                    }
                    else if (actions == AttackActions.SelfDamage)
                    {
                        damage = combatant.ToList()[AttackerIndex].Attack(AttackAction.passive, type);
                        combatant.ToList()[AttackerIndex].Damage(damage);
                        Console.WriteLine(combatant.ToList()[AttackerIndex].ToString() + "Self damaged by" + damage + "hit points");
                        continue;
                    }
                    else if (actions == AttackActions.Miss)
                    {
                        Console.WriteLine(combatant.ToList()[AttackerIndex].ToString() + " missed.");
                        combatant.ToList()[AttackerIndex].MissAttack();
                        continue;
                    }

                    Console.WriteLine(temporary.ToString() + " has dealt " + +damage + " damage");
                    for (int i = 0; i < combatant.Count(); i++)
                    {

                        if (i != AttackerIndex)
                        {
                            if (combatant.ToList()[i].getHealth > 0)
                            {
                                combatant.ToList()[i].Damage(damage);
                                Console.WriteLine(combatant.ToList()[i].ToString() + " recieved " + damage + " damage from " + temporary.ToString());
                            }

                        }




                    }


                    int count = combatant.Count(p => p.getHealth > 0);

                    if (count == 1)
                    {
                        winner = combatant.First(p => p.getHealth > 0);
                        break;
                    }
                    else if (count == 0)
                    {
                        break;
                    }


                }
                return winner;

            }
        }

        static Character Dice(params Character[] a)
        {

            List<Character> dexx = new List<Character>(a);
            dexx.Sort(DexterityComparer);
            return dexx.Last();
        }

        public static AttackActions Dice(Random rand)
        {
            int randomNumber = rand.Next(1, 4);

            if (randomNumber == 1)
            {
                return AttackActions.Active;
            }
            else if (randomNumber == 2)
            {
                return AttackActions.Passive;
            }
            else if (randomNumber == 3)
            {
                return AttackActions.Miss;
            }
            else
            {
                return AttackActions.SelfDamage;
            }
        }
        static int DexterityComparer(Character aa, Character ab)
        {
            if (aa.getSkill.getDexterity > ab.getSkill.getDexterity)
            {
                return 1;
            }
            else if (aa.getSkill.getDexterity < ab.getSkill.getDexterity)
            {
                return -1;
            }
            else
            {
                return 0;
            }


        }
    }
}

