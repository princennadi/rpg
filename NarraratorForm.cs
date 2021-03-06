using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;

namespace rpgForms
{
    public partial class NarraratorForm : Form
    {
        private Narrarator narrarator;
        public List<ConsoleApp1.Quests.QuestBase> quests;
        public List<ConsoleApp1.Scenery.SceneryBase> scenes;
        public List<Weapons> weapons;
        public List<Character> characters;
        public NarraratorForm()
        {
            InitializeComponent();
            narrarator = new Narrarator();
            quests = new List<ConsoleApp1.Quests.QuestBase>();
            scenes = new List<ConsoleApp1.Scenery.SceneryBase>();
            weapons = new List<Weapons>();
            characters = new List<Character>();
        }

        private void createaweaponButton_Click(object sender, EventArgs e)
        {
            string type = pickWeaponType.SelectedItem.ToString();
            int damage = Convert.ToInt32(damagePicker.Value);
            Weapons weapon;
            if (damage == 0)
            {
               weapon = narrarator.createWeapon(type,null);
            }
            else
            {
               weapon = narrarator.createWeapon(type, damage);
            }
           
           weapon = narrarator.createWeapon(type, damage);
            weapons.Add(weapon);
            updateLists();
        }
        

        private void addQuest_Click(object sender, EventArgs e)
        {
            var quest = new ConsoleApp1.Quests.QuestBase(TitleBox.Text, ChallengeBox.Text, Convert.ToInt32((TargetBox.Value)), narrarator.createVillian(VillianBox.SelectedItem.ToString()));
            quests.Add(quest);
        }

        private void CreateScene_btn_Click(object sender, EventArgs e)
        {
            var story = narrarator.newStory(StoryTitle.Text, quests, StoryIntro.Text, StoryConclusion.Text);
            var scene = narrarator.newScene(SceneName.Text, story, ChooseScene.SelectedItem.ToString());
            narrarator.scenes.Add(scene);
            quests.Clear();
            updateLists();
        }

        private void StoryTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void createVillianButton_Click(object sender, EventArgs e)
        {
            var villian = narrarator.createVillian(Convert.ToInt32(LevelBox.Text), Convert.ToInt32(DexterityBox.Text), Convert.ToInt32(InteligenceBox.Text),Convert.ToInt32(StrengthBox.Text), Convert.ToInt32(MagicBox.Text), Convert.ToInt32(MaxLifeBox.Text), NameBox.Text);
            characters.Add(villian);
            updateLists();
        }

        private void updateLists()
        {
            Weapons.Items.Clear();
            Scene.Items.Clear();
            Character.Items.Clear();
            foreach (var item in weapons)
            {
                Weapons.Items.Add(new ListViewItem(item.ToString()));
            }
            foreach (var item in scenes)
            {
                Scene.Items.Add(new ListViewItem(item.ToString()));
            }
            foreach (var item in characters)
            {
                Character.Items.Add(new ListViewItem(item.ToString()));
            }
        }
        private void startGame_Click(object sender, EventArgs e)
        {
        }
    }
}
