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
    public partial class frmHomework : Form
    {
        public frmHomework()
        {
            InitializeComponent();
        }
        //作業截止日期
        string[] arryName = new string[] { "植物生理學", "普通生物", "計算機概論", "電影社會學" };
        int[] arryDueMonth = new int[] { 1, 2, 1, 1 };//到期月份
        int[] arryDueDay = new int[] { 16, 2, 5, 4 };//到期日
        int[] arryDueHour = new int[] { 7, 20, 23, 23 };//到期時段

        private void timerDueDay_Tick(object sender, EventArgs e)
        {

            try
            {
                DateTime dt = DateTime.Now;
                lblMonth.Text = dt.Month.ToString() + "月";
                lblDay.Text = dt.Day.ToString() + "日";
                lblHour.Text = dt.Hour.ToString() + "時";
                timerDueDay.Enabled = false;
                for (int i = 0; i < arryDueMonth.Length; i++)//建立迴圈檢查作業繳交狀況
                {
                    int Day = arryDueDay[i] - dt.Day;
                    int Hour = arryDueHour[i] - dt.Hour;
                    DataGridViewRowCollection rows = dgvHomework.Rows;
                    if (arryDueMonth[i] == dt.Month)
                    {
                        if (Day < 0)
                        {
                            //過期提醒
                            MessageBox.Show("作業" + arryName[i] + "已過期" + -Day + "天");
                        }

                        else if (Day > 0)
                        {
                            if (Hour < 0) { Day--; Hour = Hour + 24; }
                            rows.Add(new object[] { arryName[i], Day + "天" + Hour + "時" });
                        }
                        else
                        {
                            //今日到期提醒
                            rows.Add(new object[] { arryName[i], Day + "天" + Hour + "時" });
                            MessageBox.Show("今天到期 : " + arryName[i]+"  剩"+Hour+"個小時"); }
                        }

                 }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
