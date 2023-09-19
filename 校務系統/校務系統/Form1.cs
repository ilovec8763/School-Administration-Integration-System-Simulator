using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 校務系統
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            txtPassword.PasswordChar = '*';
        }
        private void button5_Click(object sender, EventArgs e)//登入  check帳密是否正確
        {
            if (txtKey .Text== "C12345678"&&txtPassword.Text=="123123")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                txtKey.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("登入成功!!!");
                txtKey.Enabled = false;
                txtPassword.Enabled = false;
                btnLeave.Enabled = true;
            }
            else
            {
                txtKey.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("輸入帳號或密碼錯誤","登入失敗",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button6_Click(object sender, EventArgs e)//清除
        {
            txtKey.Text = "";
            txtPassword.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)//選課系統
        {
            FrmCourseChoose f = new FrmCourseChoose();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//作業提醒
        {
            frmHomework f = new frmHomework();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)//投票系統
        {
            期末作業.Form1 f = new 期末作業.Form1();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)//教學意見
        {
            期末作業.Form2 f = new 期末作業.Form2();
            f.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            /*frmForgot f = new frmForgot();
            f.ShowDialog();*/

        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            txtKey.Enabled = true;
            txtPassword.Enabled = true;
            MessageBox.Show("登出成功");
        }
    }
}