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
        /// �����û���Ȩ��
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
                if (read["power_name"].ToString().Trim() == "ϵͳ����")
                {
                    this.button1.Enabled = true;
                    this.menublock1.Enabled = true;
                }
                else if (read["power_name"].ToString().Trim() == "��������ά��")
                {
                    this.button2.Enabled = true;
                    this.menublock2.Enabled = true;
                }
                else if (read["power_name"].ToString().Trim() == "�ɹ�����")
                {
                    this.button3.Enabled = true;
                    this.menublock3.Enabled = true;
                }
                else if (read["power_name"].ToString().Trim() == "���۹���")
                {
                    this.button4.Enabled = true;
                    this.menublock4.Enabled = true;
                }
                else if (read["power_name"].ToString().Trim() == "������")
                {
                    this.button5.Enabled = true;
                    this.menublock5.Enabled = true;
                }
                else if (read["power_name"].ToString().Trim() == "ϵͳ���ݹ���")
                {
                    this.button6.Enabled = true;
                    this.menublock6.Enabled = true;
                }
            }
            read.Close();
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)//��ʾ��ѡ���ģ��
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

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)//�������С�ı�ʱҪ�ı䵼���Ĵ�С
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

        private void init_Click(object sender, EventArgs e)//ϵͳ��ʼ��
        {
            FrmInit init = new FrmInit();
            this.ReForm(init.Text,init);
        }

        /// <summary>
        /// �򿪴���,���ظ�
        /// </summary>
        /// <param name="form">Ҫ�򿪵Ĵ���</param>
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

        private void bookstyle_Click(object sender, EventArgs e)//ͼ����������
        {
            FrmBookStyle bookstyle = new FrmBookStyle();
            this.ReForm(bookstyle.Text,bookstyle);
        }

        private void userstyle_Click(object sender, EventArgs e)//�û���������
        {
            FrmUserStyle userstyle = new FrmUserStyle();
            this.ReForm(userstyle.Text,userstyle);
        }

        private void �ص�����ToolStripMenuItem_Click(object sender, EventArgs e)//�ص�������ʾ
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ˮƽ������ʾToolStripMenuItem_Click(object sender, EventArgs e)//ˮƽ������ʾ
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ��ֱ������ʾToolStripMenuItem_Click(object sender, EventArgs e)//��ֱ������ʾ
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ����������ʾToolStripMenuItem_Click(object sender, EventArgs e)//�봰�岢����ʾ
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void ���ص�����ToolStripMenuItem_Click(object sender, EventArgs e)//���ص�����
        {
            this.splitContainer1.Visible = false;
        }

        private void ��ʾ������ToolStripMenuItem_Click(object sender, EventArgs e)//��ʾ������
        {
            this.splitContainer1.Visible = true;
        }

        private void �رյ�ǰ����ToolStripMenuItem_Click(object sender, EventArgs e)//�رյ�ǰ����
        {
            if (this.ActiveMdiChild!=null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void �ر����д���ToolStripMenuItem_Click(object sender, EventArgs e)//�ر����д���
        {
            for (int i = this.MdiChildren.Length-1; i >= 0; i--)
            {
                this.MdiChildren[i].Close();
            }
        }

        private void power_Click(object sender, EventArgs e)//�û�Ȩ������
        {
            FrmUserPower userpower = new FrmUserPower();
            this.ReForm(userpower.Text,userpower);
        }

        private void vipstyle_Click(object sender, EventArgs e)//��Ա��������
        {
            FrmVipStyle vipstyle = new FrmVipStyle();
            this.ReForm(vipstyle.Text,vipstyle);
        }

        private void back_Click(object sender, EventArgs e)//�˻���������
        {
            FrmReturnDate returndate = new FrmReturnDate();
            this.ReForm(returndate.Text,returndate);
        }

        private void updown_Click(object sender, EventArgs e)//��Ʒ����������
        {
            FrmUpdown updown = new FrmUpdown();
            this.ReForm(updown.Text,updown);
        }

        private void logout_Click(object sender, EventArgs e)//ע��ϵͳ
        {
            if (MessageBox.Show("��ȷ��Ҫע���˻���", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    this.FrmMain_Load(sender,e);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)//�˳�ϵͳ
        {
            Application.Exit();
        }

        /// <summary>
        /// ����Ƿ���Խ����Ʒ,����е������洰��
        /// </summary>
        private void CheckWareUpDown()
        {
            if (InitConnect.GetWareDown(true) != "0" || InitConnect.GetWareDown(false) != "0" || InitConnect.GetWareUp(true) != "0" || InitConnect.GetWareUp(false) != "0")
            {
                FrmWarning warning = new FrmWarning();
                warning.Show();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)//��ʼ��
        {
            this.SetUserPower();
            //////////////////////////////////////////////////////////////////
            this.CheckWareUpDown();
            ///////////////////////////////////////////////////////////////////////
            this.timer1.Enabled = true;
            this.toolStripStatusLabel2.Text = "     �û����ͣ�" + UserInfo.UserPower +"     ";
            this.toolStripStatusLabel3.Text = "     �û����ƣ�" + UserInfo.UserID + "     ";
            this.toolStripStatusLabel4.Text = "     ��ǰʱ�䣺" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + "     ";
            ////////////////////////////////////////////////��ʼ��ʾ�˳���¼ģ��
            this.panel1.Visible = false;
            this.panel2.Visible = false;
            this.panel3.Visible = false;
            this.panel4.Visible = false;
            this.panel5.Visible = false;
            this.panel6.Visible = false;
            this.panel7.Visible = true;
            this.panel7.Height = this.Height - this.button2.Height * (this.splitContainer1.Panel1.Controls.Count / 2) - 84;
        }

        private void timer1_Tick(object sender, EventArgs e)//��ʾʱ��
        {
            this.toolStripStatusLabel4.Text = "     ��ǰʱ�䣺" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + "     ";
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)//������رյ�ʱ��رն�ʱ��
        {
            if (MessageBox.Show("��ȷ��Ҫ�˳�ϵͳ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.timer1.Enabled = false;
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void provider_Click(object sender, EventArgs e)//��Ӧ����Ϣ����
        {
            FrmProvider provider = new FrmProvider();
            this.ReForm(provider.Text,provider);
        }

        private void publish_Click(object sender, EventArgs e)//��������Ϣ����
        {
            FrmPublish publish = new FrmPublish();
            this.ReForm(publish.Text,publish);
        }

        private void bookcase_Click(object sender, EventArgs e)//�����Ϣ����
        {
            FrmBookcase bookcase = new FrmBookcase();
            this.ReForm(bookcase.Text,bookcase);
        }

        private void vip_Click(object sender, EventArgs e)//��Ա��Ϣ����
        {
            FrmVip vip = new FrmVip();
            this.ReForm(vip.Text,vip);
        }

        private void user_Click(object sender, EventArgs e)//�û���Ϣ����
        {
            FrmUser user = new FrmUser();
            this.ReForm(user.Text,user);
        }

        private void bookin_Click(object sender, EventArgs e)//��Ʒ���
        {
            FrmBookIn bookin = new FrmBookIn();
            this.ReForm(bookin.Text,bookin);
        }

        private void bookback_Click(object sender, EventArgs e)//��Ʒ�˻�����
        {
            FrmBookBack bookback = new FrmBookBack();
            this.ReForm(bookback.Text,bookback);
        }

        private void bookquery_Click(object sender, EventArgs e)//ͼ����Ϣ��ѯ
        {
            FrmQueryBook querybook = new FrmQueryBook();
            this.ReForm(querybook.Text,querybook);
        }

        private void sale_Click(object sender, EventArgs e)//��Ʒ����
        {
            FrmSale sale = new FrmSale();
            this.ReForm(sale.Text,sale);
        }

        private void bookreturn_Click(object sender, EventArgs e)//�˿��˻�����
        {
            FrmBookReturn bookreturn = new FrmBookReturn();
            this.ReForm(bookreturn.Text,bookreturn);
        }

        private void salequery_Click(object sender, EventArgs e)//���������ѯ
        {
            FrmSaleQuery salequery = new FrmSaleQuery();
            this.ReForm(salequery.Text,salequery);
        }

        private void modifypwd_Click(object sender, EventArgs e)//�޸�����
        {
            FrmModifyPwd modifypwd = new FrmModifyPwd();
            this.ReForm(modifypwd.Text,modifypwd);
        }

        private void bookbad_Click(object sender, EventArgs e)//��Ʒ��
        {
            FrmWareBad warebad = new FrmWareBad();
            this.ReForm(warebad.Text,warebad);
        }

        private void bookmgr_Click(object sender, EventArgs e)//ͼ�������
        {
            FrmBookStock bookstock = new FrmBookStock();
            this.ReForm(bookstock.Text,bookstock);
        }

        private void cdmgr_Click(object sender, EventArgs e)//���̿�����
        {
            FrmCdStock cdstock = new FrmCdStock();
            this.ReForm(cdstock.Text,cdstock);
        }

        private void datain_Click(object sender, EventArgs e)//���ݵ���
        {
            FrmDataIn datain = new FrmDataIn();
            this.ReForm(datain.Text,datain);
        }

        private void dataout_Click(object sender, EventArgs e)//���ݵ���
        {
            FrmDataOut dataout = new FrmDataOut();
            this.ReForm(dataout.Text,dataout);
        }

        private void backup_Click(object sender, EventArgs e)//�������ݿ�
        {
            FrmBackUp backup = new FrmBackUp();
            this.ReForm(backup.Text,backup);
        }

        private void restore_Click(object sender, EventArgs e)//��ԭ���ݿ�
        {
            FrmRestore restore = new FrmRestore();
            this.ReForm(restore.Text,restore);
        }

        private void bookindex_Click(object sender, EventArgs e)//��������
        {
            FrmSaleIndex saleindex = new FrmSaleIndex();
            this.ReForm(saleindex.Text,saleindex);
        }

        private void printware_Click(object sender, EventArgs e)//��ӡ��Ʒ��Ϣ
        {
            FrmPrintWare printware = new FrmPrintWare();
            this.ReForm(printware.Text,printware);
        }

        private void menuabout_Click(object sender, EventArgs e)//����
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }

        private void menuprintbookback_Click(object sender, EventArgs e)//��ӡͼ���˻���Ӧ��
        {
            if (this.HaveBookBackData())
            {
                PrintBackReturnBad bookback = new PrintBackReturnBad(1);
                bookback.ShowDialog();
            }
            else
            {
                MessageBox.Show("û�пɴ�ӡ�����ݣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuprintcdback_Click(object sender, EventArgs e)//��ӡ�����˻���Ӧ��
        {
            if (this.HaveCdBackData())
            {
                PrintBackReturnBad cdback = new PrintBackReturnBad(2);
                cdback.ShowDialog();
            }
            else
            {
                MessageBox.Show("û�пɴ�ӡ�����ݣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuprintbookreturn_Click(object sender, EventArgs e)//��ӡ�˿��˻�ͼ��
        {
            if (this.HaveBookReturnData())
            {
                PrintBackReturnBad bookreturn = new PrintBackReturnBad(3);
                bookreturn.ShowDialog();
            }
            else
            {
                MessageBox.Show("û�пɴ�ӡ�����ݣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuprintcdreturn_Click(object sender, EventArgs e)//��ӡ�˿��˻�����
        {
            if (this.HaveCdReturnData())
            {
                PrintBackReturnBad cdreturn = new PrintBackReturnBad(4);
                cdreturn.ShowDialog();
            }
            else
            {
                MessageBox.Show("û�пɴ�ӡ�����ݣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuprintbookbad_Click(object sender, EventArgs e)//��ӡͼ����
        {
            if (this.HaveBookBadData())
            {
                PrintBackReturnBad bookbad = new PrintBackReturnBad(5);
                bookbad.ShowDialog();
            }
            else
            {
                MessageBox.Show("û�пɴ�ӡ�����ݣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void menuprintcdbad_Click(object sender, EventArgs e)//��ӡ������
        {
            if (this.HaveCdBadData())
            {
                PrintBackReturnBad cdbad = new PrintBackReturnBad(6);
                cdbad.ShowDialog();
            }
            else
            {
                MessageBox.Show("û�пɴ�ӡ�����ݣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void printsale_Click(object sender, EventArgs e)//��ӡ��Ʒ����
        {
            FrmPrintSale printsale = new FrmPrintSale();
            this.ReForm(printsale.Text,printsale);
        }

        /// <summary>
        /// �ж��Ƿ�ɴ�ӡ�˻���Ӧ��ͼ����Ϣ
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
        /// �ж��Ƿ�ɴ�ӡ�˻���Ӧ�̹�����Ϣ
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
        /// �ж��Ƿ�ɴ�ӡ�˿��˻�ͼ����Ϣ
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
        /// �ж��Ƿ�ɴ�ӡ�˿��˻�������Ϣ
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
        /// �ж��Ƿ�ɴ�ӡͼ����
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
        /// �ж��Ƿ�ɴ�ӡ������
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

        private void ��������MToolStripMenuItem_Click(object sender, EventArgs e)//��������
        {
            Help.ShowHelp(this, Path.GetDirectoryName(Application.ExecutablePath) + "\\Help\\help.chm");
        }
    }
}