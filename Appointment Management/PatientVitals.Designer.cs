namespace Appointment_Management
{
    partial class PatientVitals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientVitals));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppointment = new Appointment_Management.DSAppointment();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonForVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heartRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGlucoseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respiratoryRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systolicBPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diastolicBPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appt_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentCorrectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taPatient1 = new Appointment_Management.DSAppointmentTableAdapters.PatientTableAdapter();
            this.taAppointment_Correct1 = new Appointment_Management.DSAppointmentTableAdapters.Appointment_CorrectTableAdapter();
            this.reasonForVisitLabel = new System.Windows.Forms.Label();
            this.HRLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReasonForVisit = new System.Windows.Forms.TextBox();
            this.txtHeartRate = new System.Windows.Forms.TextBox();
            this.txtBloodGlucose = new System.Windows.Forms.TextBox();
            this.txtRespiratoryRate = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtSBP = new System.Windows.Forms.TextBox();
            this.txtDBP = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.taAppointment_Correct2 = new Appointment_Management.DSAppointmentTableAdapters.Appointment_CorrectTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCorrectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientSurnameDataGridViewTextBoxColumn,
            this.patientPhoneNoDataGridViewTextBoxColumn,
            this.patientEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(120, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1600, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "Patient_Id";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Name";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientSurnameDataGridViewTextBoxColumn
            // 
            this.patientSurnameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Surname";
            this.patientSurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.patientSurnameDataGridViewTextBoxColumn.Name = "patientSurnameDataGridViewTextBoxColumn";
            this.patientSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientPhoneNoDataGridViewTextBoxColumn
            // 
            this.patientPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Patient_Phone_No";
            this.patientPhoneNoDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.patientPhoneNoDataGridViewTextBoxColumn.Name = "patientPhoneNoDataGridViewTextBoxColumn";
            this.patientPhoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientEmailDataGridViewTextBoxColumn
            // 
            this.patientEmailDataGridViewTextBoxColumn.DataPropertyName = "Patient_Email";
            this.patientEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.patientEmailDataGridViewTextBoxColumn.Name = "patientEmailDataGridViewTextBoxColumn";
            this.patientEmailDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.reasonForVisitDataGridViewTextBoxColumn,
            this.heartRateDataGridViewTextBoxColumn,
            this.bloodGlucoseDataGridViewTextBoxColumn,
            this.respiratoryRateDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.systolicBPDataGridViewTextBoxColumn,
            this.diastolicBPDataGridViewTextBoxColumn,
            this.Appt_No});
            this.dataGridView2.DataSource = this.appointmentCorrectBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(120, 435);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Size = new System.Drawing.Size(1600, 200);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonForVisitDataGridViewTextBoxColumn
            // 
            this.reasonForVisitDataGridViewTextBoxColumn.DataPropertyName = "Reason_For_Visit";
            this.reasonForVisitDataGridViewTextBoxColumn.HeaderText = "Reason For Visit";
            this.reasonForVisitDataGridViewTextBoxColumn.Name = "reasonForVisitDataGridViewTextBoxColumn";
            this.reasonForVisitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heartRateDataGridViewTextBoxColumn
            // 
            this.heartRateDataGridViewTextBoxColumn.DataPropertyName = "Heart_Rate";
            this.heartRateDataGridViewTextBoxColumn.HeaderText = "Heart Rate";
            this.heartRateDataGridViewTextBoxColumn.Name = "heartRateDataGridViewTextBoxColumn";
            this.heartRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bloodGlucoseDataGridViewTextBoxColumn
            // 
            this.bloodGlucoseDataGridViewTextBoxColumn.DataPropertyName = "Blood_Glucose";
            this.bloodGlucoseDataGridViewTextBoxColumn.HeaderText = "Blood Glucose";
            this.bloodGlucoseDataGridViewTextBoxColumn.Name = "bloodGlucoseDataGridViewTextBoxColumn";
            this.bloodGlucoseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // respiratoryRateDataGridViewTextBoxColumn
            // 
            this.respiratoryRateDataGridViewTextBoxColumn.DataPropertyName = "Respiratory_Rate";
            this.respiratoryRateDataGridViewTextBoxColumn.HeaderText = "Respiratory Rate";
            this.respiratoryRateDataGridViewTextBoxColumn.Name = "respiratoryRateDataGridViewTextBoxColumn";
            this.respiratoryRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // systolicBPDataGridViewTextBoxColumn
            // 
            this.systolicBPDataGridViewTextBoxColumn.DataPropertyName = "Systolic_BP";
            this.systolicBPDataGridViewTextBoxColumn.HeaderText = "Systolic BP";
            this.systolicBPDataGridViewTextBoxColumn.Name = "systolicBPDataGridViewTextBoxColumn";
            this.systolicBPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diastolicBPDataGridViewTextBoxColumn
            // 
            this.diastolicBPDataGridViewTextBoxColumn.DataPropertyName = "Diastolic_BP";
            this.diastolicBPDataGridViewTextBoxColumn.HeaderText = "Diastolic BP";
            this.diastolicBPDataGridViewTextBoxColumn.Name = "diastolicBPDataGridViewTextBoxColumn";
            this.diastolicBPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Appt_No
            // 
            this.Appt_No.DataPropertyName = "Appt_No";
            this.Appt_No.HeaderText = "Appt_No";
            this.Appt_No.Name = "Appt_No";
            this.Appt_No.ReadOnly = true;
            this.Appt_No.Visible = false;
            // 
            // appointmentCorrectBindingSource
            // 
            this.appointmentCorrectBindingSource.DataMember = "Appointment_Correct";
            this.appointmentCorrectBindingSource.DataSource = this.dSAppointment;
            // 
            // taPatient1
            // 
            this.taPatient1.ClearBeforeFill = true;
            // 
            // taAppointment_Correct1
            // 
            this.taAppointment_Correct1.ClearBeforeFill = true;
            // 
            // reasonForVisitLabel
            // 
            this.reasonForVisitLabel.AutoSize = true;
            this.reasonForVisitLabel.BackColor = System.Drawing.Color.White;
            this.reasonForVisitLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonForVisitLabel.Location = new System.Drawing.Point(315, 681);
            this.reasonForVisitLabel.Name = "reasonForVisitLabel";
            this.reasonForVisitLabel.Size = new System.Drawing.Size(120, 21);
            this.reasonForVisitLabel.TabIndex = 2;
            this.reasonForVisitLabel.Text = "Reason for Visit:";
            // 
            // HRLabel
            // 
            this.HRLabel.AutoSize = true;
            this.HRLabel.BackColor = System.Drawing.Color.White;
            this.HRLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRLabel.Location = new System.Drawing.Point(973, 681);
            this.HRLabel.Name = "HRLabel";
            this.HRLabel.Size = new System.Drawing.Size(91, 21);
            this.HRLabel.TabIndex = 3;
            this.HRLabel.Text = "Heart Rate: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 755);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blood Glucose: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(973, 747);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Respiratory rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 838);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Temperature: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(973, 808);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Systolic BP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 917);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Diastolic BP:";
            // 
            // txtReasonForVisit
            // 
            this.txtReasonForVisit.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonForVisit.Location = new System.Drawing.Point(471, 672);
            this.txtReasonForVisit.Multiline = true;
            this.txtReasonForVisit.Name = "txtReasonForVisit";
            this.txtReasonForVisit.Size = new System.Drawing.Size(250, 30);
            this.txtReasonForVisit.TabIndex = 9;
            // 
            // txtHeartRate
            // 
            this.txtHeartRate.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeartRate.Location = new System.Drawing.Point(1113, 675);
            this.txtHeartRate.Multiline = true;
            this.txtHeartRate.Name = "txtHeartRate";
            this.txtHeartRate.Size = new System.Drawing.Size(250, 30);
            this.txtHeartRate.TabIndex = 10;
            // 
            // txtBloodGlucose
            // 
            this.txtBloodGlucose.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodGlucose.Location = new System.Drawing.Point(471, 746);
            this.txtBloodGlucose.Multiline = true;
            this.txtBloodGlucose.Name = "txtBloodGlucose";
            this.txtBloodGlucose.Size = new System.Drawing.Size(250, 30);
            this.txtBloodGlucose.TabIndex = 11;
            // 
            // txtRespiratoryRate
            // 
            this.txtRespiratoryRate.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespiratoryRate.Location = new System.Drawing.Point(1113, 744);
            this.txtRespiratoryRate.Multiline = true;
            this.txtRespiratoryRate.Name = "txtRespiratoryRate";
            this.txtRespiratoryRate.Size = new System.Drawing.Size(250, 30);
            this.txtRespiratoryRate.TabIndex = 12;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(468, 829);
            this.txtTemperature.Multiline = true;
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(250, 30);
            this.txtTemperature.TabIndex = 13;
            // 
            // txtSBP
            // 
            this.txtSBP.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSBP.Location = new System.Drawing.Point(1113, 802);
            this.txtSBP.Multiline = true;
            this.txtSBP.Name = "txtSBP";
            this.txtSBP.Size = new System.Drawing.Size(250, 30);
            this.txtSBP.TabIndex = 14;
            // 
            // txtDBP
            // 
            this.txtDBP.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBP.Location = new System.Drawing.Point(468, 908);
            this.txtDBP.Multiline = true;
            this.txtDBP.Name = "txtDBP";
            this.txtDBP.Size = new System.Drawing.Size(250, 30);
            this.txtDBP.TabIndex = 15;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(1113, 917);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(200, 60);
            this.updateBtn.TabIndex = 16;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // taAppointment_Correct2
            // 
            this.taAppointment_Correct2.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(896, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 43);
            this.label1.TabIndex = 17;
            this.label1.Text = "Patient Vitals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(909, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Search by Patient Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPatient.Location = new System.Drawing.Point(840, 140);
            this.txtSearchPatient.Multiline = true;
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(300, 30);
            this.txtSearchPatient.TabIndex = 19;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1492, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1492, 716);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1492, 755);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1599, 685);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Below Range";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1600, 725);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Within Range";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1599, 769);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Above Range";
            // 
            // PatientVitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearchPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.txtDBP);
            this.Controls.Add(this.txtSBP);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtRespiratoryRate);
            this.Controls.Add(this.txtBloodGlucose);
            this.Controls.Add(this.txtHeartRate);
            this.Controls.Add(this.txtReasonForVisit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HRLabel);
            this.Controls.Add(this.reasonForVisitLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientVitals";
            this.Text = "PatientVitals";
            this.Load += new System.EventHandler(this.PatientVitals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCorrectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DSAppointment dSAppointment;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DSAppointmentTableAdapters.PatientTableAdapter taPatient1;
        private System.Windows.Forms.BindingSource appointmentCorrectBindingSource;
        private DSAppointmentTableAdapters.Appointment_CorrectTableAdapter taAppointment_Correct1;
        private System.Windows.Forms.Label reasonForVisitLabel;
        private System.Windows.Forms.Label HRLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReasonForVisit;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.TextBox txtBloodGlucose;
        private System.Windows.Forms.TextBox txtRespiratoryRate;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtSBP;
        private System.Windows.Forms.TextBox txtDBP;
        private System.Windows.Forms.Button updateBtn;
        private DSAppointmentTableAdapters.Appointment_CorrectTableAdapter taAppointment_Correct2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonForVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heartRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGlucoseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respiratoryRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systolicBPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diastolicBPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appt_No;
    }
}