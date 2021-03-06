﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace book
{
    public partial class PrintWare : Form
    {
        private string ware;
        private object dataset;

        public PrintWare()
        {
            InitializeComponent();
        }

        public PrintWare(object data,string paramware)
        {
            InitializeComponent();
            dataset = data;
            ware = paramware;
        }

        private void PrintWare_Load(object sender, EventArgs e)//初始化
        {
            if (ware.Trim() == "图书")
            {
                PrintBookReport bookreport = new PrintBookReport();
                bookreport.SetDataSource(dataset);
                this.crystalReportViewer1.ReportSource = bookreport;
            }
            else
            {
                PrintCdReport cdreport = new PrintCdReport();
                cdreport.SetDataSource(dataset);
                this.crystalReportViewer1.ReportSource = cdreport;
            }
        }
    }
}