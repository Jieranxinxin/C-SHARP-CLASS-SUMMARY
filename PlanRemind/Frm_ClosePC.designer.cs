namespace PlanRemind
{
    partial class Frm_ClosePC
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ClosePC));
            this.lblNowTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rbShowMessage = new System.Windows.Forms.RadioButton();
            this.rbLogout = new System.Windows.Forms.RadioButton();
            this.rbBegin = new System.Windows.Forms.RadioButton();
            this.rbShutDown = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbbWeek = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbcycleWeek = new System.Windows.Forms.RadioButton();
            this.rbcycleDay = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbAutoRun = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNowTime
            // 
            this.lblNowTime.AutoSize = true;
            this.lblNowTime.BackColor = System.Drawing.Color.Transparent;
            this.lblNowTime.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNowTime.ForeColor = System.Drawing.Color.White;
            this.lblNowTime.Location = new System.Drawing.Point(131, 205);
            this.lblNowTime.Name = "lblNowTime";
            this.lblNowTime.Size = new System.Drawing.Size(31, 14);
            this.lblNowTime.TabIndex = 5;
            this.lblNowTime.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "日期：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(297, 10);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(159, 21);
            this.txtMessage.TabIndex = 9;
            // 
            // rbShowMessage
            // 
            this.rbShowMessage.AutoSize = true;
            this.rbShowMessage.BackColor = System.Drawing.Color.Transparent;
            this.rbShowMessage.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbShowMessage.ForeColor = System.Drawing.Color.White;
            this.rbShowMessage.Location = new System.Drawing.Point(177, 12);
            this.rbShowMessage.Name = "rbShowMessage";
            this.rbShowMessage.Size = new System.Drawing.Size(115, 18);
            this.rbShowMessage.TabIndex = 8;
            this.rbShowMessage.Text = "显示提示信息";
            this.rbShowMessage.UseVisualStyleBackColor = false;
            // 
            // rbLogout
            // 
            this.rbLogout.AutoSize = true;
            this.rbLogout.BackColor = System.Drawing.Color.Transparent;
            this.rbLogout.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbLogout.ForeColor = System.Drawing.Color.White;
            this.rbLogout.Location = new System.Drawing.Point(122, 12);
            this.rbLogout.Name = "rbLogout";
            this.rbLogout.Size = new System.Drawing.Size(55, 18);
            this.rbLogout.TabIndex = 7;
            this.rbLogout.Text = "注销";
            this.rbLogout.UseVisualStyleBackColor = false;
            // 
            // rbBegin
            // 
            this.rbBegin.AutoSize = true;
            this.rbBegin.BackColor = System.Drawing.Color.Transparent;
            this.rbBegin.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbBegin.ForeColor = System.Drawing.Color.White;
            this.rbBegin.Location = new System.Drawing.Point(67, 12);
            this.rbBegin.Name = "rbBegin";
            this.rbBegin.Size = new System.Drawing.Size(55, 18);
            this.rbBegin.TabIndex = 6;
            this.rbBegin.Text = "重启";
            this.rbBegin.UseVisualStyleBackColor = false;
            // 
            // rbShutDown
            // 
            this.rbShutDown.AutoSize = true;
            this.rbShutDown.BackColor = System.Drawing.Color.Transparent;
            this.rbShutDown.Checked = true;
            this.rbShutDown.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbShutDown.ForeColor = System.Drawing.Color.White;
            this.rbShutDown.Location = new System.Drawing.Point(12, 12);
            this.rbShutDown.Name = "rbShutDown";
            this.rbShutDown.Size = new System.Drawing.Size(55, 18);
            this.rbShutDown.TabIndex = 5;
            this.rbShutDown.TabStop = true;
            this.rbShutDown.Text = "关机";
            this.rbShutDown.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(285, 461);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 40);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cbbWeek
            // 
            this.cbbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWeek.FormattingEnabled = true;
            this.cbbWeek.Items.AddRange(new object[] {
            "一",
            "二",
            "三",
            "四",
            "五",
            "六",
            "日"});
            this.cbbWeek.Location = new System.Drawing.Point(476, 407);
            this.cbbWeek.Name = "cbbWeek";
            this.cbbWeek.Size = new System.Drawing.Size(53, 20);
            this.cbbWeek.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 461);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rbcycleWeek
            // 
            this.rbcycleWeek.AutoSize = true;
            this.rbcycleWeek.BackColor = System.Drawing.Color.Transparent;
            this.rbcycleWeek.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbcycleWeek.ForeColor = System.Drawing.Color.White;
            this.rbcycleWeek.Location = new System.Drawing.Point(423, 409);
            this.rbcycleWeek.Name = "rbcycleWeek";
            this.rbcycleWeek.Size = new System.Drawing.Size(55, 18);
            this.rbcycleWeek.TabIndex = 5;
            this.rbcycleWeek.Text = "每周";
            this.rbcycleWeek.UseVisualStyleBackColor = false;
            // 
            // rbcycleDay
            // 
            this.rbcycleDay.AutoSize = true;
            this.rbcycleDay.BackColor = System.Drawing.Color.Transparent;
            this.rbcycleDay.Checked = true;
            this.rbcycleDay.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbcycleDay.ForeColor = System.Drawing.Color.White;
            this.rbcycleDay.Location = new System.Drawing.Point(372, 409);
            this.rbcycleDay.Name = "rbcycleDay";
            this.rbcycleDay.Size = new System.Drawing.Size(55, 18);
            this.rbcycleDay.TabIndex = 4;
            this.rbcycleDay.TabStop = true;
            this.rbcycleDay.Text = "每天";
            this.rbcycleDay.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(299, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 14);
            this.label9.TabIndex = 3;
            this.label9.Text = "执行周期：";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(131, 229);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(31, 14);
            this.lbltime.TabIndex = 11;
            this.lbltime.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "时间：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.rbShutDown);
            this.panel1.Controls.Add(this.rbBegin);
            this.panel1.Controls.Add(this.rbLogout);
            this.panel1.Controls.Add(this.rbShowMessage);
            this.panel1.Location = new System.Drawing.Point(75, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 42);
            this.panel1.TabIndex = 12;
            // 
            // chbAutoRun
            // 
            this.chbAutoRun.AutoSize = true;
            this.chbAutoRun.BackColor = System.Drawing.Color.Transparent;
            this.chbAutoRun.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chbAutoRun.ForeColor = System.Drawing.Color.White;
            this.chbAutoRun.Location = new System.Drawing.Point(87, 409);
            this.chbAutoRun.Name = "chbAutoRun";
            this.chbAutoRun.Size = new System.Drawing.Size(191, 18);
            this.chbAutoRun.TabIndex = 0;
            this.chbAutoRun.Text = "启用按预设时间关机功能";
            this.chbAutoRun.UseVisualStyleBackColor = false;
            // 
            // Frm_ClosePC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(556, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbWeek);
            this.Controls.Add(this.rbcycleWeek);
            this.Controls.Add(this.lblNowTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rbcycleDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbAutoRun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ClosePC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时关机";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbLogout;
        private System.Windows.Forms.RadioButton rbBegin;
        private System.Windows.Forms.RadioButton rbShutDown;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.RadioButton rbShowMessage;
        private System.Windows.Forms.ComboBox cbbWeek;
        private System.Windows.Forms.RadioButton rbcycleWeek;
        private System.Windows.Forms.RadioButton rbcycleDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNowTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbAutoRun;
    }
}

