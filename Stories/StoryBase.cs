using ConsoleApp1.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Stories
{
    public  class StoryBase
    {
        private string title;
        private List<QuestBase> challenge;
        private string intro;
        private string conclusion;
        public string Title { get { return title; } }
        public List<QuestBase> Challenge { get { return challenge; } }
        public string Introduction { get { return intro; } }
        public string Conclusion { get { return conclusion; } }

        public StoryBase (string title, List<QuestBase> challenge, string intro, string conclusion)
        {
            this.title = title;
            this.challenge = challenge;
            this.intro = intro;
            this.conclusion = conclusion;
        }
    }
}
