using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public abstract class Weapons
    {
        private string name;
        private double criticalChance;
        private int damage;
        private int level;
        public Weapons(string name, double criticalChance, int damage)
        {
            this.name = name;
            this.criticalChance = criticalChance;
            this.damage = damage;
        }

        public virtual int passiveDamage()
        {
            return 0;
        }

        public virtual int activeDamage()
        {
            return criticalDamage();
        }

        public int criticalDamage()
        {
            var rand = new Random();
            double chance = rand.NextDouble();
            if (chance >= criticalChance )
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void levelUp()
        {
            level++;
            damage += Convert.ToInt32(Math.Ceiling(damage * criticalChance));
        }

        public int getDamage { get { return damage; } }
        public int getLevel { get { return level; } }

        public override string ToString()
        {
            return "Level " + level.ToString() +", "+ name;
        }
    }
}
