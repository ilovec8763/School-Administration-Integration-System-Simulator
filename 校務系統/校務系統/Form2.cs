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
    
    public partial class Form2 : Form
    {
        校務系統.ClassCourseChoose s = new 校務系統.ClassCourseChoose();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//確認  檢查
        {
            try
            {
                if (s.CourseCheck(textBox1.Text) != "無此課程")
                {
                    textBox2.Enabled = true;
                    button2.Enabled = true;
                }
                else { throw new Exception(s.CourseCheck(textBox1.Text)); };//顯示錯誤訊息"無此課程"
                // s.ca(textBox1.Text, textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)//回到首頁
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//儲存
        {
            try
            {
                s.ca(textBox1.Text, textBox2.Text);//利用函式ca將意見存到該課程的條目之下
                MessageBox.Show("儲存成功!");
                textBox2.Text = "";
                textBox2.Enabled = false;
                button2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
