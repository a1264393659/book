﻿namespace book
{
    partial class FrmSaleQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleQuery));
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cdsale = new System.Windows.Forms.RadioButton();
            this.booksale = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn4 = new System.Windows.Forms.RadioButton();
            this.btn3 = new System.Windows.Forms.RadioButton();
            this.btn2 = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.direct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.range2 = new System.Windows.Forms.DateTimePicker();
            this.range1 = new System.Windows.Forms.DateTimePicker();
            this.author = new System.Windows.Forms.TextBox();
            this.publish = new System.Windows.Forms.ComboBox();
            this.style = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.queryresult = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(0, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(280, 12);
            this.label15.TabIndex = 44;
            this.label15.Text = "    注意：该查询只能选中一项作为查询条件。";
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(849, 49);
            this.label13.TabIndex = 36;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cdsale);
            this.groupBox1.Controls.Add(this.booksale);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 51);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // cdsale
            // 
            this.cdsale.AutoSize = true;
            this.cdsale.Location = new System.Drawing.Point(421, 20);
            this.cdsale.Name = "cdsale";
            this.cdsale.Size = new System.Drawing.Size(119, 16);
            this.cdsale.TabIndex = 0;
            this.cdsale.Text = "光盘销售情况查询";
            this.cdsale.UseVisualStyleBackColor = true;
            // 
            // booksale
            // 
            this.booksale.AutoSize = true;
            this.booksale.Checked = true;
            this.booksale.Location = new System.Drawing.Point(106, 20);
            this.booksale.Name = "booksale";
            this.booksale.Size = new System.Drawing.Size(119, 16);
            this.booksale.TabIndex = 0;
            this.booksale.TabStop = true;
            this.booksale.Text = "图书销售情况查询";
            this.booksale.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.result.Font = new System.Drawing.Font("楷体_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.ForeColor = System.Drawing.Color.Red;
            this.result.Location = new System.Drawing.Point(0, 537);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(849, 31);
            this.result.TabIndex = 46;
            this.result.Text = "---统计结果在此显示---";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn4);
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.direct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.range2);
            this.groupBox2.Controls.Add(this.range1);
            this.groupBox2.Controls.Add(this.author);
            this.groupBox2.Controls.Add(this.publish);
            this.groupBox2.Controls.Add(this.style);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 129);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询条件";
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Location = new System.Drawing.Point(443, 61);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(14, 13);
            this.btn4.TabIndex = 62;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(51, 61);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(14, 13);
            this.btn3.TabIndex = 61;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(443, 25);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(14, 13);
            this.btn2.TabIndex = 60;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Checked = true;
            this.btn1.Location = new System.Drawing.Point(51, 25);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(14, 13);
            this.btn1.TabIndex = 59;
            this.btn1.TabStop = true;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // direct
            // 
            this.direct.Location = new System.Drawing.Point(577, 95);
            this.direct.Name = "direct";
            this.direct.Size = new System.Drawing.Size(44, 22);
            this.direct.TabIndex = 56;
            this.direct.Text = "<--";
            this.direct.UseVisualStyleBackColor = true;
            this.direct.Click += new System.EventHandler(this.direct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 55;
            this.label6.Text = "<------------>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 54;
            this.label5.Text = "时间段：";
            // 
            // range2
            // 
            this.range2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.range2.Location = new System.Drawing.Point(415, 96);
            this.range2.Name = "range2";
            this.range2.Size = new System.Drawing.Size(157, 21);
            this.range2.TabIndex = 53;
            this.range2.ValueChanged += new System.EventHandler(this.range1_ValueChanged);
            // 
            // range1
            // 
            this.range1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.range1.Location = new System.Drawing.Point(123, 96);
            this.range1.Name = "range1";
            this.range1.Size = new System.Drawing.Size(157, 21);
            this.range1.TabIndex = 52;
            this.range1.ValueChanged += new System.EventHandler(this.range1_ValueChanged);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(515, 58);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(283, 21);
            this.author.TabIndex = 51;
            // 
            // publish
            // 
            this.publish.FormattingEnabled = true;
            this.publish.Location = new System.Drawing.Point(123, 59);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(283, 20);
            this.publish.TabIndex = 50;
            this.publish.DropDown += new System.EventHandler(this.publish_DropDown);
            // 
            // style
            // 
            this.style.FormattingEnabled = true;
            this.style.Location = new System.Drawing.Point(515, 22);
            this.style.Name = "style";
            this.style.Size = new System.Drawing.Size(283, 20);
            this.style.TabIndex = 49;
            this.style.DropDown += new System.EventHandler(this.style_DropDown);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(123, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(283, 21);
            this.name.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "作者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "出版社：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "商品类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "商品名称：";
            // 
            // queryresult
            // 
            this.queryresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryresult.FullRowSelect = true;
            this.queryresult.GridLines = true;
            this.queryresult.Location = new System.Drawing.Point(0, 241);
            this.queryresult.MultiSelect = false;
            this.queryresult.Name = "queryresult";
            this.queryresult.Size = new System.Drawing.Size(849, 296);
            this.queryresult.TabIndex = 49;
            this.queryresult.UseCompatibleStateImageBehavior = false;
            this.queryresult.View = System.Windows.Forms.View.Details;
            // 
            // FrmSaleQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 568);
            this.Controls.Add(this.queryresult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSaleQuery";
            this.Text = "销售情况查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cdsale;
        private System.Windows.Forms.RadioButton booksale;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btn4;
        private System.Windows.Forms.RadioButton btn3;
        private System.Windows.Forms.RadioButton btn2;
        private System.Windows.Forms.RadioButton btn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button direct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker range2;
        private System.Windows.Forms.DateTimePicker range1;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.ComboBox publish;
        private System.Windows.Forms.ComboBox style;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView queryresult;

    }
}