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
    public partial class FormDoctor : Form
    {
        DoctorAccessor _doctorAccessor = new DoctorAccessor();

        public FormDoctor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var doctor = new Doctor();
            int id = 0;
            int.TryParse(txtID.Text,out id);
            doctor.ID = id;
            doctor.Name = txtName.Text;
            doctor.Description = txtDescription.Text;
            _doctorAccessor.InsertOrUpdate(doctor);
            ClearControls();

            RefreshGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtID.Text, out id);
            _doctorAccessor.Delete(id);
            ClearControls();

            RefreshGridView();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = gvList.Rows[e.RowIndex].Cells["ID"].Value;
            var docter = _doctorAccessor.FindById(Convert.ToInt32(id));
            if (docter != null)
            {
                txtID.Text = docter.ID.ToString();
                txtName.Text = docter.Name;
                txtDescription.Text = docter.Description;
            }
        }

        void RefreshGridView()
        {
            gvList.DataSource = _doctorAccessor.FindAll();
            gvList.Refresh();
        }

        void ClearControls()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
        }
        
    }
}
