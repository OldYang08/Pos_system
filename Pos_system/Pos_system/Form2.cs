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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();

            label1.Text = "烏龍綠茶" + Program.greenTea / 35 + " 份" + "\r\n" +
                          "四季春茶" + Program.season / 40 + " 份" + "\r\n" +
                          "珍珠奶茶" + Program.bubble / 60 + " 份" + "\r\n" +
                          "紅茶拿鐵" + Program.redTea / 80 + " 份" + "\r\n";
        }

        int total = 0;
        int discount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            total = Program.greenTea + Program.season + Program.bubble + Program.redTea; ;
            discount = Convert.ToInt32(total * 0.8);

            if (radioButton2.Checked == true)
            {
                label2.Text = "購買金額:" + total + "元";
            }
            if (radioButton1.Checked == true)
            {
                label2.Text = "原始總金額:" + total + "元" + "\r\n" + "折扣後之金額" + discount + "元";
            }
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 1;
            if(i >= 20)
            {
                label2.Text = "超過時間，請重新點餐";
            }
            if (i == 25)
            {
                this.Close();
            }
        }
    }
}
