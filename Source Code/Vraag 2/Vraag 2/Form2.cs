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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int GetSpeedValue2 = 0;
        public static int GetManaValue2 = 0;
        public static int GetDamageValue2 = 0;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int speed = Form1.GetSpeedValue;
            int mana = Form1.GetManaValue;
            int damage = Form1.GetDamageValue;

            Perks(out mana, out speed, out damage);

            GetSpeedValue2 = speed;
            GetManaValue2 = mana;
            GetDamageValue2 = damage;

            this.Close();
        }

        public void Perks(out int mana, out int speed, out int damage)
        {
            speed = Form1.GetSpeedValue;
            mana = Form1.GetManaValue;
            damage = Form1.GetDamageValue;

            if (rbMana.Checked)
            {
                mana = mana + (mana * 15 / 100);                                                                        //Numeric Calculation
                speed = speed - (speed * 10 / 100);
            }
            else if (rbDamage.Checked)
            {
                mana = mana - (mana * 5 / 100);
                speed = speed - (speed * 10 / 100);
                damage = damage + (damage * 20 / 100);
            }
            else
            {
                MessageBox.Show("Are you sure you don't want any perks?");
                speed = Form1.GetSpeedValue;
                mana = Form1.GetManaValue;
                damage = Form1.GetDamageValue;
            }
        }
    }
}
