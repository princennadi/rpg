using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Skill
    { 
        
        private int intelligence = 5;
        private int attack = 5;
        private int dexterity = 5;
        private int magic = 5;
        private int maxDexterity = 5;
        public int getIntelligence { get { return intelligence; } }
        public int getAttack { get { return attack; } }
        public int getDexterity { get { return dexterity; } }
        public int getMagic { get { return magic; } }

        public Skill(int intelligence, int attack, int dexterity, int magic)
        {
            this.intelligence = intelligence;
            this.attack = attack;
            this.dexterity = dexterity;
            this.maxDexterity = dexterity;
            this.magic = magic;
        }

        public Skill()
        {

        }


        public override string ToString()
        {
            return "Inteligence: " + intelligence + "\n" + "Attack: " + attack + "\n" + "Dexterity: " + dexterity + "\n" + "Magic: " + magic;

        }

        public void upgradeSkill(int sp, string skill)
        {
            if (skill == "intelligence")
            {
                intelligence += sp;
            }

            if (skill == "attack")
            {
                attack += sp;
            }

            if (skill == "dexterity")
            {
                dexterity += sp;
                maxDexterity += sp;
            }

            if (skill == "magic")
            {
                magic += sp;
            }
        }

        public void loseSpeed(int reduction)
        {
            dexterity = dexterity - reduction;
        }

        public void restoreSpeed()
        {
            this.dexterity = maxDexterity;
        }
    }
}
