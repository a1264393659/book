using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MD5Method;

namespace book
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)//退出系统
        {
            this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        /// <summary>
        /// 获取用户的类型
        /// </summary>
        /// <returns>返回用户类型</returns>
        public string GetUserStyle()
        {
            return this.comboBox1.Text.Trim();
        }

        /// <summary>
        /// 获取用户名
        /// </summary>
        /// <returns>返回登录者的用户名称</returns>
        public string GetUser()
        {
            return this.textBox1.Text;
        }

        private void Ok_Click(object sender, EventArgs e)//登录系统
        {
            SqlConnection connect = InitConnect.GetConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from book_user where user_id=@user and user_pwd=@pwd and user_style=@style",connect);
            cmd.Parameters.AddWithValue("@user",this.textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@pwd",MD5.MD5String(this.textBox2.Text.Trim()));
            cmd.Parameters.AddWithValue("@style",this.comboBox1.Text.Trim());
            int count = int.Parse(cmd.ExecuteScalar().ToString());
            if (count != 0)
            {
                UserInfo.UserID = this.textBox1.Text.Trim();
                UserInfo.UserPower = this.comboBox1.Text.Trim();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名或密码错误！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
                this.comboBox1.Focus();
                this.textBox1.SelectAll();
                this.textBox2.Text = "";
            }
            connect.Close();
        }
        private void DisplayStyle()//列出所有用户的类型
        {
            SqlConnection connect = InitConnect.GetConnection();
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from user_style",connect);
            adapter.Fill(data,"user_style");
            this.comboBox1.DataSource = data.Tables["user_style"];
            this.comboBox1.DisplayMember = "userstyle_name";
            this.comboBox1.ValueMember = "userstyle_name";
        }

        private void FrmLogin_Load(object sender, EventArgs e)//初始化
        {
            this.DisplayStyle();//显示用户类型
        }

        private int OffSetX, OffSetY;
        private bool IsDown=false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)//鼠标按下
        {
            OffSetX = e.X;
            OffSetY = e.Y;
            IsDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)//鼠标弹起
        {
            IsDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)//鼠标移动
        {
            if (IsDown)
            {
                this.Left = this.Left + e.X - OffSetX;
                this.Top = this.Top + e.Y - OffSetY;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}