namespace book
{
    partial class FrmDataOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataOut));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cdreturn = new System.Windows.Forms.RadioButton();
            this.bookreturn = new System.Windows.Forms.RadioButton();
            this.cdbad = new System.Windows.Forms.RadioButton();
            this.bookbad = new System.Windows.Forms.RadioButton();
            this.cdback = new System.Windows.Forms.RadioButton();
            this.bookback = new System.Windows.Forms.RadioButton();
            this.cdsale = new System.Windows.Forms.RadioButton();
            this.booksale = new System.Windows.Forms.RadioButton();
            this.provider = new System.Windows.Forms.RadioButton();
            this.vip = new System.Windows.Forms.RadioButton();
            this.cdinfo = new System.Windows.Forms.RadioButton();
            this.bookinfo = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cdreturn);
            this.groupBox1.Controls.Add(this.bookreturn);
            this.groupBox1.Controls.Add(this.cdbad);
            this.groupBox1.Controls.Add(this.bookbad);
            this.groupBox1.Controls.Add(this.cdback);
            this.groupBox1.Controls.Add(this.bookback);
            this.groupBox1.Controls.Add(this.cdsale);
            this.groupBox1.Controls.Add(this.booksale);
            this.groupBox1.Controls.Add(this.provider);
            this.groupBox1.Controls.Add(this.vip);
            this.groupBox1.Controls.Add(this.cdinfo);
            this.groupBox1.Controls.Add(this.bookinfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "能导出的数据";
            // 
            // cdreturn
            // 
            this.cdreturn.AutoSize = true;
            this.cdreturn.Location = new System.Drawing.Point(401, 125);
            this.cdreturn.Name = "cdreturn";
            this.cdreturn.Size = new System.Drawing.Size(143, 16);
            this.cdreturn.TabIndex = 11;
            this.cdreturn.Text = "导出客户退还光盘信息";
            this.cdreturn.UseVisualStyleBackColor = true;
            // 
            // bookreturn
            // 
            this.bookreturn.AutoSize = true;
            this.bookreturn.Location = new System.Drawing.Point(401, 94);
            this.bookreturn.Name = "bookreturn";
            this.bookreturn.Size = new System.Drawing.Size(143, 16);
            this.bookreturn.TabIndex = 10;
            this.bookreturn.Text = "导出客户退还图书信息";
            this.bookreturn.UseVisualStyleBackColor = true;
            // 
            // cdbad
            // 
            this.cdbad.AutoSize = true;
            this.cdbad.Location = new System.Drawing.Point(401, 63);
            this.cdbad.Name = "cdbad";
            this.cdbad.Size = new System.Drawing.Size(119, 16);
            this.cdbad.TabIndex = 9;
            this.cdbad.Text = "导出光盘损坏信息";
            this.cdbad.UseVisualStyleBackColor = true;
            // 
            // bookbad
            // 
            this.bookbad.AutoSize = true;
            this.bookbad.Location = new System.Drawing.Point(401, 32);
            this.bookbad.Name = "bookbad";
            this.bookbad.Size = new System.Drawing.Size(119, 16);
            this.bookbad.TabIndex = 8;
            this.bookbad.Text = "导出图书损坏信息";
            this.bookbad.UseVisualStyleBackColor = true;
            // 
            // cdback
            // 
            this.cdback.AutoSize = true;
            this.cdback.Location = new System.Drawing.Point(215, 125);
            this.cdback.Name = "cdback";
            this.cdback.Size = new System.Drawing.Size(119, 16);
            this.cdback.TabIndex = 7;
            this.cdback.Text = "导出光盘退货信息";
            this.cdback.UseVisualStyleBackColor = true;
            // 
            // bookback
            // 
            this.bookback.AutoSize = true;
            this.bookback.Location = new System.Drawing.Point(215, 94);
            this.bookback.Name = "bookback";
            this.bookback.Size = new System.Drawing.Size(119, 16);
            this.bookback.TabIndex = 6;
            this.bookback.Text = "导出图书退货信息";
            this.bookback.UseVisualStyleBackColor = true;
            // 
            // cdsale
            // 
            this.cdsale.AutoSize = true;
            this.cdsale.Location = new System.Drawing.Point(215, 63);
            this.cdsale.Name = "cdsale";
            this.cdsale.Size = new System.Drawing.Size(119, 16);
            this.cdsale.TabIndex = 5;
            this.cdsale.Text = "导出光盘销售信息";
            this.cdsale.UseVisualStyleBackColor = true;
            // 
            // booksale
            // 
            this.booksale.AutoSize = true;
            this.booksale.Location = new System.Drawing.Point(215, 32);
            this.booksale.Name = "booksale";
            this.booksale.Size = new System.Drawing.Size(119, 16);
            this.booksale.TabIndex = 4;
            this.booksale.Text = "导出图书销售信息";
            this.booksale.UseVisualStyleBackColor = true;
            // 
            // provider
            // 
            this.provider.AutoSize = true;
            this.provider.Location = new System.Drawing.Point(34, 125);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(107, 16);
            this.provider.TabIndex = 3;
            this.provider.Text = "导出供应商信息";
            this.provider.UseVisualStyleBackColor = true;
            // 
            // vip
            // 
            this.vip.AutoSize = true;
            this.vip.Location = new System.Drawing.Point(34, 94);
            this.vip.Name = "vip";
            this.vip.Size = new System.Drawing.Size(95, 16);
            this.vip.TabIndex = 2;
            this.vip.Text = "导出会员信息";
            this.vip.UseVisualStyleBackColor = true;
            // 
            // cdinfo
            // 
            this.cdinfo.AutoSize = true;
            this.cdinfo.Location = new System.Drawing.Point(34, 63);
            this.cdinfo.Name = "cdinfo";
            this.cdinfo.Size = new System.Drawing.Size(95, 16);
            this.cdinfo.TabIndex = 1;
            this.cdinfo.Text = "导出光盘信息";
            this.cdinfo.UseVisualStyleBackColor = true;
            // 
            // bookinfo
            // 
            this.bookinfo.AutoSize = true;
            this.bookinfo.Location = new System.Drawing.Point(34, 32);
            this.bookinfo.Name = "bookinfo";
            this.bookinfo.Size = new System.Drawing.Size(95, 16);
            this.bookinfo.TabIndex = 0;
            this.bookinfo.Text = "导出图书信息";
            this.bookinfo.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xls";
            this.saveFileDialog1.Filter = "Excel文件|*.xls|所有文件|*.*";
            // 
            // dataout
            // 
            this.dataout.Location = new System.Drawing.Point(105, 190);
            this.dataout.Name = "dataout";
            this.dataout.Size = new System.Drawing.Size(115, 32);
            this.dataout.TabIndex = 4;
            this.dataout.Text = "导出";
            this.dataout.UseVisualStyleBackColor = true;
            this.dataout.Click += new System.EventHandler(this.dataout_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmDataOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 242);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataout);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDataOut";
            this.Text = "数据导出";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button dataout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton bookbad;
        private System.Windows.Forms.RadioButton cdback;
        private System.Windows.Forms.RadioButton bookback;
        private System.Windows.Forms.RadioButton cdsale;
        private System.Windows.Forms.RadioButton booksale;
        private System.Windows.Forms.RadioButton provider;
        private System.Windows.Forms.RadioButton vip;
        private System.Windows.Forms.RadioButton cdinfo;
        private System.Windows.Forms.RadioButton bookinfo;
        private System.Windows.Forms.RadioButton cdreturn;
        private System.Windows.Forms.RadioButton bookreturn;
        private System.Windows.Forms.RadioButton cdbad;
    }
}