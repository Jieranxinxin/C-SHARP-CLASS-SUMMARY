namespace 桌面提醒
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.pic_min = new System.Windows.Forms.PictureBox();
            this.pic_Colse = new System.Windows.Forms.PictureBox();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel_Fill = new System.Windows.Forms.Panel();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Colse)).BeginInit();
            this.panel_Fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Top.Controls.Add(this.pic_min);
            this.panel_Top.Controls.Add(this.pic_Colse);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(500, 38);
            this.panel_Top.TabIndex = 0;
            // 
            // pic_min
            // 
            this.pic_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_min.Image = ((System.Drawing.Image)(resources.GetObject("pic_min.Image")));
            this.pic_min.Location = new System.Drawing.Point(418, 0);
            this.pic_min.Name = "pic_min";
            this.pic_min.Size = new System.Drawing.Size(38, 38);
            this.pic_min.TabIndex = 0;
            this.pic_min.TabStop = false;
            this.pic_min.Click += new System.EventHandler(this.pic_min_Click);
            // 
            // pic_Colse
            // 
            this.pic_Colse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Colse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Colse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Colse.Image = ((System.Drawing.Image)(resources.GetObject("pic_Colse.Image")));
            this.pic_Colse.Location = new System.Drawing.Point(462, 0);
            this.pic_Colse.Name = "pic_Colse";
            this.pic_Colse.Size = new System.Drawing.Size(38, 38);
            this.pic_Colse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Colse.TabIndex = 1;
            this.pic_Colse.TabStop = false;
            this.pic_Colse.Click += new System.EventHandler(this.pic_Colse_Click);
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 38);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(12, 262);
            this.panel_Left.TabIndex = 1;
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(488, 38);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(12, 262);
            this.panel_Right.TabIndex = 2;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 250);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(488, 12);
            this.panel_Bottom.TabIndex = 2;
            // 
            // panel_Fill
            // 
            this.panel_Fill.Controls.Add(this.panel_Bottom);
            this.panel_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Fill.Location = new System.Drawing.Point(12, 38);
            this.panel_Fill.Name = "panel_Fill";
            this.panel_Fill.Size = new System.Drawing.Size(488, 262);
            this.panel_Fill.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Fill);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Colse)).EndInit();
            this.panel_Fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Panel panel_Fill;
        private System.Windows.Forms.PictureBox pic_Colse;
        private System.Windows.Forms.PictureBox pic_min;
    }
}

