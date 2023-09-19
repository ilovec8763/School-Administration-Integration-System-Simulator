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
    public partial class FrmCourseChoose : Form
    {
        ClassCourseChoose s = new ClassCourseChoose();//建立選課類別的物件
        
        public FrmCourseChoose()
        {
            InitializeComponent();
            String[] Dep = new String[] { "理學院", "工學院", "醫學院", "文學院" , "生物科學與科技學院","通識課程" };
            foreach(string i in Dep)
            {
                cboDep.Items.Add(i);
            }
            for(int i=1;i<=7;i++)
            {
                cboGrade.Items.Add(i.ToString()+" 年級");
            }
        }

        
        int No = 1;
        int total = 0;
        int Sup=25;//最高修習學分
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDep.Text == "" || cboDep.Text == "") { throw new Exception("請選擇所屬系別，年級"); }
                if (s.CourseCheck(txtCourse.Text) == "無此課程")
                {
                    throw new Exception("查無此課程");
                }
                
                //判斷是否超修
                if (total > Sup) { throw new Exception("已超過每學期學分上限"); }
                //醫學院的課程(I5)外系不得選修
                if(txtCourse.Text.Substring(0,2)== "I5"&& s.MedicineOrNot(cboDep.Text)==false)
                {
                    throw new Exception("外系不得選修");
                }
                //避免重複加入字典索引，宣告整數point存取單科學分
                //將選課結果加入已選清單，判斷是否重複選課，並加學分到total
                int point =s.CreateDic(txtCourse.Text);
                total +=point;
                //判斷是否超修          
                if (total > Sup) { throw new Exception("已超過每學期學分上限"); }
                //將選課結果表示成清單
                DataGridViewRowCollection rows = dgvCourse.Rows;
                rows.Add(new object[] { No.ToString(), s.DepNum(txtCourse.Text), txtCourse.Text, s.CourseCheck(txtCourse.Text), point });
                No++;
                txtCourse.Text = "";
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnReChoose_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection rows = dgvCourse.Rows;
            dgvCourse.Rows.Clear();//清除列的內容
            Dictionary<string, bool> dicCourseHaveChoosed = new Dictionary<string, bool>();//將已選課的字典初始化
            cboDep.Text = "";
            cboGrade.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
