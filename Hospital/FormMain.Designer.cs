namespace Hospital
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnAddNew = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ขอมลหลกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.ชวยเหลอToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เวบไซตToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตดตอผพฒนาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNew.Location = new System.Drawing.Point(25, 376);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "เพิ่มข้อมูล";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมลหลกToolStripMenuItem,
            this.ชวยเหลอToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(718, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ขอมลหลกToolStripMenuItem
            // 
            this.ขอมลหลกToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPatient,
            this.menuItemDoctor});
            this.ขอมลหลกToolStripMenuItem.Name = "ขอมลหลกToolStripMenuItem";
            this.ขอมลหลกToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ขอมลหลกToolStripMenuItem.Text = "ข้อมูลหลัก";
            // 
            // menuItemPatient
            // 
            this.menuItemPatient.Name = "menuItemPatient";
            this.menuItemPatient.Size = new System.Drawing.Size(152, 22);
            this.menuItemPatient.Text = "ข้อมูลคนไข้";
            this.menuItemPatient.Click += new System.EventHandler(this.menuItemPatient_Click);
            // 
            // menuItemDoctor
            // 
            this.menuItemDoctor.Name = "menuItemDoctor";
            this.menuItemDoctor.Size = new System.Drawing.Size(152, 22);
            this.menuItemDoctor.Text = "ข้อมูลหมอ";
            this.menuItemDoctor.Click += new System.EventHandler(this.menuItemDoctor_Click);
            // 
            // ชวยเหลอToolStripMenuItem
            // 
            this.ชวยเหลอToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เวบไซตToolStripMenuItem,
            this.ตดตอผพฒนาToolStripMenuItem});
            this.ชวยเหลอToolStripMenuItem.Name = "ชวยเหลอToolStripMenuItem";
            this.ชวยเหลอToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ชวยเหลอToolStripMenuItem.Text = "ช่วยเหลือ";
            // 
            // เวบไซตToolStripMenuItem
            // 
            this.เวบไซตToolStripMenuItem.Name = "เวบไซตToolStripMenuItem";
            this.เวบไซตToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.เวบไซตToolStripMenuItem.Text = "เว็บไซต์";
            // 
            // ตดตอผพฒนาToolStripMenuItem
            // 
            this.ตดตอผพฒนาToolStripMenuItem.Name = "ตดตอผพฒนาToolStripMenuItem";
            this.ตดตอผพฒนาToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ตดตอผพฒนาToolStripMenuItem.Text = "ติดต่อผู้พัฒนา";
            // 
            // gvMain
            // 
            this.gvMain.AllowUserToAddRows = false;
            this.gvMain.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            this.gvMain.Location = new System.Drawing.Point(12, 38);
            this.gvMain.Name = "gvMain";
            this.gvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMain.Size = new System.Drawing.Size(694, 332);
            this.gvMain.TabIndex = 0;
            this.gvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMain_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PatientName";
            this.Column1.HeaderText = "ชื่อคนไข้";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "DoctorName";
            this.Column2.HeaderText = "หมอผู้รักษา";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CheckDate";
            this.Column4.HeaderText = "วันที่ตรวจ";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Description";
            this.Column3.HeaderText = "รายละเอียดการรักษา";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AppointmentDate";
            this.Column5.HeaderText = "วันนัดพบครั้งต่อไป";
            this.Column5.Name = "Column5";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 411);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gvMain);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ประวัติคนไข้";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ขอมลหลกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemPatient;
        private System.Windows.Forms.ToolStripMenuItem menuItemDoctor;
        private System.Windows.Forms.DataGridView gvMain;
        private System.Windows.Forms.ToolStripMenuItem ชวยเหลอToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เวบไซตToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตดตอผพฒนาToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}