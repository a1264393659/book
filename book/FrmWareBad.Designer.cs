﻿namespace book
{
    partial class FrmWareBad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWareBad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.memo = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.all = new System.Windows.Forms.Button();
            this.query = new System.Windows.Forms.Button();
            this.bookcase = new System.Windows.Forms.ComboBox();
            this.publish = new System.Windows.Forms.ComboBox();
            this.style = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cd = new System.Windows.Forms.RadioButton();
            this.book = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 253);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.memo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.count);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 72);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "商品损坏";
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(222, 28);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(406, 21);
            this.memo.TabIndex = 5;
            this.memo.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "备注：";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(748, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "取 消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(645, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "确 定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(83, 28);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(78, 21);
            this.count.TabIndex = 1;
            this.count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.count_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "损坏数量：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isbn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.all);
            this.groupBox1.Controls.Add(this.query);
            this.groupBox1.Controls.Add(this.bookcase);
            this.groupBox1.Controls.Add(this.publish);
            this.groupBox1.Controls.Add(this.style);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品查询";
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(538, 126);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(164, 41);
            this.all.TabIndex = 10;
            this.all.Text = "显示全部";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(146, 126);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(164, 41);
            this.query.TabIndex = 9;
            this.query.Text = "查  询";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // bookcase
            // 
            this.bookcase.FormattingEnabled = true;
            this.bookcase.Location = new System.Drawing.Point(667, 84);
            this.bookcase.Name = "bookcase";
            this.bookcase.Size = new System.Drawing.Size(172, 20);
            this.bookcase.TabIndex = 8;
            this.bookcase.DropDown += new System.EventHandler(this.bookcase_DropDown);
            // 
            // publish
            // 
            this.publish.FormattingEnabled = true;
            this.publish.Location = new System.Drawing.Point(259, 84);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(159, 20);
            this.publish.TabIndex = 7;
            this.publish.DropDown += new System.EventHandler(this.publish_DropDown);
            // 
            // style
            // 
            this.style.FormattingEnabled = true;
            this.style.Location = new System.Drawing.Point(71, 84);
            this.style.Name = "style";
            this.style.Size = new System.Drawing.Size(135, 20);
            this.style.TabIndex = 6;
            this.style.DropDown += new System.EventHandler(this.style_DropDown);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(667, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(172, 21);
            this.name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "所在书架：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "出版社：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品名称：";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cd);
            this.panel2.Controls.Add(this.book);
            this.panel2.Location = new System.Drawing.Point(11, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 42);
            this.panel2.TabIndex = 0;
            // 
            // cd
            // 
            this.cd.AutoSize = true;
            this.cd.Location = new System.Drawing.Point(231, 12);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(47, 16);
            this.cd.TabIndex = 1;
            this.cd.Text = "光盘";
            this.cd.UseVisualStyleBackColor = true;
            // 
            // book
            // 
            this.book.AutoSize = true;
            this.book.Checked = true;
            this.book.Location = new System.Drawing.Point(43, 12);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(47, 16);
            this.book.TabIndex = 0;
            this.book.TabStop = true;
            this.book.Text = "图书";
            this.book.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 253);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(849, 315);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "商品编号：";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(427, 36);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(160, 21);
            this.id.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "ISBN：";
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(463, 84);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(136, 21);
            this.isbn.TabIndex = 14;
            // 
            // FrmWareBad
            // 
            this.AcceptButton = this.query;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWareBad";
            this.Text = "商品损坏";
            this.Load += new System.EventHandler(this.FrmWareBad_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.Button query;
        private System.Windows.Forms.ComboBox bookcase;
        private System.Windows.Forms.ComboBox publish;
        private System.Windows.Forms.ComboBox style;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton cd;
        private System.Windows.Forms.RadioButton book;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox memo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label7;

    }
}