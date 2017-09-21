namespace book
{
    partial class FrmDataIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataIn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.provider = new System.Windows.Forms.RadioButton();
            this.vipinfo = new System.Windows.Forms.RadioButton();
            this.cdinfo = new System.Windows.Forms.RadioButton();
            this.bookinfo = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.small = new System.Windows.Forms.RadioButton();
            this.big = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.provider);
            this.groupBox1.Controls.Add(this.vipinfo);
            this.groupBox1.Controls.Add(this.cdinfo);
            this.groupBox1.Controls.Add(this.bookinfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类型";
            // 
            // provider
            // 
            this.provider.AutoSize = true;
            this.provider.Location = new System.Drawing.Point(198, 66);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(107, 16);
            this.provider.TabIndex = 4;
            this.provider.Text = "导入供应商信息";
            this.provider.UseVisualStyleBackColor = true;
            this.provider.CheckedChanged += new System.EventHandler(this.provider_CheckedChanged);
            // 
            // vipinfo
            // 
            this.vipinfo.AutoSize = true;
            this.vipinfo.Location = new System.Drawing.Point(198, 30);
            this.vipinfo.Name = "vipinfo";
            this.vipinfo.Size = new System.Drawing.Size(95, 16);
            this.vipinfo.TabIndex = 3;
            this.vipinfo.Text = "导入会员信息";
            this.vipinfo.UseVisualStyleBackColor = true;
            this.vipinfo.CheckedChanged += new System.EventHandler(this.vipinfo_CheckedChanged);
            // 
            // cdinfo
            // 
            this.cdinfo.AutoSize = true;
            this.cdinfo.Location = new System.Drawing.Point(45, 66);
            this.cdinfo.Name = "cdinfo";
            this.cdinfo.Size = new System.Drawing.Size(95, 16);
            this.cdinfo.TabIndex = 1;
            this.cdinfo.Text = "导入光盘信息";
            this.cdinfo.UseVisualStyleBackColor = true;
            this.cdinfo.CheckedChanged += new System.EventHandler(this.cdinfo_CheckedChanged);
            // 
            // bookinfo
            // 
            this.bookinfo.AutoSize = true;
            this.bookinfo.Location = new System.Drawing.Point(45, 30);
            this.bookinfo.Name = "bookinfo";
            this.bookinfo.Size = new System.Drawing.Size(95, 16);
            this.bookinfo.TabIndex = 0;
            this.bookinfo.Text = "导入图书信息";
            this.bookinfo.UseVisualStyleBackColor = true;
            this.bookinfo.CheckedChanged += new System.EventHandler(this.bookinfo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 48);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(215, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "导入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.big);
            this.groupBox2.Controls.Add(this.small);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel版本";
            // 
            // small
            // 
            this.small.AutoSize = true;
            this.small.Checked = true;
            this.small.Location = new System.Drawing.Point(59, 21);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(143, 16);
            this.small.TabIndex = 0;
            this.small.TabStop = true;
            this.small.Text = "Excel 2003或更低版本";
            this.small.UseVisualStyleBackColor = true;
            // 
            // big
            // 
            this.big.AutoSize = true;
            this.big.Location = new System.Drawing.Point(208, 21);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(83, 16);
            this.big.TabIndex = 1;
            this.big.Text = "Excel 2007";
            this.big.UseVisualStyleBackColor = true;
            // 
            // FrmDataIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 204);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDataIn";
            this.Text = "数据导入";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton provider;
        private System.Windows.Forms.RadioButton vipinfo;
        private System.Windows.Forms.RadioButton cdinfo;
        private System.Windows.Forms.RadioButton bookinfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton big;
        private System.Windows.Forms.RadioButton small;
    }
}