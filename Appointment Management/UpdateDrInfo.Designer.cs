
namespace Appointment_Management
{
    partial class UpdateDrInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDrInfo));
            this.dgvDr = new System.Windows.Forms.DataGridView();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppointment = new Appointment_Management.DSAppointment();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateDr = new System.Windows.Forms.Button();
            this.buttonArchiveDoctor = new System.Windows.Forms.Button();
            this.taDoctor1 = new Appointment_Management.DSAppointmentTableAdapters.DoctorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.taDoctor2 = new Appointment_Management.DSAppointmentTableAdapters.DoctorTableAdapter();
            this.tglColor = new System.Windows.Forms.Button();
            this.buttonArchiveDoctor1 = new System.Windows.Forms.Button();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorArchiveStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDr
            // 
            this.dgvDr.AutoGenerateColumns = false;
            this.dgvDr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDr.BackgroundColor = System.Drawing.Color.White;
            this.dgvDr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.specialityIDDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.doctorSurnameDataGridViewTextBoxColumn,
            this.doctorPhoneNoDataGridViewTextBoxColumn,
            this.doctorEmailDataGridViewTextBoxColumn,
            this.doctorArchiveStatusDataGridViewTextBoxColumn,
            this.doctorPasswordDataGridViewTextBoxColumn});
            this.dgvDr.DataSource = this.doctorBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDr.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDr.Location = new System.Drawing.Point(148, 136);
            this.dgvDr.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDr.Name = "dgvDr";
            this.dgvDr.ReadOnly = true;
            this.dgvDr.RowHeadersWidth = 51;
            this.dgvDr.RowTemplate.Height = 24;
            this.dgvDr.Size = new System.Drawing.Size(1600, 700);
            this.dgvDr.TabIndex = 0;
            this.dgvDr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDr_CellContentClick);
            this.dgvDr.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDr_RowHeaderMouseDoubleClick);
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "Doctor";
            this.doctorBindingSource1.DataSource = this.dSAppointment;
            // 
            // dSAppointment
            // 
            this.dSAppointment.DataSetName = "DSAppointment";
            this.dSAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.dSAppointment;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(869, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Info";
            // 
            // btnUpdateDr
            // 
            this.btnUpdateDr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.btnUpdateDr.FlatAppearance.BorderSize = 0;
            this.btnUpdateDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDr.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDr.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDr.Location = new System.Drawing.Point(169, 897);
            this.btnUpdateDr.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDr.Name = "btnUpdateDr";
            this.btnUpdateDr.Size = new System.Drawing.Size(200, 60);
            this.btnUpdateDr.TabIndex = 2;
            this.btnUpdateDr.Text = "Update Doctor";
            this.btnUpdateDr.UseVisualStyleBackColor = false;
            this.btnUpdateDr.Click += new System.EventHandler(this.btnUpdateDr_Click);
            // 
            // buttonArchiveDoctor
            // 
            this.buttonArchiveDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.buttonArchiveDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchiveDoctor.Location = new System.Drawing.Point(1927, 874);
            this.buttonArchiveDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArchiveDoctor.Name = "buttonArchiveDoctor";
            this.buttonArchiveDoctor.Size = new System.Drawing.Size(200, 60);
            this.buttonArchiveDoctor.TabIndex = 3;
            this.buttonArchiveDoctor.Text = "button2";
            this.buttonArchiveDoctor.UseVisualStyleBackColor = false;
            this.buttonArchiveDoctor.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // taDoctor1
            // 
            this.taDoctor1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(169, 869);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taDoctor2
            // 
            this.taDoctor2.ClearBeforeFill = true;
            // 
            // tglColor
            // 
            this.tglColor.BackgroundImage = global::Appointment_Management.Properties.Resources.btnRed;
            this.tglColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tglColor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tglColor.Location = new System.Drawing.Point(862, 898);
            this.tglColor.Name = "tglColor";
            this.tglColor.Size = new System.Drawing.Size(300, 59);
            this.tglColor.TabIndex = 20;
            this.tglColor.UseVisualStyleBackColor = true;
            this.tglColor.Click += new System.EventHandler(this.tglColor_Click);
            // 
            // buttonArchiveDoctor1
            // 
            this.buttonArchiveDoctor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.buttonArchiveDoctor1.FlatAppearance.BorderSize = 0;
            this.buttonArchiveDoctor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchiveDoctor1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArchiveDoctor1.ForeColor = System.Drawing.Color.White;
            this.buttonArchiveDoctor1.Location = new System.Drawing.Point(1593, 898);
            this.buttonArchiveDoctor1.Name = "buttonArchiveDoctor1";
            this.buttonArchiveDoctor1.Size = new System.Drawing.Size(175, 62);
            this.buttonArchiveDoctor1.TabIndex = 21;
            this.buttonArchiveDoctor1.Text = "button2";
            this.buttonArchiveDoctor1.UseVisualStyleBackColor = false;
            this.buttonArchiveDoctor1.Click += new System.EventHandler(this.buttonArchiveDoctor1_Click);
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.doctorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialityIDDataGridViewTextBoxColumn
            // 
            this.specialityIDDataGridViewTextBoxColumn.DataPropertyName = "Speciality_ID";
            this.specialityIDDataGridViewTextBoxColumn.HeaderText = "Specialty ID";
            this.specialityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialityIDDataGridViewTextBoxColumn.Name = "specialityIDDataGridViewTextBoxColumn";
            this.specialityIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Name";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.doctorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorSurnameDataGridViewTextBoxColumn
            // 
            this.doctorSurnameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Surname";
            this.doctorSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.doctorSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorSurnameDataGridViewTextBoxColumn.Name = "doctorSurnameDataGridViewTextBoxColumn";
            this.doctorSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorPhoneNoDataGridViewTextBoxColumn
            // 
            this.doctorPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Phone_No";
            this.doctorPhoneNoDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.doctorPhoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorPhoneNoDataGridViewTextBoxColumn.Name = "doctorPhoneNoDataGridViewTextBoxColumn";
            this.doctorPhoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorEmailDataGridViewTextBoxColumn
            // 
            this.doctorEmailDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Email";
            this.doctorEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.doctorEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorEmailDataGridViewTextBoxColumn.Name = "doctorEmailDataGridViewTextBoxColumn";
            this.doctorEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorArchiveStatusDataGridViewTextBoxColumn
            // 
            this.doctorArchiveStatusDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Archive_Status";
            this.doctorArchiveStatusDataGridViewTextBoxColumn.HeaderText = "Doctor_Archive_Status";
            this.doctorArchiveStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorArchiveStatusDataGridViewTextBoxColumn.Name = "doctorArchiveStatusDataGridViewTextBoxColumn";
            this.doctorArchiveStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorArchiveStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // doctorPasswordDataGridViewTextBoxColumn
            // 
            this.doctorPasswordDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Password";
            this.doctorPasswordDataGridViewTextBoxColumn.HeaderText = "Doctor_Password";
            this.doctorPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorPasswordDataGridViewTextBoxColumn.Name = "doctorPasswordDataGridViewTextBoxColumn";
            this.doctorPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorPasswordDataGridViewTextBoxColumn.Visible = false;
            // 
            // UpdateDrInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonArchiveDoctor1);
            this.Controls.Add(this.tglColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonArchiveDoctor);
            this.Controls.Add(this.btnUpdateDr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDr);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateDrInfo";
            this.Text = "UpdateDrInfo";
            this.Load += new System.EventHandler(this.UpdateDrInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDr;
        private System.Windows.Forms.Label label1;
        private DSAppointment dSAppointment;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Button btnUpdateDr;
        private System.Windows.Forms.Button buttonArchiveDoctor;
        private DSAppointmentTableAdapters.DoctorTableAdapter taDoctor1;
        private System.Windows.Forms.Button button1;
        private DSAppointmentTableAdapters.DoctorTableAdapter taDoctor2;
        private System.Windows.Forms.Button tglColor;
        private System.Windows.Forms.Button buttonArchiveDoctor1;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorArchiveStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPasswordDataGridViewTextBoxColumn;
    }
}