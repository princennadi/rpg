using ConsoleApp1;
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
    public partial class CharacterCreation : Form
    {
        public CharacterCreation()
        {
            InitializeComponent();
        }
        private Narrarator narrarator1;
        
        public CharacterCreation(Narrarator narrarator)
        {
            InitializeComponent();
            narrarator1 = narrarator;
        }
        private void createAHero_Click(object sender, EventArgs e)
        {
            Character hero = narrarator1.createHero(nameText.Text, genderText.Text, Convert.ToInt32(ageUpDown.Value), pickAHero.SelectedItem.ToString());
            Form1.hero = hero;
            MessageBox.Show("Hero Created!");
            this.Close();
        }
    }
}
