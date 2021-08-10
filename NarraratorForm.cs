using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class NarraratorForm : Form
    {
        private Narrarator narrarator;
        public NarraratorForm()
        {
            InitializeComponent();
            narrarator = new Narrarator();
        }

        private void createaweaponButton_Click(object sender, EventArgs e)
        {
            string type = pickWeaponType.SelectedItem.ToString();
            int damage = Convert.ToInt32(damagePicker.Value);
            if (damage == 0)
            {
                narrarator.createWeapon(type,null);
            }
            else
            {
                narrarator.createWeapon(type, damage);
            }
           
            narrarator.createWeapon(type, damage);
        }
    }
}
