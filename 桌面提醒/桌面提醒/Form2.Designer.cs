namespace 桌面提醒
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_PlanRegister = new System.Windows.Forms.Panel();
            this.cbox_PlanKind = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtp_ExecuteTime = new System.Windows.Forms.DateTimePicker();
            this.txt_PlanTitle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtb_PlanContent = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_PlanRegister = new System.Windows.Forms.DataGridView();
            this.IndivNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecuteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Explain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_PlanStat = new System.Windows.Forms.Panel();
            this.dgv_PlanStat = new System.Windows.Forms.DataGridView();
            this.IndivNum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanTitle2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanKind2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecuteTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanContent2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoFlag2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Explain2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rb_UnDoFlag = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rb_DoFlag = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nud_TimeInterval = new System.Windows.Forms.NumericUpDown();
            this.lab_AutoRetrieve = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chb_IsTimeCue = new System.Windows.Forms.CheckBox();
            this.chb_IsAutoCheck = new System.Windows.Forms.CheckBox();
            this.lab_Days = new System.Windows.Forms.Label();
            this.nud_Days = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel_PlanRegister.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlanRegister)).BeginInit();
            this.panel_PlanStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlanStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimeInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Days)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.panel_PlanRegister);
            this.groupBox1.Controls.Add(this.panel_PlanStat);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nud_TimeInterval);
            this.groupBox1.Controls.Add(this.lab_AutoRetrieve);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chb_IsTimeCue);
            this.groupBox1.Controls.Add(this.chb_IsAutoCheck);
            this.groupBox1.Controls.Add(this.lab_Days);
            this.groupBox1.Controls.Add(this.nud_Days);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(229, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 405);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(15, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(620, 2);
            this.label12.TabIndex = 13;
            // 
            // panel_PlanRegister
            // 
            this.panel_PlanRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PlanRegister.Controls.Add(this.cbox_PlanKind);
            this.panel_PlanRegister.Controls.Add(this.button4);
            this.panel_PlanRegister.Controls.Add(this.button3);
            this.panel_PlanRegister.Controls.Add(this.button2);
            this.panel_PlanRegister.Controls.Add(this.dtp_ExecuteTime);
            this.panel_PlanRegister.Controls.Add(this.txt_PlanTitle);
            this.panel_PlanRegister.Controls.Add(this.groupBox3);
            this.panel_PlanRegister.Controls.Add(this.label10);
            this.panel_PlanRegister.Controls.Add(this.label9);
            this.panel_PlanRegister.Controls.Add(this.label8);
            this.panel_PlanRegister.Controls.Add(this.dgv_PlanRegister);
            this.panel_PlanRegister.Location = new System.Drawing.Point(30, 59);
            this.panel_PlanRegister.Name = "panel_PlanRegister";
            this.panel_PlanRegister.Size = new System.Drawing.Size(696, 202);
            this.panel_PlanRegister.TabIndex = 10;
            // 
            // cbox_PlanKind
            // 
            this.cbox_PlanKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_PlanKind.Enabled = false;
            this.cbox_PlanKind.FormattingEnabled = true;
            this.cbox_PlanKind.Items.AddRange(new object[] {
            "一般计划",
            "比较重要",
            "十分重要"});
            this.cbox_PlanKind.Location = new System.Drawing.Point(528, 60);
            this.cbox_PlanKind.Name = "cbox_PlanKind";
            this.cbox_PlanKind.Size = new System.Drawing.Size(133, 26);
            this.cbox_PlanKind.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(610, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtp_ExecuteTime
            // 
            this.dtp_ExecuteTime.CustomFormat = "yyyy-MM-dd";
            this.dtp_ExecuteTime.Enabled = false;
            this.dtp_ExecuteTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ExecuteTime.Location = new System.Drawing.Point(528, 100);
            this.dtp_ExecuteTime.Name = "dtp_ExecuteTime";
            this.dtp_ExecuteTime.Size = new System.Drawing.Size(133, 28);
            this.dtp_ExecuteTime.TabIndex = 7;
            // 
            // txt_PlanTitle
            // 
            this.txt_PlanTitle.Enabled = false;
            this.txt_PlanTitle.Location = new System.Drawing.Point(528, 19);
            this.txt_PlanTitle.Name = "txt_PlanTitle";
            this.txt_PlanTitle.Size = new System.Drawing.Size(133, 28);
            this.txt_PlanTitle.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtb_PlanContent);
            this.groupBox3.Location = new System.Drawing.Point(465, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 219);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "计划内容：";
            // 
            // rtb_PlanContent
            // 
            this.rtb_PlanContent.Enabled = false;
            this.rtb_PlanContent.Location = new System.Drawing.Point(6, 15);
            this.rtb_PlanContent.Name = "rtb_PlanContent";
            this.rtb_PlanContent.Size = new System.Drawing.Size(189, 198);
            this.rtb_PlanContent.TabIndex = 0;
            this.rtb_PlanContent.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "计划种类";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "执行日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "计划标题";
            // 
            // dgv_PlanRegister
            // 
            this.dgv_PlanRegister.AllowUserToAddRows = false;
            this.dgv_PlanRegister.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_PlanRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PlanRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PlanRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PlanRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndivNum,
            this.PlanTitle,
            this.PlanKind,
            this.ExecuteTime,
            this.PlanContent,
            this.DoFlag,
            this.Explain});
            this.dgv_PlanRegister.Location = new System.Drawing.Point(0, 3);
            this.dgv_PlanRegister.Name = "dgv_PlanRegister";
            this.dgv_PlanRegister.RowHeadersVisible = false;
            this.dgv_PlanRegister.RowHeadersWidth = 62;
            this.dgv_PlanRegister.RowTemplate.Height = 23;
            this.dgv_PlanRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PlanRegister.Size = new System.Drawing.Size(462, 402);
            this.dgv_PlanRegister.TabIndex = 0;
            // 
            // IndivNum
            // 
            this.IndivNum.DataPropertyName = "IndivNum";
            this.IndivNum.HeaderText = "序号";
            this.IndivNum.MinimumWidth = 8;
            this.IndivNum.Name = "IndivNum";
            this.IndivNum.Visible = false;
            this.IndivNum.Width = 150;
            // 
            // PlanTitle
            // 
            this.PlanTitle.DataPropertyName = "PlanTitle";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PlanTitle.DefaultCellStyle = dataGridViewCellStyle2;
            this.PlanTitle.HeaderText = "计划标题";
            this.PlanTitle.MinimumWidth = 8;
            this.PlanTitle.Name = "PlanTitle";
            this.PlanTitle.ReadOnly = true;
            this.PlanTitle.Width = 80;
            // 
            // PlanKind
            // 
            this.PlanKind.DataPropertyName = "PlanKind";
            this.PlanKind.HeaderText = "计划种类";
            this.PlanKind.MinimumWidth = 8;
            this.PlanKind.Name = "PlanKind";
            this.PlanKind.ReadOnly = true;
            this.PlanKind.Width = 150;
            // 
            // ExecuteTime
            // 
            this.ExecuteTime.DataPropertyName = "ExecuteTime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ExecuteTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExecuteTime.HeaderText = "执行日期";
            this.ExecuteTime.MinimumWidth = 8;
            this.ExecuteTime.Name = "ExecuteTime";
            this.ExecuteTime.ReadOnly = true;
            this.ExecuteTime.Width = 150;
            // 
            // PlanContent
            // 
            this.PlanContent.DataPropertyName = "PlanContent";
            this.PlanContent.HeaderText = "计划内容";
            this.PlanContent.MinimumWidth = 8;
            this.PlanContent.Name = "PlanContent";
            this.PlanContent.ReadOnly = true;
            this.PlanContent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlanContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PlanContent.Width = 180;
            // 
            // DoFlag
            // 
            this.DoFlag.DataPropertyName = "DoFlag";
            this.DoFlag.HeaderText = "计划是否处理";
            this.DoFlag.MinimumWidth = 8;
            this.DoFlag.Name = "DoFlag";
            this.DoFlag.Visible = false;
            this.DoFlag.Width = 150;
            // 
            // Explain
            // 
            this.Explain.DataPropertyName = "Explain";
            this.Explain.HeaderText = "说明";
            this.Explain.MinimumWidth = 8;
            this.Explain.Name = "Explain";
            this.Explain.Visible = false;
            this.Explain.Width = 150;
            // 
            // panel_PlanStat
            // 
            this.panel_PlanStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_PlanStat.Controls.Add(this.dgv_PlanStat);
            this.panel_PlanStat.Controls.Add(this.label19);
            this.panel_PlanStat.Controls.Add(this.label15);
            this.panel_PlanStat.Controls.Add(this.rb_UnDoFlag);
            this.panel_PlanStat.Controls.Add(this.label11);
            this.panel_PlanStat.Controls.Add(this.rb_DoFlag);
            this.panel_PlanStat.Controls.Add(this.button5);
            this.panel_PlanStat.Location = new System.Drawing.Point(51, 15);
            this.panel_PlanStat.Name = "panel_PlanStat";
            this.panel_PlanStat.Size = new System.Drawing.Size(675, 182);
            this.panel_PlanStat.TabIndex = 11;
            // 
            // dgv_PlanStat
            // 
            this.dgv_PlanStat.AllowUserToAddRows = false;
            this.dgv_PlanStat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_PlanStat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PlanStat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_PlanStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PlanStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndivNum2,
            this.PlanTitle2,
            this.PlanKind2,
            this.ExecuteTime2,
            this.PlanContent2,
            this.DoFlag2,
            this.Explain2});
            this.dgv_PlanStat.Location = new System.Drawing.Point(-1, -2);
            this.dgv_PlanStat.Name = "dgv_PlanStat";
            this.dgv_PlanStat.RowHeadersVisible = false;
            this.dgv_PlanStat.RowHeadersWidth = 62;
            this.dgv_PlanStat.RowTemplate.Height = 23;
            this.dgv_PlanStat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PlanStat.ShowCellToolTips = false;
            this.dgv_PlanStat.Size = new System.Drawing.Size(483, 403);
            this.dgv_PlanStat.TabIndex = 23;
            // 
            // IndivNum2
            // 
            this.IndivNum2.DataPropertyName = "IndivNum";
            this.IndivNum2.HeaderText = "序号";
            this.IndivNum2.MinimumWidth = 8;
            this.IndivNum2.Name = "IndivNum2";
            this.IndivNum2.ReadOnly = true;
            this.IndivNum2.Visible = false;
            this.IndivNum2.Width = 150;
            // 
            // PlanTitle2
            // 
            this.PlanTitle2.DataPropertyName = "PlanTitle";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PlanTitle2.DefaultCellStyle = dataGridViewCellStyle5;
            this.PlanTitle2.HeaderText = "计划标题";
            this.PlanTitle2.MinimumWidth = 8;
            this.PlanTitle2.Name = "PlanTitle2";
            this.PlanTitle2.ReadOnly = true;
            this.PlanTitle2.Width = 80;
            // 
            // PlanKind2
            // 
            this.PlanKind2.DataPropertyName = "PlanKind";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PlanKind2.DefaultCellStyle = dataGridViewCellStyle6;
            this.PlanKind2.HeaderText = "计划种类";
            this.PlanKind2.MinimumWidth = 8;
            this.PlanKind2.Name = "PlanKind2";
            this.PlanKind2.ReadOnly = true;
            this.PlanKind2.Width = 150;
            // 
            // ExecuteTime2
            // 
            this.ExecuteTime2.DataPropertyName = "ExecuteTime";
            this.ExecuteTime2.HeaderText = "执行日期";
            this.ExecuteTime2.MinimumWidth = 8;
            this.ExecuteTime2.Name = "ExecuteTime2";
            this.ExecuteTime2.ReadOnly = true;
            this.ExecuteTime2.Width = 150;
            // 
            // PlanContent2
            // 
            this.PlanContent2.DataPropertyName = "PlanContent";
            this.PlanContent2.HeaderText = "计划内容";
            this.PlanContent2.MinimumWidth = 8;
            this.PlanContent2.Name = "PlanContent2";
            this.PlanContent2.ReadOnly = true;
            this.PlanContent2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlanContent2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PlanContent2.Width = 170;
            // 
            // DoFlag2
            // 
            this.DoFlag2.DataPropertyName = "DoFlag";
            this.DoFlag2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DoFlag2.HeaderText = "是否按期执行";
            this.DoFlag2.MinimumWidth = 8;
            this.DoFlag2.Name = "DoFlag2";
            this.DoFlag2.Width = 150;
            // 
            // Explain2
            // 
            this.Explain2.DataPropertyName = "Explain";
            this.Explain2.HeaderText = "执行说明";
            this.Explain2.MinimumWidth = 8;
            this.Explain2.Name = "Explain2";
            this.Explain2.Width = 150;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.Green;
            this.label19.Location = new System.Drawing.Point(491, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(255, 18);
            this.label19.TabIndex = 22;
            this.label19.Text = "注：统计本年的计划执行情况";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(488, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 2);
            this.label15.TabIndex = 21;
            // 
            // rb_UnDoFlag
            // 
            this.rb_UnDoFlag.AutoSize = true;
            this.rb_UnDoFlag.Location = new System.Drawing.Point(493, 54);
            this.rb_UnDoFlag.Name = "rb_UnDoFlag";
            this.rb_UnDoFlag.Size = new System.Drawing.Size(177, 22);
            this.rb_UnDoFlag.TabIndex = 4;
            this.rb_UnDoFlag.Text = "未按期执行的计划";
            this.rb_UnDoFlag.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(488, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 2);
            this.label11.TabIndex = 20;
            // 
            // rb_DoFlag
            // 
            this.rb_DoFlag.AutoSize = true;
            this.rb_DoFlag.Checked = true;
            this.rb_DoFlag.Location = new System.Drawing.Point(493, 28);
            this.rb_DoFlag.Name = "rb_DoFlag";
            this.rb_DoFlag.Size = new System.Drawing.Size(177, 22);
            this.rb_DoFlag.TabIndex = 5;
            this.rb_DoFlag.TabStop = true;
            this.rb_DoFlag.Text = "已按期执行的计划";
            this.rb_DoFlag.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(607, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "查询";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "确  定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nud_TimeInterval
            // 
            this.nud_TimeInterval.DecimalPlaces = 2;
            this.nud_TimeInterval.Location = new System.Drawing.Point(105, 267);
            this.nud_TimeInterval.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nud_TimeInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_TimeInterval.Name = "nud_TimeInterval";
            this.nud_TimeInterval.Size = new System.Drawing.Size(108, 28);
            this.nud_TimeInterval.TabIndex = 11;
            this.nud_TimeInterval.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lab_AutoRetrieve
            // 
            this.lab_AutoRetrieve.AutoSize = true;
            this.lab_AutoRetrieve.Location = new System.Drawing.Point(49, 165);
            this.lab_AutoRetrieve.Name = "lab_AutoRetrieve";
            this.lab_AutoRetrieve.Size = new System.Drawing.Size(692, 18);
            this.lab_AutoRetrieve.TabIndex = 10;
            this.lab_AutoRetrieve.Text = "若打开这个功能，则软件运行后会自动检查最近几天的计划任务，以达到提醒的效果。";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(15, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(620, 2);
            this.label6.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(15, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(620, 2);
            this.label5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "小时提醒一次";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "每隔";
            // 
            // chb_IsTimeCue
            // 
            this.chb_IsTimeCue.AutoSize = true;
            this.chb_IsTimeCue.Checked = true;
            this.chb_IsTimeCue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_IsTimeCue.Location = new System.Drawing.Point(22, 234);
            this.chb_IsTimeCue.Name = "chb_IsTimeCue";
            this.chb_IsTimeCue.Size = new System.Drawing.Size(106, 22);
            this.chb_IsTimeCue.TabIndex = 4;
            this.chb_IsTimeCue.Text = "实时提醒";
            this.chb_IsTimeCue.UseVisualStyleBackColor = true;
            // 
            // chb_IsAutoCheck
            // 
            this.chb_IsAutoCheck.AutoSize = true;
            this.chb_IsAutoCheck.Checked = true;
            this.chb_IsAutoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_IsAutoCheck.Location = new System.Drawing.Point(22, 128);
            this.chb_IsAutoCheck.Name = "chb_IsAutoCheck";
            this.chb_IsAutoCheck.Size = new System.Drawing.Size(286, 22);
            this.chb_IsAutoCheck.TabIndex = 3;
            this.chb_IsAutoCheck.Text = "系统启动自动检查最近计划任务";
            this.chb_IsAutoCheck.UseVisualStyleBackColor = true;
            // 
            // lab_Days
            // 
            this.lab_Days.AutoSize = true;
            this.lab_Days.Location = new System.Drawing.Point(49, 65);
            this.lab_Days.Name = "lab_Days";
            this.lab_Days.Size = new System.Drawing.Size(791, 18);
            this.lab_Days.TabIndex = 2;
            this.lab_Days.Text = "例如，若设置提前提醒天数为3，则在计划设定的前3天进行提醒，前3天每次启动计算机都会提醒。";
            // 
            // nud_Days
            // 
            this.nud_Days.Location = new System.Drawing.Point(105, 21);
            this.nud_Days.Name = "nud_Days";
            this.nud_Days.Size = new System.Drawing.Size(108, 28);
            this.nud_Days.TabIndex = 1;
            this.nud_Days.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "提前提醒天数";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 595);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_PlanRegister.ResumeLayout(false);
            this.panel_PlanRegister.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlanRegister)).EndInit();
            this.panel_PlanStat.ResumeLayout(false);
            this.panel_PlanStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PlanStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TimeInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Days)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel_PlanRegister;
        private System.Windows.Forms.ComboBox cbox_PlanKind;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtp_ExecuteTime;
        private System.Windows.Forms.TextBox txt_PlanTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtb_PlanContent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_PlanRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndivNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecuteTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explain;
        private System.Windows.Forms.Panel panel_PlanStat;
        public System.Windows.Forms.DataGridView dgv_PlanStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndivNum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanTitle2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanKind2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecuteTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanContent2;
        private System.Windows.Forms.DataGridViewComboBoxColumn DoFlag2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explain2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rb_UnDoFlag;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rb_DoFlag;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nud_TimeInterval;
        private System.Windows.Forms.Label lab_AutoRetrieve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chb_IsTimeCue;
        private System.Windows.Forms.CheckBox chb_IsAutoCheck;
        private System.Windows.Forms.Label lab_Days;
        private System.Windows.Forms.NumericUpDown nud_Days;
        private System.Windows.Forms.Label label1;
    }
}