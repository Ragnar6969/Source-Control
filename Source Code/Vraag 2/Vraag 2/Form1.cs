using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//34539476
//Mornay Crous
namespace Vraag_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int GetSpeedValue = 0;
        public static int GetManaValue = 0;
        public static int GetDamageValue = 0;

        private void btnGet_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            int speed = 0, mana = 0, damage = 0;                                                                        //Variables
            string choice = "";
            Stats(out speed, out mana, out damage);

            GetSpeedValue = speed;
            GetManaValue = mana;
            GetDamageValue = damage;

            if (lbChar.SelectedIndex == -1)                                                                             //if-else-statement
            {
                MessageBox.Show("Nothing selected");                                                                    
            }
            else
            {
                Form2 frm = new Form2();
                frm.ShowDialog();
                lbOutput.Items.Add("You have chosen " + CharChoice(choice) + " and this is your Stats: ");
                lbOutput.Items.Add("Speed: " + Form2.GetSpeedValue2 + "pts");
                lbOutput.Items.Add("Mana: " + Form2.GetManaValue2 + "pts");
                lbOutput.Items.Add("Damage: " + Form2.GetDamageValue2 + "pts");
            }
        }

        public void Stats(out int speed, out int mana, out int damage)                                                  //void method
        {
            speed = 0;
            mana = 0;
            damage = 0;

            if (lbChar.SelectedItem == "Warrior")
            {
                speed = 100;
                mana = 50;
                damage = 150;
            }
            else if (lbChar.SelectedItem == "Mage")
            {
                speed = 100;
                mana = 150;
                damage = 50;
            }
            else if (lbChar.SelectedItem == "Rogue")
            {
                speed = 150;
                mana = 100;
                damage = 50;
            }
        }

        private string CharChoice(string choice)                                                                        //value-returning method
        {
            if (lbChar.SelectedItem == "Warrior")
            {
                choice = "Warrior";
            }
            else if (lbChar.SelectedItem == "Mage")
            {
                choice = "Mage";
            }
            else if (lbChar.SelectedItem == "Rogue")
            {
                choice = "Rogue";
            }
            return choice;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to exit");
            this.Close();
        }
    }
}
