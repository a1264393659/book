using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;

namespace book
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置用户的权限
        /// </summary>
        private void SetUserPower()
        {
            this.button1.Enabled = false;
            this.menublock1.Enabled = false;
            this.button2.Enabled = false;
            this.menublock2.Enabled = false;
            this.button3.Enabled = false;
            this.menublock3.Enabled = false;
            this.button4.Enabled = false;
            this.menublock4.Enabled = false;
            this.button5.Enabled = false;
            this.menublock5.Enabled = false;
            this.button6.Enabled = false;
            this.menublock6.Enabled = false;
            /////////////////////////////////////////////////////////////////////////////////////////
            SqlConnection connect = InitConnect.GetConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from power where power_style=@style", connect);
            cmd.Parameters.AddWithValue("@style", UserInfo.UserPower);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (read["power_name"].ToString().Trim() == "系统设置")
                {
                    this.button1.Enabled = true;
                    this.menublock1.Enabled = true;
                }
                else if (read["power_name"].ToString().Trim() == "基本资料维护")
                {
                    this.button2.Enabled = true;
                    this.menublock2.Enabled = true;
                }
                else if (read["power_name"].ToString().Trim() == "采购管理")
                {
                    this.button3.Enabled = true;
                    this.menublock3.Enabled = true;
                }
                else if (read["power_name"].ToString().Trim() == "销售管理")
                {
                    this.button4.Enabled = true;
                    this.menublock4.Enabled = true;
                }
                else if (read["power_name"].ToString().Trim() == "库存管理")
                {
                    this.button5.Enabled = true;
                    this.menublock5.Enabled = true;
                }
                else if (read["power_name"].ToString().Trim() == "系统数据管理")
                {
                    this.button6.Enabled = true;
                    this.menublock6.Enabled = true;
                }
            }
            read.Close();
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)//显示你选择的模块
        {
            for (int i = 0; i < this.splitContainer1.Panel1.Controls.Count; i++)
            {
                if (this.splitContainer1.Panel1.Controls[i] is Panel)
                {
                    if ((this.splitContainer1.Panel1.Controls[i] as Panel).Tag.ToString().Trim() == ((Button)sender).Tag.ToString().Trim())
                    {
                        (this.splitContainer1.Panel1.Controls[i] as Panel).Visible = true;
                        (this.splitContainer1.Panel1.Controls[i] as Panel).Height = this.Height - this.button7.Height * (this.splitContainer1.Panel1.Controls.Count / 2) - 144;
                    }
                    else
                    {
                        if ((this.splitContainer1.Panel1.Controls[i] as Panel).Visible)
                        {
                            (this.splitContainer1.Panel1.Controls[i] as Panel).Visible = false;
                        }
                    }
                }
            }
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)//当窗体大小改变时要改变导航的大小
        {
            for (int i = 0; i < this.splitContainer1.Panel1.Controls.Count; i++)
            {
                if (this.splitContainer1.Panel1.Controls[i] is Panel)
                {
                    if ((this.splitContainer1.Panel1.Controls[i] as Panel).Visible)
                    {
                        (this.splitContainer1.Panel1.Controls[i] as Panel).Height = this.Height - this.button7.Height * (this.splitContainer1.Panel1.Controls.Count / 2) - 144;
                    }
                }
            }
        }

        private void init_Click(object sender, EventArgs e)//系统初始化
        {
            FrmInit init = new FrmInit();
            this.ReForm(init.Text,init);
        }

        /// <summary>
        /// 打开窗体,不重复
        /// </summary>
        /// <param name="form">要打开的窗体</param>
        private void ReForm(string title,object form)
        {
            bool exists = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text.Trim() == title.Trim())
                {
                    exists = true;
                    if (this.MdiChildren[i].WindowState == FormWindowState.Minimized)
                    {
                        this.MdiChildren[i].WindowState = FormWindowState.Normal;
                    }
                    this.MdiChildren[i].Activate();
                    break;
                }
            }
            if (exists == false)
            {
                Form temp=(Form)Activator.CreateInstance(form.GetType());
                temp.MdiParent = this;
                temp.Show();
                 
            }
        }

        private void bookstyle_Click(object sender, EventArgs e)//图书类型设置
        {
            FrmBookStyle bookstyle = new FrmBookStyle();
            this.ReForm(bookstyle.Text,bookstyle);
        }

        private void userstyle_Click(object sender, EventArgs e)//用户类型设置
        {
            FrmUserStyle userstyle = new FrmUserStyle();
            this.ReForm(userstyle.Text,userstyle);
        }

        private void 重叠排列ToolStripMenuItem_Click(object sender, EventArgs e)//重叠排列显示
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 水平排列显示ToolStripMenuItem_Click(object sender, EventArgs e)//水平排列显示
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直排列显示ToolStripMenuItem_Click(object sender, EventArgs e)//垂直排列显示
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 并列排列显示ToolStripMenuItem_Click(object sender, EventArgs e)//与窗体并列显示
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void 隐藏导航栏ToolStripMenuItem_Click(object sender, EventArgs e)//隐藏导航栏
        {
            this.splitContainer1.Visible = false;
        }

        private void 显示导航栏ToolStripMenuItem_Click(object sender, EventArgs e)//显示导航栏
        {
            this.splitContainer1.Visible = true;
        }

        private void 关闭当前窗口ToolStripMenuItem_Click(object sender, EventArgs e)//关闭当前窗口
        {
            if (this.ActiveMdiChild!=null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void 关闭所有窗口ToolStripMenuItem_Click(object sender, EventArgs e)//关闭所有窗口
        {
            for (int i = this.MdiChildren.Length-1; i >= 0; i--)
            {
                this.MdiChildren[i].Close();
            }
        }

        private void power_Click(object sender, EventArgs e)//用户权限设置
        {
            FrmUserPower userpower = new FrmUserPower();
            this.ReForm(userpower.Text,userpower);
        }

        private void vipstyle_Click(object sender, EventArgs e)//会员类型设置
        {
            FrmVipStyle vipstyle = new FrmVipStyle();
            this.ReForm(vipstyle.Text,vipstyle);
        }

        private void back_Click(object sender, EventArgs e)//退货期限设置
        {
            FrmReturnDate returndate = new FrmReturnDate();
            this.ReForm(returndate.Text,returndate);
        }

        private void updown_Click(object sender, EventArgs e)//商品上下限设置
        {
            FrmUpdown updown = new FrmUpdown();
            this.ReForm(updown.Text,updown);
        }

        private void logout_Click(object sender, EventArgs e)//注销系统
        {
            if (MessageBox.Show("你确定要注销账户吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    this.FrmMain_Load(sender,e);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)//退出系统
        {
            Application.Exit();
        }

        /// <summary>
        /// 检查是否有越界商品,如果有弹出警告窗口
        /// </summary>
        private void CheckWareUpDown()
        {
            if (InitConnect.GetWareDown(true) != "0" || InitConnect.GetWareDown(false) != "0" || InitConnect.GetWareUp(true) != "0" || InitConnect.GetWareUp(false) != "0")
            {
                FrmWarning warning = new FrmWarning();
                warning.Show();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)//初始化
        {
            this.SetUserPower();
            //////////////////////////////////////////////////////////////////
            this.CheckWareUpDown();
            ///////////////////////////////////////////////////////////////////////
            this.timer1.Enabled = true;
            this.toolStripStatusLabel2.Text = "     用户类型：" + UserInfo.UserPower +"     ";
            this.toolStripStatusLabel3.Text = "     用户名称：" + UserInfo.UserID + "     ";
            this.toolStripStatusLabel4.Text = "     当前时间：" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + "     ";
            ////////////////////////////////////////////////初始显示退出登录模块
            this.panel1.Visible = false;
            this.panel2.Visible = false;
            this.panel3.Visible = false;
            this.panel4.Visible = false;
            this.panel5.Visible = false;
            this.panel6.Visible = false;
            this.panel7.Visible = true;
            this.panel7.Height = this.Height - this.button2.Height * (this.splitContainer1.Panel1.Controls.Count / 2) - 84;
        }

        private void timer1_Tick(object sender, EventArgs e)//显示时间
        {
            this.toolStripStatusLabel4.Text = "     当前时间：" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + "     ";
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)//当窗体关闭的时候关闭定时器
        {
            if (MessageBox.Show("你确定要退出系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.timer1.Enabled = false;
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void provider_Click(object sender, EventArgs e)//供应商信息管理
        {
            FrmProvider provider = new FrmProvider();
            this.ReForm(provider.Text,provider);
        }

        private void publish_Click(object sender, EventArgs e)//出版社信息管理
        {
            FrmPublish publish = new FrmPublish();
            this.ReForm(publish.Text,publish);
        }

        private void bookcase_Click(object sender, EventArgs e)//书架信息管理
        {
            FrmBookcase bookcase = new FrmBookcase();
            this.ReForm(bookcase.Text,bookcase);
        }

        private void vip_Click(object sender, EventArgs e)//会员信息管理
        {
            FrmVip vip = new FrmVip();
            this.ReForm(vip.Text,vip);
        }

        private void user_Click(object sender, EventArgs e)//用户信息管理
        {
            FrmUser user = new FrmUser();
            this.ReForm(user.Text,user);
        }

        private void bookin_Click(object sender, EventArgs e)//商品入库
        {
            FrmBookIn bookin = new FrmBookIn();
            this.ReForm(bookin.Text,bookin);
        }

        private void bookback_Click(object sender, EventArgs e)//商品退还管理
        {
            FrmBookBack bookback = new FrmBookBack();
            this.ReForm(bookback.Text,bookback);
        }

        private void bookquery_Click(object sender, EventArgs e)//图书信息查询
        {
            FrmQueryBook querybook = new FrmQueryBook();
            this.ReForm(querybook.Text,querybook);
        }

        private void sale_Click(object sender, EventArgs e)//商品销售
        {
            FrmSale sale = new FrmSale();
            this.ReForm(sale.Text,sale);
        }

        private void bookreturn_Click(object sender, EventArgs e)//顾客退货管理
        {
            FrmBookReturn bookreturn = new FrmBookReturn();
            this.ReForm(bookreturn.Text,bookreturn);
        }

        private void salequery_Click(object sender, EventArgs e)//销售情况查询
        {
            FrmSaleQuery salequery = new FrmSaleQuery();
            this.ReForm(salequery.Text,salequery);
        }

        private void modifypwd_Click(object sender, EventArgs e)//修改密码
        {
            FrmModifyPwd modifypwd = new FrmModifyPwd();
            this.ReForm(modifypwd.Text,modifypwd);
        }

        private void bookbad_Click(object sender, EventArgs e)//商品损坏
        {
            FrmWareBad warebad = new FrmWareBad();
            this.ReForm(warebad.Text,warebad);
        }

        private void bookmgr_Click(object sender, EventArgs e)//图书库存管理
        {
            FrmBookStock bookstock = new FrmBookStock();
            this.ReForm(bookstock.Text,bookstock);
        }

        private void cdmgr_Click(object sender, EventArgs e)//光盘库存管理
        {
            FrmCdStock cdstock = new FrmCdStock();
            this.ReForm(cdstock.Text,cdstock);
        }

        private void datain_Click(object sender, EventArgs e)//数据导入
        {
            FrmDataIn datain = new FrmDataIn();
            this.ReForm(datain.Text,datain);
        }

        private void dataout_Click(object sender, EventArgs e)//数据导出
        {
            FrmDataOut dataout = new FrmDataOut();
            this.ReForm(dataout.Text,dataout);
        }

        private void backup_Click(object sender, EventArgs e)//备份数据库
        {
            FrmBackUp backup = new FrmBackUp();
            this.ReForm(backup.Text,backup);
        }

        private void restore_Click(object sender, EventArgs e)//还原数据库
        {
            FrmRestore restore = new FrmRestore();
            this.ReForm(restore.Text,restore);
        }

        private void bookindex_Click(object sender, EventArgs e)//销售排行
        {
            FrmSaleIndex saleindex = new FrmSaleIndex();
            this.ReForm(saleindex.Text,saleindex);
        }

        private void printware_Click(object sender, EventArgs e)//打印商品信息
        {
            FrmPrintWare printware = new FrmPrintWare();
            this.ReForm(printware.Text,printware);
        }

        private void menuabout_Click(object sender, EventArgs e)//关于
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }

        private void menuprintbookback_Click(object sender, EventArgs e)//打印图书退还供应商
        {
            if (this.HaveBookBackData())
            {
                PrintBackReturnBad bookback = new PrintBackReturnBad(1);
                bookback.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有可打印的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuprintcdback_Click(object sender, EventArgs e)//打印光盘退还供应商
        {
            if (this.HaveCdBackData())
            {
                PrintBackReturnBad cdback = new PrintBackReturnBad(2);
                cdback.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有可打印的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuprintbookreturn_Click(object sender, EventArgs e)//打印顾客退还图书
        {
            if (this.HaveBookReturnData())
            {
                PrintBackReturnBad bookreturn = new PrintBackReturnBad(3);
                bookreturn.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有可打印的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuprintcdreturn_Click(object sender, EventArgs e)//打印顾客退还光盘
        {
            if (this.HaveCdReturnData())
            {
                PrintBackReturnBad cdreturn = new PrintBackReturnBad(4);
                cdreturn.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有可打印的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuprintbookbad_Click(object sender, EventArgs e)//打印图书损坏
        {
            if (this.HaveBookBadData())
            {
                PrintBackReturnBad bookbad = new PrintBackReturnBad(5);
                bookbad.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有可打印的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuprintcdbad_Click(object sender, EventArgs e)//打印光盘损坏
        {
            if (this.HaveCdBadData())
            {
                PrintBackReturnBad cdbad = new PrintBackReturnBad(6);
                cdbad.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有可打印的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void printsale_Click(object sender, EventArgs e)//打印商品销售
        {
            FrmPrintSale printsale = new FrmPrintSale();
            this.ReForm(printsale.Text,printsale);
        }

        /// <summary>
        /// 判断是否可打印退还供应商图书信息
        /// </summary>
        private bool HaveBookBackData()
        {
            SqlConnection connect = InitConnect.GetConnection();
            MyDataSet data = new MyDataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from bookbackprovider", connect);
            data.Clear();
            adapter.Fill(data.book_back);
            if (data.book_back.DefaultView.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断是否可打印退还供应商光盘信息
        /// </summary>
        private bool HaveCdBackData()
        {
            SqlConnection connect = InitConnect.GetConnection();
            MyDataSet data = new MyDataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from cdbackprovider", connect);
            data.Clear();
            adapter.Fill(data.cd_back);
            if (data.cd_back.DefaultView.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断是否可打印顾客退还图书信息
        /// </summary>
        private bool HaveBookReturnData()
        {
            SqlConnection connect = InitConnect.GetConnection();
            MyDataSet data = new MyDataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from bookreturnme", connect);
            data.Clear();
            adapter.Fill(data.book_return);
            if (data.book_return.DefaultView.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断是否可打印顾客退还光盘信息
        /// </summary>
        private bool HaveCdReturnData()
        {
            SqlConnection connect = InitConnect.GetConnection();
            MyDataSet data = new MyDataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from cdreturnme", connect);
            data.Clear();
            adapter.Fill(data.cd_return);
            if (data.cd_return.DefaultView.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断是否可打印图书损坏
        /// </summary>
        private bool HaveBookBadData()
        {
            SqlConnection connect = InitConnect.GetConnection();
            MyDataSet data = new MyDataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from bookbadme", connect);
            data.Clear();
            adapter.Fill(data.book_bad);
            if (data.book_bad.DefaultView.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断是否可打印光盘损坏
        /// </summary>
        private bool HaveCdBadData()
        {
            SqlConnection connect = InitConnect.GetConnection();
            MyDataSet data = new MyDataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from cdbadme", connect);
            data.Clear();
            adapter.Fill(data.cd_bad);
            if (data.cd_bad.DefaultView.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void 帮助主题MToolStripMenuItem_Click(object sender, EventArgs e)//帮助主题
        {
            Help.ShowHelp(this, Path.GetDirectoryName(Application.ExecutablePath) + "\\Help\\help.chm");
        }
    }
}