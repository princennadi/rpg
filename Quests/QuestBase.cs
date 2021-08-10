using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Quests
{
    public class QuestBase
    {
        private string title;
        private string challenge;
        private int target;
        private Character enemy;
        public string Title { get { return title; } }
        public string Challenge { get { return challenge; } }
        public int Target { get { return target; } }
        public Character Enemy { get { return enemy; } }
        public bool Completed { get; set; } = false;

        public QuestBase(string title, string challenge, int target, Character enemy = null)
        {
            this.title = title;
            this.challenge = challenge;
            this.target = target;
            this.enemy = enemy;
        }
        public static bool operator !=(QuestBase a, QuestBase b)
        {
            if (a == null || b == null)
            {
                return true;
            }
            return a.Title != b.Title;
        }

        public static bool operator ==(QuestBase a, QuestBase b)
        {
            if (a == null || b == null)
            {
                return false;
            }
            return a.Title == b.Title;
        }

    }
}
