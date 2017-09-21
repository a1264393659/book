using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace book
{
    class InitConnect
    {

        [DllImport("kernel32.dll")]
        private static extern bool GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, StringBuilder lpReturnValue, int nSize, string lpFileName);

        /// <summary>
        /// ʵ����һ��SQL����
        /// </summary>
        /// <returns>����һ��SqlConnectionʵ��</returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("WorkStation ID=" + GetServer() + ";User ID=" + GetUser() + ";Password=" + GetPwd() + ";Database=" + GetDatabaseName());
        }

        /// <summary>
        /// ��ȡ����������
        /// </summary>
        /// <returns>����������</returns>
        public static string GetServer()
        {
            string FileName = Path.GetDirectoryName(Application.ExecutablePath) + "\\config.ini";
            StringBuilder str = new StringBuilder(30);
            GetPrivateProfileString("Connection", "Server", "(local)", str, str.Capacity, FileName);
            string server = str.ToString().Trim();
            return server;
        }

        /// <summary>
        /// ��ȡ�û�����
        /// </summary>
        /// <returns>���ݿ��û���</returns>
        public static string GetUser()
        {
            string FileName = Path.GetDirectoryName(Application.ExecutablePath) + "\\config.ini";
            StringBuilder str = new StringBuilder(30);
            GetPrivateProfileString("Connection", "User ID", "sa", str, str.Capacity, FileName);
            string user = str.ToString().Trim();
            return user;
        }

        /// <summary>
        /// ��ȡ���ݿ�����
        /// </summary>
        /// <returns>�������ݿ������</returns>
        public static string GetPwd()
        {
            string FileName = Path.GetDirectoryName(Application.ExecutablePath) + "\\config.ini";
            StringBuilder str = new StringBuilder(30);
            GetPrivateProfileString("Connection", "Password", "", str, str.Capacity, FileName);
            string pwd = str.ToString().Trim();
            return pwd;
        }

        /// <summary>
        /// ��ȡ���ݿ������
        /// </summary>
        /// <returns>���ݿ�����</returns>
        public static string GetDatabaseName()
        {
            string FileName = Path.GetDirectoryName(Application.ExecutablePath) + "\\config.ini";
            StringBuilder str = new StringBuilder(30);
            GetPrivateProfileString("Connection", "Database", "book", str, str.Capacity, FileName);
            string database = str.ToString().Trim();
            return database;
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="selectstring">ѡ�񵼳����ݵ�SQLѡ�����</param>
        public static void DataOut(SaveFileDialog dialog,string selectstring)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Excel.ApplicationClass excel = new Excel.ApplicationClass();
                Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.Add(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                worksheet.Cells.NumberFormatLocal = "@";
                ///////////////////////////////////
                SqlConnection connect = InitConnect.GetConnection();
                SqlDataReader read=null;
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(selectstring, connect);
                    read = cmd.ExecuteReader();
                    for (int i = 0; i < read.FieldCount; i++)
                    {
                        worksheet.Cells[1, i + 1] = read.GetName(i).Trim();
                    }
                    int row = 2;
                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                        for (int i = 0; i < read.FieldCount; i++)
                        {
                            worksheet.Cells[row, i + 1] = read[i].ToString().Trim();
                        }
                        row++;
                    }
                    MessageBox.Show("�ɹ�����" + count.ToString() + "����¼��", "��ϲ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("����" + ee.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    read.Close();
                    connect.Close();
                    object change = false, filename = dialog.FileName;
                    workbook.SaveCopyAs(filename);
                    workbook.Close(change, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                    excel.Quit();
                }
            }
        }

        /// <summary>
        /// ��ȡ�Ƿ�����Ʒ����ϵͳ����
        /// </summary>
        /// <param name="Flag">FlagΪtrue��ʾͼ�飬Ϊfalse��ʾ����</param>
        /// <returns>���س���ϵͳ���޵�����</returns>
        public static string GetWareUp(bool Flag)
        {
            SqlConnection connect = InitConnect.GetConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("WareUpCount",connect);
            cmd.CommandType = CommandType.StoredProcedure;
            if (Flag)
            {
                cmd.Parameters.AddWithValue("@Flag", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Flag", 2);
            }
            string count = (cmd.ExecuteScalar().ToString().Trim() != "") ? cmd.ExecuteScalar().ToString().Trim() : "0";
            connect.Close();
            return count;
        }

        /// <summary>
        /// ��ȡ�Ƿ�����Ʒ����ϵͳ����
        /// </summary>
        /// <param name="Flag">FlagΪtrue��ʾͼ�飬Ϊfalse��ʾ����</param>
        /// <returns>���ص���ϵͳ���޵�����</returns>
        public static string GetWareDown(bool Flag)
        {
            SqlConnection connect = InitConnect.GetConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand("WareDownCount", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            if (Flag)
            {
                cmd.Parameters.AddWithValue("@Flag", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Flag", 2);
            }
            string count = (cmd.ExecuteScalar().ToString().Trim() != "") ? cmd.ExecuteScalar().ToString().Trim() : "0";
            connect.Close();
            return count;
        }
    }
}
