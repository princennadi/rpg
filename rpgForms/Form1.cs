using ConsoleApp1;
using ConsoleApp1.Quests;
using ConsoleApp1.Scenery;
using ConsoleApp1.Stories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpgForms
{
    public partial class Form1 : Form
    {
        private SceneryBase scenery;
        private StoryBase story;
        private QuestBase quest;
        public static Character hero;
        private Narrarator narrarator;
        public Form1()
        {
            InitializeComponent();
            narrarator = new Narrarator();
            new CharacterCreation(narrarator).ShowDialog(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int lev, int dex, int smarts, int hits, int magical, int maxLife, string vil
           // string name, List< Weapons > availableWeapons, StoryBase story, List< Weapons > weapons
        }

        private void ItemPickUp_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void level_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void updateStats(int num, string name)
        {
            if (name == "speed")
            {
                speedAmt.Text = num.ToString();
            }
          
            else if (name == "smarts")
            {
                inteligenceAmt.Text = num.ToString();
            }
           
            else if (name == "magic")
            {
                magicAmt.Text = num.ToString();
            }
          
            else if (name == "attack")
            {
                attackAmt.Text = num.ToString();
            }
           else
            {
                num = 0;
            }

        }
        private void refreshQuest()
        {
            foreach (var item in story.Challenge)
            {
                questBox.Items.Add(item.Title, item.Completed);
            }
        }

        private void refreshHealth()
        {
            healthAmt.Text = hero.getHealth.ToString();
        }

        private void Move_Click(object sender, EventArgs e)
        {
            narrarator.move(() => notification());
        }

        private void lifeRemaining()
        {
            string lifeLeft = hero.getHealth.ToString();
            healthAmt.Text = lifeLeft;
        }

        private void levelsToText()
        {
            levelAmt.Text = hero.Level.ToString();
        }

        private void speedToText()
        {
            speedAmt.Text = hero.getSkill.getDexterity.ToString();
        }

        private void smartsToText()
        {
            inteligenceAmt.Text = hero.getSkill.getIntelligence.ToString();
        }
        
        private void attackToText()
        {
            attackAmt.Text = hero.getSkill.getAttack.ToString();
        }

        private void magicToText()
        {
            magicAmt.Text = hero.getSkill.getMagic.ToString();
        }

        private void notification()
        {
            narraratorSpeech.Text = narraratorSpeech.Text + "\n" + "Item Dropped";
        }

        private void healthAmt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
