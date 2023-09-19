using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末作業
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        int N=0;
        int Q1R1 = 0;
        int Q1R2 = 0;
        int Q1R3 = 0;
        int Q2R1 = 0;
        int Q2R2 = 0;
        int Q2R3 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            N++;
            if (N == 1)
            {
                if (N == 1 && radioButton1.Checked == true)
                {
                    Q1R1++;
                }
                else if (N == 1 && radioButton2.Checked == true)
                {
                    Q1R2++;
                }
                else if (N == 1 && radioButton3.Checked == true)
                {
                    Q1R3++;
                }
                MessageBox.Show("投票成功");
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
                this.radioButton3.Checked = false;
                textBox1.Text = "是否支持成大擴建校園將整個東區升級為大學城?";
                button1.Enabled = false;
            }

            else if (N == 2)
            {
                button1.Enabled = true;

                if (N == 2 && radioButton1.Checked == true)
                {
                    Q2R1++;
                }
                else if (N == 2 && radioButton2.Checked == true)
                {
                    Q2R2++;
                }
                else if (N == 2 && radioButton3.Checked == true)
                {
                    Q2R3++;
                }

                button1.Enabled = false;
                textBox1.Text = "感謝您的作答!\r\n" + "是否支持成大爭取預算" + "\n贊成:" + Q1R1 + "否定:" + Q1R2 + "無意見:" + Q1R3 + "\r\n是否支持擴建校園" + "\n贊成:" + Q2R1 + "否定:" + Q2R2 + "無意見:" + Q2R3;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
