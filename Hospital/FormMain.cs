using CsvHelper;
using DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            gvMain.AutoGenerateColumns = false;
            RefreshGridView();
        }

        private void menuItemDoctor_Click(object sender, EventArgs e)
        {
            FormDoctor doctorForm = new FormDoctor();
            doctorForm.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new FormPatientHistory().Show();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormPatientHistory frmPatientHistory = new FormPatientHistory();
            frmPatientHistory.ShowDialog();
            RefreshGridView();
        }

        private void menuItemPatient_Click(object sender, EventArgs e)
        {
            //var frmPatientHistory = new FormPatient();
            //frmPatientHistory.ShowDialog();

            new FormPatient().ShowDialog();
        }

        private void gvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = gvMain.Rows[e.RowIndex].Cells["ID"].Value;
            var frmPatientHistory = new FormPatientHistory();
            frmPatientHistory.SetPatientHistory(Convert.ToInt32(id));
            frmPatientHistory.ShowDialog();
            RefreshGridView();
        }

        void RefreshGridView()
        {
            var accessor = new PatientHistoryAccessor();
            gvMain.DataSource = accessor.FindAll();
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            var accessor = new PatientHistoryAccessor();

            using (StreamWriter writer = new StreamWriter(@"PatientHistory.csv"))
            using (CsvWriter csv = new CsvWriter(writer))
            {
                csv.Configuration.QuoteAllFields = true;
                csv.Configuration.Encoding = Encoding.UTF8;
                csv.WriteRecords(accessor.FindAll());
              
            }

            
        }
    }
}
