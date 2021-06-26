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
        static void Main(string[] args)
        {
            MegaWolf v1 = new MegaWolf(20);
            Kod v2 = new Kod(35);
            Dice(v1, v2);

            List<Character> battleCharacters = new List<Character>()
            {
                v1,v2
            };
            

        }
        static Character Battle(IEnumerable<Character> combatant)
        {
            if (combatant.Count() < 2)
            {
                return null;
            }
            else
            {
                while (true)
                {
                    Character temporary = Dice(combatant.ToArray());
                    int AttackerIndex = combatant.ToList().FindIndex(temp => temporary == temp);
                    combatant.ToList()[AttackerIndex].
                }
            }
        }

        static Character Dice(params Character[] a)
        {
            
            List<Character> dexx = new List<Character>(a);
            dexx.Sort(DexterityComparer);
            return dexx.Last();
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
