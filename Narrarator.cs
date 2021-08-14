using ConsoleApp1.Fodder;
using ConsoleApp1.Scenery;
using ConsoleApp1.Weapon;
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
        private IList<Character> enemy;
        private List<Weapons> weaponBag = new List<Weapons>();
        public Character Hero
        {
            get { return hero; }
            set { hero = value; }
        }
        public SceneryBase Scenery { get; set; } = null;
        public Quests.QuestBase Quest { get; set; } = null;
        public bool StoryEnded {get; set;} = true;
        public bool QuestEnded { get; set; } = true;
        public int Progress { get; set; } = 0;

        public Character createHero(string name, string gender, int age, string heroType)
        {
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
            return hero;
        }

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
        public Weapons createWeapon(string type, int? damage)
        {
            if (type == "Sword")
            {
                if (damage.HasValue)
                {
                    return new Sword(damage.Value);
                }
                else
                {
                    return new Sword();
                }
            }
            else if (type == "Bow")
            {
                if (damage.HasValue)
                {
                    return new Bow(damage.Value);
                }
                else
                {
                    return new Bow();
                }
            }
            else if (type == "Stick")
            {
                if (damage.HasValue)
                {
                    return new Stick(damage.Value);
                }
                else
                {
                    return new Stick();
                }
            }
            else if (type == "Stone")
            {
                if (damage.HasValue)
                {
                    return new Stone(damage.Value);
                }
                else
                {
                    return new Stone();
                }
            }
            else if (type == "cheaters win")
            {
                if (damage.HasValue)
                {
                    return new Excalibur(damage.Value);
                }
                else
                {
                    return new Excalibur();
                }
            }
            else
            {
                if (damage.HasValue)
                {
                    return new LoserWeapon(damage.Value);
                }
                else
                {
                    return new LoserWeapon();
                }
            }

        }

        public Character createVillian(int lev, int dex, int smarts, int hits, int magical, int maxLife, string vil)
        {
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

        public Character createVillian(string vil)
        {
            if (vil == "Kod")
            {
                return new Kod(1, new Skill(2, 8, 670, 4), 240);
            }
            else if (vil == "Mega Wolf")
            {
                return new MegaWolf(1, new Skill(3, 3, 200, 4), 403);
            }
            else if (vil == "King Piller")
            {
                return new KingPiller(1, new Skill(2, 4, 101, 6), 250);
            }
            else if (vil == "Dark Elf")
            {
                return new DarkElf(1, new Skill(5, 6, 109, 5), 100);
            }
            else
            {
                return null;
            }
        }
        public Quests.QuestBase newQuest(string title, string challenge, int targets, Character enemy = null)
        {
            return new Quests.QuestBase(title, challenge, targets, enemy);
        }

        public Stories.StoryBase newStory(string name, List<Quests.QuestBase> quests, string introduction, string conclusion)
        {
            return new Stories.StoryBase(name, quests, introduction, conclusion);
        }

        public Scenery.SceneryBase newScene(string scenename, Stories.StoryBase story, string sceneType)
        {
            if (sceneType == "forest")
            {
                return new Scenery.Forest(scenename, story);
            }
            else
            {
                return null;
            }
        }

        public string GoToScene(SceneryBase scenery)
        {
            Scenery = scenery;
            StoryEnded = false;
            return scenery.Story.Introduction;
        }

        public string NextQuest()
        {
           
            if (Scenery != null)
            {
                Quests.QuestBase current = Scenery.Story.Challenge.FirstOrDefault(x => x != Quest);

                if (current != null)
                {
                    Quest = current;
                    QuestEnded = false;
                    Progress = 0;
                    return Quest.Title + " : " + Quest.Challenge;
                }
                return null;
            }
            else
            {
                throw new ArgumentException();
            }
            
           
        }
        public void UpdateQuest(int progress)
        {
            Progress = progress;
            if (Progress >= Quest.Target)
            {
                QuestEnded = true;
                
            }
        }
        public Weapons GetSceneWeapon()
        {
            Random rand = new Random();
            int index = rand.Next(0, 2 * Scenery.Weapons2.Count);
            if (index<Scenery.Weapons2.Count)
            {
                return Scenery.Weapons2[index];
            }
            return null;
        }

        public void move(Action action)
        {
            Random moveDice = new Random();
            int result = moveDice.Next(2);
            if (result == 0)
            {
                //TODO: NOtify about drop
                action.Invoke();
                weaponBag.Add(GetSceneWeapon());
            }
            else
            {
                enemy = generateEnemy();
            }
        }

        public IList<Character> generateEnemy()
        {
            IList<Character> enemies = new List<Character>();
            int level = hero.Level;
            Random spawner = new Random();
            switch (level)
            {

                case 1:
                case 2:
                case 3:
                    enemies.Add(spawnEnemy(spawner.Next(4), level));
                    break;
                case 4:
                case 5:
                    enemies.Add(spawnEnemy(spawner.Next(4), level));
                    enemies.Add(new Tree());
                    break;
                default:
                    for (int i = 0; i < Convert.ToInt32(Math.Round(level * 0.5)); i++)
                    {
                        enemies.Add(new Tree());
                    }
                    break;

            }

            if (level >= 6)
            {
                int count = Convert.ToInt32(Math.Ceiling(level / 2.0));
                for (int i = 0; i < count; i++)
                {
                    enemies.Add(spawnEnemy(spawner.Next(4), level));
                }
            }
            return enemies;
        }

        public Character spawnEnemy(int type, int lev)
        {
            switch (type)
            {
                case 1:
                    return new Kod(lev / 2, new Skill(100, 25, 10, 50));
                case 2:
                    return new MegaWolf(lev / 2, new Skill(20, 100, 50, 25));
                case 3:
                    return new DarkElf(lev / 2, new Skill(100, 35, 12, 70));
                default:
                    return new Kod(lev / 2, new Skill(100, 25, 10, 50));
            }
        }
        public string EndStory()
        {
            if (Scenery != null)
            {
                StoryEnded = true;
                return Scenery.Story.Conclusion;
            }
            else
            {
                throw new ArgumentException();
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

        public int Attack(AttackAction actions, AttackType type, Character character)
        {
            Random rand = new Random();
            //AttackAction action = Dice(rand);
            int damage = 0;

            if (actions == AttackAction.active)
            {
                damage = character.Attack(AttackAction.active, type);
            }
            else if (actions == AttackAction.passive)
            {
                damage = character.Attack(AttackAction.passive, type);
            }
            return damage;
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
                    string command = "";
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
                        continue;
                    }
                    else if (actions == AttackActions.Miss)
                    {
                        combatant.ToList()[AttackerIndex].MissAttack();
                        continue;
                    }

                    for (int i = 0; i < combatant.Count(); i++)
                    {

                        if (i != AttackerIndex)
                        {
                            if (combatant.ToList()[i].getHealth > 0)
                            {
                                combatant.ToList()[i].Damage(damage);
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
        static void increaseHero(int health)
        {

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

