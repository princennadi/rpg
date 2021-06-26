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
        private int level;
        private int age;
        private long maxHealth;
        private long life;
        private int sp;
        private int mp;
        private Skill skill;
        public string title { get; set; }
        public Weapons equipWeapon { get; set; }

        public Character(string name, int level, int age, long maxHealth, Skill skill)
        {
            this.name = name;
            this.level = level;
            this.age = age;
            this.life = maxHealth;
            this.maxHealth = maxHealth;
            this.sp = 5;
            this.mp = 5;
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

        public int Attack(AttackAction action)
        {
            this.skill.loseSpeed(2);            
            int damage = 0;
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
                damage += getSkill.getAttack;
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

    }
}
