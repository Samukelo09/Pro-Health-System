
namespace Appointment_Management
{
    partial class DeleteAndUpdatePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAndUpdatePatient));
            this.labelUpdatePatient = new System.Windows.Forms.Label();
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientArchiveStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppointment = new Appointment_Management.DSAppointment();
            this.buttonUpdatePatient = new System.Windows.Forms.Button();
            this.buttonArchivePatient = new System.Windows.Forms.Button();
            this.patientTableAdapter = new Appointment_Management.DSAppointmentTableAdapters.PatientTableAdapter();
            this.btnPatientRecord = new System.Windows.Forms.Button();
            this.taAppointment_Correct1 = new Appointment_Management.DSAppointmentTableAdapters.Appointment_CorrectTableAdapter();
            this.taPatient1 = new Appointment_Management.DSAppointmentTableAdapters.PatientTableAdapter();
            this.taPatient2 = new Appointment_Management.DSAppointmentTableAdapters.PatientTableAdapter();
            this.tglColor = new System.Windows.Forms.Button();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUpdatePatient
            // 
            this.labelUpdatePatient.AutoSize = true;
            this.labelUpdatePatient.BackColor = System.Drawing.Color.White;
            this.labelUpdatePatient.Font = new System.Drawing.Font("Franklin Gothic Demi", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdatePatient.Location = new System.Drawing.Point(906, 51);
            this.labelUpdatePatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUpdatePatient.Name = "labelUpdatePatient";
            this.labelUpdatePatient.Size = new System.Drawing.Size(261, 43);
            this.labelUpdatePatient.TabIndex = 0;
            this.labelUpdatePatient.Text = "Patient Details";
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.AutoGenerateColumns = false;
            this.dgvPatientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvPatientList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatientList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPatientList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientSurnameDataGridViewTextBoxColumn,
            this.patientPhoneNoDataGridViewTextBoxColumn,
            this.patientEmailDataGridViewTextBoxColumn,
            this.patientPasswordDataGridViewTextBoxColumn,
            this.patientArchiveStatusDataGridViewTextBoxColumn});
            this.dgvPatientList.DataSource = this.patientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatientList.Location = new System.Drawing.Point(153, 228);
            this.dgvPatientList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.ReadOnly = true;
            this.dgvPatientList.RowHeadersWidth = 51;
            this.dgvPatientList.RowTemplate.Height = 24;
            this.dgvPatientList.Size = new System.Drawing.Size(1600, 551);
            this.dgvPatientList.TabIndex = 1;
            this.dgvPatientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientList_CellContentClick);
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "Patient_Id";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.patientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Name";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientSurnameDataGridViewTextBoxColumn
            // 
            this.patientSurnameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Surname";
            this.patientSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.patientSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientSurnameDataGridViewTextBoxColumn.Name = "patientSurnameDataGridViewTextBoxColumn";
            this.patientSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientPhoneNoDataGridViewTextBoxColumn
            // 
            this.patientPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Patient_Phone_No";
            this.patientPhoneNoDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.patientPhoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientPhoneNoDataGridViewTextBoxColumn.Name = "patientPhoneNoDataGridViewTextBoxColumn";
            this.patientPhoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientEmailDataGridViewTextBoxColumn
            // 
            this.patientEmailDataGridViewTextBoxColumn.DataPropertyName = "Patient_Email";
            this.patientEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.patientEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientEmailDataGridViewTextBoxColumn.Name = "patientEmailDataGridViewTextBoxColumn";
            this.patientEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientPasswordDataGridViewTextBoxColumn
            // 
            this.patientPasswordDataGridViewTextBoxColumn.DataPropertyName = "Patient_Password";
            this.patientPasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.patientPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientPasswordDataGridViewTextBoxColumn.Name = "patientPasswordDataGridViewTextBoxColumn";
            this.patientPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientPasswordDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientArchiveStatusDataGridViewTextBoxColumn
            // 
            this.patientArchiveStatusDataGridViewTextBoxColumn.DataPropertyName = "Patient_Archive_Status";
            this.patientArchiveStatusDataGridViewTextBoxColumn.HeaderText = "Patient_Archive_Status";
            this.patientArchiveStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientArchiveStatusDataGridViewTextBoxColumn.Name = "patientArchiveStatusDataGridViewTextBoxColumn";
            this.patientArchiveStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientArchiveStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dSAppointment;
            // 
            // dSAppointment
            // 
            this.dSAppointment.DataSetName = "DSAppointment";
            this.dSAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUpdatePatient
            // 
            this.buttonUpdatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.buttonUpdatePatient.FlatAppearance.BorderSize = 0;
            this.buttonUpdatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdatePatient.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePatient.ForeColor = System.Drawing.Color.White;
            this.buttonUpdatePatient.Location = new System.Drawing.Point(153, 840);
            this.buttonUpdatePatient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdatePatient.Name = "buttonUpdatePatient";
            this.buttonUpdatePatient.Size = new System.Drawing.Size(200, 60);
            this.buttonUpdatePatient.TabIndex = 2;
            this.buttonUpdatePatient.Text = "Update Patient";
            this.buttonUpdatePatient.UseVisualStyleBackColor = false;
            this.buttonUpdatePatient.Click += new System.EventHandler(this.buttonUpdatePatient_Click);
            // 
            // buttonArchivePatient
            // 
            this.buttonArchivePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.buttonArchivePatient.FlatAppearance.BorderSize = 0;
            this.buttonArchivePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArchivePatient.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArchivePatient.ForeColor = System.Drawing.Color.White;
            this.buttonArchivePatient.Location = new System.Drawing.Point(1050, 840);
            this.buttonArchivePatient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArchivePatient.Name = "buttonArchivePatient";
            this.buttonArchivePatient.Size = new System.Drawing.Size(200, 60);
            this.buttonArchivePatient.TabIndex = 3;
            this.buttonArchivePatient.Text = "Archive Patient";
            this.buttonArchivePatient.UseVisualStyleBackColor = false;
            this.buttonArchivePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // btnPatientRecord
            // 
            this.btnPatientRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.btnPatientRecord.FlatAppearance.BorderSize = 0;
            this.btnPatientRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientRecord.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientRecord.ForeColor = System.Drawing.Color.White;
            this.btnPatientRecord.Location = new System.Drawing.Point(572, 840);
            this.btnPatientRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatientRecord.Name = "btnPatientRecord";
            this.btnPatientRecord.Size = new System.Drawing.Size(200, 60);
            this.btnPatientRecord.TabIndex = 4;
            this.btnPatientRecord.Text = "Get Record";
            this.btnPatientRecord.UseVisualStyleBackColor = false;
            this.btnPatientRecord.Click += new System.EventHandler(this.btnPatientRecord_Click);
            // 
            // taAppointment_Correct1
            // 
            this.taAppointment_Correct1.ClearBeforeFill = true;
            // 
            // taPatient1
            // 
            this.taPatient1.ClearBeforeFill = true;
            // 
            // taPatient2
            // 
            this.taPatient2.ClearBeforeFill = true;
            // 
            // tglColor
            // 
            this.tglColor.BackgroundImage = global::Appointment_Management.Properties.Resources.btnRed;
            this.tglColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tglColor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tglColor.Location = new System.Drawing.Point(1441, 840);
            this.tglColor.Name = "tglColor";
            this.tglColor.Size = new System.Drawing.Size(300, 60);
            this.tglColor.TabIndex = 18;
            this.tglColor.UseVisualStyleBackColor = true;
            this.tglColor.Click += new System.EventHandler(this.tglColor_Click);
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Location = new System.Drawing.Point(889, 169);
            this.txtSearchPatient.Multiline = true;
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(300, 30);
            this.txtSearchPatient.TabIndex = 19;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(962, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search by Name";
            // 
            // DeleteAndUpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchPatient);
            this.Controls.Add(this.tglColor);
            this.Controls.Add(this.btnPatientRecord);
            this.Controls.Add(this.buttonArchivePatient);
            this.Controls.Add(this.buttonUpdatePatient);
            this.Controls.Add(this.dgvPatientList);
            this.Controls.Add(this.labelUpdatePatient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeleteAndUpdatePatient";
            this.Text = "DeleteAndUpdatePatient";
            this.Load += new System.EventHandler(this.DeleteAndUpdatePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUpdatePatient;
        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.Button buttonUpdatePatient;
        private System.Windows.Forms.Button buttonArchivePatient;
        private DSAppointment dSAppointment;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DSAppointmentTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.Button btnPatientRecord;
        private DSAppointmentTableAdapters.Appointment_CorrectTableAdapter taAppointment_Correct1;
        private DSAppointmentTableAdapters.PatientTableAdapter taPatient1;
        private DSAppointmentTableAdapters.PatientTableAdapter taPatient2;
        private System.Windows.Forms.Button tglColor;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientArchiveStatusDataGridViewTextBoxColumn;
    }
}