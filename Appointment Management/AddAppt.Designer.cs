
namespace Appointment_Management
{
    partial class AddAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addApptPatientBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppointment = new Appointment_Management.DSAppointment();
            this.searchFieldTextBox = new System.Windows.Forms.TextBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.patientSurnameTextBox = new System.Windows.Forms.TextBox();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientSurnameLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.apptTimeslotINNERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appt_Timeslot_INNERTableAdapter = new Appointment_Management.DSAppointmentTableAdapters.Appt_Timeslot_INNERTableAdapter();
            this.appointmentTableAdapter1 = new Appointment_Management.DSAppointmentTableAdapters.AppointmentTableAdapter();
            this.patientTableAdapter = new Appointment_Management.DSAppointmentTableAdapters.PatientTableAdapter();
            this.patientTableAdapter1 = new Appointment_Management.DSAppointmentTableAdapters.PatientTableAdapter();
            this.appt_Timeslot_INNERTableAdapter1 = new Appointment_Management.DSAppointmentTableAdapters.Appt_Timeslot_INNERTableAdapter();
            this.specialtyTableAdapter = new Appointment_Management.DSAppointmentTableAdapters.SpecialtyTableAdapter();
            this.doctorTableAdapter = new Appointment_Management.DSAppointmentTableAdapters.DoctorTableAdapter();
            this.timeslotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeslotTableAdapter = new Appointment_Management.DSAppointmentTableAdapters.TimeslotTableAdapter();
            this.practiceApptTableAdapter1 = new Appointment_Management.DSAppointmentTableAdapters.PracticeApptTableAdapter();
            this.taAppointmentCorrect1 = new Appointment_Management.DSAppointmentTableAdapters.Appointment_CorrectTableAdapter();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apptTimeslotINNERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeslotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.addApptPatientBtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.patientDataGridView);
            this.tabPage1.Controls.Add(this.searchFieldTextBox);
            this.tabPage1.Controls.Add(this.patientNameTextBox);
            this.tabPage1.Controls.Add(this.patientSurnameTextBox);
            this.tabPage1.Controls.Add(this.patientNameLabel);
            this.tabPage1.Controls.Add(this.patientSurnameLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(976, 735);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addApptPatientBtn
            // 
            this.addApptPatientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.addApptPatientBtn.FlatAppearance.BorderSize = 0;
            this.addApptPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addApptPatientBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addApptPatientBtn.ForeColor = System.Drawing.Color.White;
            this.addApptPatientBtn.Location = new System.Drawing.Point(388, 623);
            this.addApptPatientBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addApptPatientBtn.Name = "addApptPatientBtn";
            this.addApptPatientBtn.Size = new System.Drawing.Size(200, 40);
            this.addApptPatientBtn.TabIndex = 9;
            this.addApptPatientBtn.Text = "Add Appointment";
            this.addApptPatientBtn.UseVisualStyleBackColor = false;
            this.addApptPatientBtn.Click += new System.EventHandler(this.addApptPatientBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search by Name:";
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.patientDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.patientDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientSurnameDataGridViewTextBoxColumn,
            this.patientPhoneNoDataGridViewTextBoxColumn,
            this.patientEmailDataGridViewTextBoxColumn});
            this.patientDataGridView.DataSource = this.patientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.patientDataGridView.GridColor = System.Drawing.Color.LightGray;
            this.patientDataGridView.Location = new System.Drawing.Point(40, 158);
            this.patientDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientDataGridView.Name = "patientDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.patientDataGridView.RowHeadersWidth = 51;
            this.patientDataGridView.RowTemplate.Height = 24;
            this.patientDataGridView.Size = new System.Drawing.Size(905, 234);
            this.patientDataGridView.TabIndex = 0;
            this.patientDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.patientDataGridView_RowHeaderMouseClick_1);
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
            // 
            // patientSurnameDataGridViewTextBoxColumn
            // 
            this.patientSurnameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Surname";
            this.patientSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.patientSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientSurnameDataGridViewTextBoxColumn.Name = "patientSurnameDataGridViewTextBoxColumn";
            // 
            // patientPhoneNoDataGridViewTextBoxColumn
            // 
            this.patientPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Patient_Phone_No";
            this.patientPhoneNoDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.patientPhoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientPhoneNoDataGridViewTextBoxColumn.Name = "patientPhoneNoDataGridViewTextBoxColumn";
            // 
            // patientEmailDataGridViewTextBoxColumn
            // 
            this.patientEmailDataGridViewTextBoxColumn.DataPropertyName = "Patient_Email";
            this.patientEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.patientEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientEmailDataGridViewTextBoxColumn.Name = "patientEmailDataGridViewTextBoxColumn";
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
            // searchFieldTextBox
            // 
            this.searchFieldTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchFieldTextBox.Location = new System.Drawing.Point(345, 93);
            this.searchFieldTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchFieldTextBox.Multiline = true;
            this.searchFieldTextBox.Name = "searchFieldTextBox";
            this.searchFieldTextBox.Size = new System.Drawing.Size(250, 40);
            this.searchFieldTextBox.TabIndex = 7;
            this.searchFieldTextBox.TextChanged += new System.EventHandler(this.searchFieldTextBox_TextChanged_1);
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientNameTextBox.Enabled = false;
            this.patientNameTextBox.Location = new System.Drawing.Point(132, 468);
            this.patientNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientNameTextBox.Multiline = true;
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(226, 25);
            this.patientNameTextBox.TabIndex = 2;
            // 
            // patientSurnameTextBox
            // 
            this.patientSurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientSurnameTextBox.Enabled = false;
            this.patientSurnameTextBox.Location = new System.Drawing.Point(615, 468);
            this.patientSurnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientSurnameTextBox.Multiline = true;
            this.patientSurnameTextBox.Name = "patientSurnameTextBox";
            this.patientSurnameTextBox.Size = new System.Drawing.Size(226, 25);
            this.patientSurnameTextBox.TabIndex = 4;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(60, 468);
            this.patientNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(59, 24);
            this.patientNameLabel.TabIndex = 3;
            this.patientNameLabel.Text = "Name";
            // 
            // patientSurnameLabel
            // 
            this.patientSurnameLabel.AutoSize = true;
            this.patientSurnameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSurnameLabel.Location = new System.Drawing.Point(541, 468);
            this.patientSurnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientSurnameLabel.Name = "patientSurnameLabel";
            this.patientSurnameLabel.Size = new System.Drawing.Size(73, 24);
            this.patientSurnameLabel.TabIndex = 5;
            this.patientSurnameLabel.Text = "Surname";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 761);
            this.tabControl1.TabIndex = 0;
            // 
            // apptTimeslotINNERBindingSource
            // 
            this.apptTimeslotINNERBindingSource.DataMember = "Appt_Timeslot_INNER";
            this.apptTimeslotINNERBindingSource.DataSource = this.dSAppointment;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.dSAppointment;
            // 
            // specialtyBindingSource
            // 
            this.specialtyBindingSource.DataMember = "Specialty";
            this.specialtyBindingSource.DataSource = this.dSAppointment;
            // 
            // appt_Timeslot_INNERTableAdapter
            // 
            this.appt_Timeslot_INNERTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter1
            // 
            this.appointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // appt_Timeslot_INNERTableAdapter1
            // 
            this.appt_Timeslot_INNERTableAdapter1.ClearBeforeFill = true;
            // 
            // specialtyTableAdapter
            // 
            this.specialtyTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // timeslotBindingSource
            // 
            this.timeslotBindingSource.DataMember = "Timeslot";
            this.timeslotBindingSource.DataSource = this.dSAppointment;
            // 
            // timeslotTableAdapter
            // 
            this.timeslotTableAdapter.ClearBeforeFill = true;
            // 
            // practiceApptTableAdapter1
            // 
            this.practiceApptTableAdapter1.ClearBeforeFill = true;
            // 
            // taAppointmentCorrect1
            // 
            this.taAppointmentCorrect1.ClearBeforeFill = true;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apptTimeslotINNERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeslotBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DSAppointment dSAppointment;
        private DSAppointmentTableAdapters.Appt_Timeslot_INNERTableAdapter appt_Timeslot_INNERTableAdapter;
        private DSAppointmentTableAdapters.AppointmentTableAdapter appointmentTableAdapter1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DSAppointmentTableAdapters.PatientTableAdapter patientTableAdapter;
        private DSAppointmentTableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.BindingSource apptTimeslotINNERBindingSource;
        private DSAppointmentTableAdapters.Appt_Timeslot_INNERTableAdapter appt_Timeslot_INNERTableAdapter1;
        private System.Windows.Forms.BindingSource specialtyBindingSource;
        private DSAppointmentTableAdapters.SpecialtyTableAdapter specialtyTableAdapter;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DSAppointmentTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.BindingSource timeslotBindingSource;
        private DSAppointmentTableAdapters.TimeslotTableAdapter timeslotTableAdapter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.TextBox searchFieldTextBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox patientSurnameTextBox;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientSurnameLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button addApptPatientBtn;
        private DSAppointmentTableAdapters.PracticeApptTableAdapter practiceApptTableAdapter1;
        private DSAppointmentTableAdapters.Appointment_CorrectTableAdapter taAppointmentCorrect1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmailDataGridViewTextBoxColumn;
    }
}