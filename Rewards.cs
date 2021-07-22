using ConsoleApp1.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rewards
    {
        private Dictionary<string, DropItem> Reward = new Dictionary<string, DropItem>();
        public Rewards()
        {
            Reward.Add("Sword", new DropItem(DropRate.High, new Sword()));
        }

        public void AddReward(string rewardName, object reward, DropRate dropRate = DropRate.High)
        {
            Reward.Add(rewardName, new DropItem(DropRate.High,reward));
        }
        public object getReward()
        {
            Random random = new Random();
            double chance = random.NextDouble();
            if (chance < 0.5 && chance >= 0.0)
            {
                var possibleRewards = Reward.Where(r => r.Value.DropRate == DropRate.High).ToList();
                Random random1 = new Random();
                int choice = random1.Next(possibleRewards.Count);
                return possibleRewards[choice].Value.Item;
            }
            else if (chance >= 0.5 && chance < 0.9)
            {
                var possibleRewards = Reward.Where(r => r.Value.DropRate == DropRate.Medium).ToList();
                Random random1 = new Random();
                int choice = random1.Next(possibleRewards.Count);
                return possibleRewards[choice].Value.Item;
            }
            else if (chance >= 0.9 && chance < 1.0)
            {
                var possibleRewards = Reward.Where(r => r.Value.DropRate == DropRate.Low).ToList();
                Random random1 = new Random();
                int choice = random1.Next(possibleRewards.Count);
                return possibleRewards[choice].Value.Item;
            }
            else
            {
                return null;
            }
        }
        internal class DropItem
        {
            private DropRate dropRate;
            private object item;
            public DropRate DropRate { get { return dropRate; } }
            public object Item { get { return item; } }

            public DropItem(DropRate dropRate, object item)
            {
                this.dropRate = dropRate;
                this.item = item;
            }
        }
    }
   public enum DropRate
    {
        High,
        Medium,
        Low
    }
   
}
