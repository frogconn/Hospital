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
    public partial class FormPatient : Form
    {
        PatientAccessor _accessor = new PatientAccessor();

        public FormPatient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            int id = 0;
            int.TryParse(txtID.Text, out id);
            patient.ID = id;
            patient.CitizenId = txtCitizenId.Text;
            patient.Name = txtName.Text;
            patient.Address = txtAddress.Text;
            patient.Telephone = txtTelephone.Text;

            _accessor.InsertOrUpdate(patient);

            ClearControls();

            RefreshGridView();
        }

        void RefreshGridView()
        {
            gvList.DataSource = _accessor.FindAll();
            gvList.Refresh();
        }

        void ClearControls()
        {
            txtID.Text = "";
            txtCitizenId.Text = "";
            txtName.Text = "";
            txtAddress.Text= "";
            txtTelephone.Text = "";
        }

        private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = gvList.Rows[e.RowIndex].Cells["ID"].Value;
            var patient = _accessor.FindById(Convert.ToInt32(id));
            if (patient != null)
            {
                txtID.Text = patient.ID.ToString();
                txtCitizenId.Text = patient.CitizenId;
                txtName.Text = patient.Name;
                txtAddress.Text = patient.Address;
                txtTelephone.Text = patient.Telephone;
            }
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtID.Text, out id);
            _accessor.Delete(id);

            ClearControls();

            RefreshGridView();
        }
    }
}
