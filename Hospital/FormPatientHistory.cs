using DataAccess;
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
    public partial class FormPatientHistory : Form
    {
        private int _id=0;

        public FormPatientHistory()
        {
            InitializeComponent();
        }

        private void frmPatientHistoryForm_Load(object sender, EventArgs e)
        {
            dtpCheckDate.Format = DateTimePickerFormat.Custom;
            dtpCheckDate.CustomFormat = "dd/MM/yyyy hh:mm";
            dtpAppointmentDate.Format = DateTimePickerFormat.Custom;
            dtpAppointmentDate.CustomFormat = "dd/MM/yyyy hh:mm";

            PatientAccessor patientAccessor = new PatientAccessor();
            cboPatient.DataSource = patientAccessor.FindAll();
            cboPatient.ValueMember = "ID";
            cboPatient.DisplayMember = "Name";

            DoctorAccessor doctorAccessor = new DoctorAccessor();
            cboDoctor.DataSource = doctorAccessor.FindAll();
            cboDoctor.ValueMember = "ID";
            cboDoctor.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PatientHistoryAccessor patientAccessor = new PatientHistoryAccessor();
            var patient = new PatientHistory();
            patient.ID = this._id;
            patient.PatientID = (int)cboPatient.SelectedValue;
            patient.DoctorID = (int)cboDoctor.SelectedValue;
            patient.Medicine = txtMedicine.Text;
            patient.Description = txtDescription.Text;
            patient.CheckDate = dtpCheckDate.Value;
            patient.AppointmentDate = dtpAppointmentDate.Value;
            patientAccessor.InsertOrUpdate(patient);
            this.Close();
        }

        public void SetPatientHistory(int id)
        {
            PatientHistoryAccessor patientAccessor = new PatientHistoryAccessor();
            var patient = patientAccessor.FindById(id);
            this._id = id;
            patient.ID = this._id;
            cboPatient.SelectedValue = patient.PatientID;
            cboDoctor.SelectedValue = patient.DoctorID;
            txtMedicine.Text = patient.Medicine;
            txtDescription.Text = patient.Description;
            dtpCheckDate.Value = patient.CheckDate;
            dtpAppointmentDate.Value = patient.AppointmentDate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
