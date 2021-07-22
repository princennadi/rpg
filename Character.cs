using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum AttackType
    {
       physical, 
       magic,
    }

    public enum AttackAction
    {
        active,
        passive,
    }

    public abstract class Character
    {
        private string name;
        private string gender;
        private int level;
        private int age;
        private long maxHealth;
        private long life;
        private int sp;
        private int magicPoints;
        private int magicNeeded;
        private Skill skill;
        public string title { get; set; }
        public Weapons equipWeapon { get; set; }
        public Magic equipMagic { get; set; }
        public long getHealth { get { return life; } }

        public Character(string name, string gender, int level, int age, long maxHealth, Skill skill)
        {
            this.name = name;
            this.gender = gender;
            this.level = level;
            this.age = age;
            this.life = maxHealth;
            this.maxHealth = maxHealth;
            this.sp = 5;
            this.magicPoints = 10;
            this.magicNeeded = 5;
            this.skill = skill; 
        }

        public virtual void LevelUp()
        {
            level++;
        }

        public void Damage(int damage)
        {
            life -= damage;
        }
        public void Heal(int hp)
        {
            if (life + hp > maxHealth)
            {
                life = maxHealth;
            }
            else
            {
                life = life + hp;
            }
        }

        public int Attack(AttackAction action, AttackType type)
        {
            this.skill.loseSpeed(2);            
            int damage = 0;
            if (type == AttackType.physical)
            {
                if (equipWeapon != null)
                {

                    if (action == AttackAction.passive)
                    {
                        damage = equipWeapon.passiveDamage();
                    }
                    else if (action == AttackAction.active)
                    {
                        damage = equipWeapon.activeDamage();
                    }
                    
                }
                
            }
            else if (type == AttackType.magic)
            {
                if (magicPoints >= 0)
                {
                    if (action == AttackAction.passive)
                    {
                        damage = equipMagic.passiveMagic();
                        magicPoints = magicPoints - 3;
                    }
                    else if (action == AttackAction.active)
                    {
                        damage = equipMagic.activeMagic();
                        magicPoints = magicPoints - 5; 
                    }
                    damage += getSkill.getAttack;
                }
                else
                {
                    damage = 0;
                    return damage;
                }
                
            }
            return damage;
        }

        public void Restore()
        {
            this.skill.restoreSpeed();
        }

        public Skill getSkill { get { return skill; } }
        public string getName { get { return name; } }

        public override bool Equals(object obj)
        {

            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            Character other = (Character)obj;
            return this.getName == other.getName;



        }

        public void MissAttack()
        {
            this.skill.loseSpeed(2);
        }

        public override string ToString()
        {
            return name;
        }

    }
}
