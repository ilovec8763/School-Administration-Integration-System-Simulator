namespace 校務系統
{
    partial class frmHomework
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerDueDay = new System.Windows.Forms.Timer(this.components);
            this.lblHour = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.dgvHomework = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomework)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDueDay
            // 
            this.timerDueDay.Enabled = true;
            this.timerDueDay.Tick += new System.EventHandler(this.timerDueDay_Tick);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHour.Location = new System.Drawing.Point(352, 50);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(49, 20);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "Hour";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDay.Location = new System.Drawing.Point(293, 50);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(39, 20);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Day";
            // 
            // dgvHomework
            // 
            this.dgvHomework.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomework.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvHomework.Location = new System.Drawing.Point(124, 138);
            this.dgvHomework.Name = "dgvHomework";
            this.dgvHomework.ReadOnly = true;
            this.dgvHomework.RowTemplate.Height = 27;
            this.dgvHomework.Size = new System.Drawing.Size(322, 150);
            this.dgvHomework.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "作業";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "剩餘天數";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(127, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "日期 : ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(211, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "即將到期的作業";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonth.Location = new System.Drawing.Point(215, 50);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(59, 20);
            this.lblMonth.TabIndex = 8;
            this.lblMonth.Text = "Month";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(239, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "離開";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHomework);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblHour);
            this.Name = "frmHomework";
            this.Text = "frmHomework";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomework)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerDueDay;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.DataGridView dgvHomework;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button button1;
    }
}