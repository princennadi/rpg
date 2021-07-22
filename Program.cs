using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG

{
    class Program

    {
        public enum AttackActions
        {
            Active,
            Passive,
            Miss,
            SelfDamage,
        }

        static void Main(string[] args)
        {
            MegaWolf v1 = new MegaWolf(2, new Skill(3, 4, 5, 6));
            Kod v2 = new Kod(1, new Skill(2, 3, 4, 5));


            List<Character> battleCharacters = new List<Character>()
            {
                v1,v2
            };
            Character winner = Battle(battleCharacters);
            
            if(winner != null)
            {
                Console.WriteLine(winner.ToString() + " is the victor");
            }
            else
            {
                Console.WriteLine("everybody died");
            }
            Console.ReadLine();

           
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
                    else if(command == "physical")
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
                    int damage = combatant.ToList()[AttackerIndex].Attack(AttackAction.passive,type);
                    if (actions == AttackActions.Active)
                    {
                        damage = combatant.ToList()[AttackerIndex].Attack(AttackAction.active,type);
                    }
                   else if (actions == AttackActions.Passive)
                    {
                        damage = combatant.ToList()[AttackerIndex].Attack(AttackAction.passive,type);
                    }
                    else if (actions == AttackActions.SelfDamage)
                    {
                        damage = combatant.ToList()[AttackerIndex].Attack(AttackAction.passive,type);
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

                    Console.WriteLine(temporary.ToString() + " has dealt " +  + damage + " damage");
                    for (int i = 0; i < combatant.Count(); i++)
                    {

                        if (i != AttackerIndex)
                        {
                            if(combatant.ToList()[i].getHealth > 0)
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
                    else if(count == 0)
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
            else if(randomNumber == 2)
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
            else if(aa.getSkill.getDexterity < ab.getSkill.getDexterity)
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
