using DataAccess;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormReport : Form
    {
        string _reportName;
        string _dataSourceName;
        object _dataSource;

        public FormReport()
        {
            InitializeComponent();
        }

        public FormReport(string reportName,string dataSourceName,object dataSource)
        {
            InitializeComponent();
            _reportName = reportName;
            _dataSourceName = dataSourceName;
            _dataSource = dataSource;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource(_dataSourceName, _dataSource);

            reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\" + _reportName;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
