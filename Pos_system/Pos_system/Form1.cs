using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Tea1 = 0; 
        int Tea2 = 0;
        int Tea3 = 0;
        int Tea4 = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                if(comboBox1.Items.IndexOf(comboBox1.Text) ==0)
                {
                    Tea1 = 35 * 1;
                }
                else if (comboBox1.Items.IndexOf(comboBox1.Text) == 1)
                {
                    Tea1 = 35 * 2;
                }
                else if (comboBox1.Items.IndexOf(comboBox1.Text) == 2)
                {
                    Tea1 = 35 * 3;
                }
                else if (comboBox1.Items.IndexOf(comboBox1.Text) == 3)
                {
                    Tea1 = 35 * 4;
                }
                else if (comboBox1.Items.IndexOf(comboBox1.Text) == 4)
                {
                    Tea1 = 35 * 5;
                }
                Program.greenTea = Tea1;
            }
            if (checkBox2.Checked == true)
            {
                if (comboBox2.Items.IndexOf(comboBox2.Text) == 0)
                {
                    Tea2 = 40 * 1;
                }
                else if (comboBox2.Items.IndexOf(comboBox2.Text) == 1)
                {
                    Tea2 = 40 * 2;
                }
                else if (comboBox2.Items.IndexOf(comboBox2.Text) == 2)
                {
                    Tea2 = 40 * 3;
                }
                else if (comboBox2.Items.IndexOf(comboBox2.Text) == 3)
                {
                    Tea2 = 40 * 4;
                }
                else if (comboBox2.Items.IndexOf(comboBox2.Text) == 4)
                {
                    Tea2 = 40 * 5;
                }
                Program.season = Tea2;
            }
            if (checkBox3.Checked == true)
            {
                if (comboBox3.Items.IndexOf(comboBox3.Text) == 0)
                {
                    Tea3 = 60 * 1;
                }
                else if (comboBox3.Items.IndexOf(comboBox3.Text) == 1)
                {
                    Tea3 = 60 * 2;
                }
                else if (comboBox3.Items.IndexOf(comboBox3.Text) == 2)
                {
                    Tea3 = 60 * 3;
                }
                else if (comboBox3.Items.IndexOf(comboBox3.Text) == 3)
                {
                    Tea3 = 60 * 4;
                }
                else if (comboBox3.Items.IndexOf(comboBox3.Text) == 4)
                {
                    Tea3 = 60 * 5;
                }
                Program.bubble = Tea3;
            }
            if (checkBox4.Checked == true)
            {
                if (comboBox4.Items.IndexOf(comboBox4.Text) == 0)
                {
                    Tea4 = 80 * 1;
                }
                else if (comboBox4.Items.IndexOf(comboBox4.Text) == 1)
                {
                    Tea4 = 80 * 2;
                }
                else if (comboBox4.Items.IndexOf(comboBox4.Text) == 2)
                {
                    Tea4 = 80 * 3;
                }
                else if (comboBox4.Items.IndexOf(comboBox4.Text) == 3)
                {
                    Tea4 = 80 * 4;
                }
                else if (comboBox4.Items.IndexOf(comboBox4.Text) == 4)
                {
                    Tea4 = 80 * 5;
                }
                Program.redTea = Tea4;
            }

            if (
                /*烏龍綠茶*/((checkBox1.Checked && (comboBox1.Items.IndexOf(comboBox1.Text) == 0)) || (checkBox1.Checked && (comboBox1.Items.IndexOf(comboBox1.Text) == 1) || (checkBox1.Checked && (comboBox1.Items.IndexOf(comboBox1.Text) == 2) || (checkBox1.Checked && (comboBox1.Items.IndexOf(comboBox1.Text) == 3) || (checkBox1.Checked && (comboBox1.Items.IndexOf(comboBox1.Text) == 4))
                /*四季春茶*/ ||(((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 0)) || ((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 1) || ((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 2) || ((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 3) || ((checkBox2.Checked == true) && (comboBox2.Items.IndexOf(comboBox2.Text) == 4))
                /*珍珠奶茶*/ ||(((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 0)) || ((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 1) || ((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 2) || ((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 3) || ((checkBox3.Checked == true) && (comboBox3.Items.IndexOf(comboBox3.Text) == 4))
                /*紅茶拿鐵*/ ||((checkBox4.Checked == true && (comboBox4.Items.IndexOf(comboBox4.Text) == 0)) || ((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 1) || ((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 2) || ((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 3) || ((checkBox4.Checked == true) && (comboBox4.Items.IndexOf(comboBox4.Text) == 4))
                ))))))))))))))))){
                Form2 frame = new Form2();
                frame.Show(); 
                }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
