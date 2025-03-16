
namespace Appointment_Management
{
    partial class ApptPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApptPayment));
            this.dSAppointment = new Appointment_Management.DSAppointment();
            this.apptPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taPatient1 = new Appointment_Management.DSAppointmentTableAdapters.PatientTableAdapter();
            this.dgvAppt = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSurnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taApptPayment = new Appointment_Management.DSAppointmentTableAdapters.ApptPaymentTableAdapter();
            this.generatePaymentSlipBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apptPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppt)).BeginInit();
            this.SuspendLayout();
            // 
            // dSAppointment
            // 
            this.dSAppointment.DataSetName = "DSAppointment";
            this.dSAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apptPaymentBindingSource
            // 
            this.apptPaymentBindingSource.DataMember = "ApptPayment";
            this.apptPaymentBindingSource.DataSource = this.dSAppointment;
            // 
            // dgvPatient
            // 
            this.dgvPatient.AutoGenerateColumns = false;
            this.dgvPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPatient.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientSurnameDataGridViewTextBoxColumn,
            this.patientPhoneNoDataGridViewTextBoxColumn,
            this.patientEmailDataGridViewTextBoxColumn});
            this.dgvPatient.DataSource = this.patientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatient.GridColor = System.Drawing.Color.DarkGray;
            this.dgvPatient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvPatient.Location = new System.Drawing.Point(188, 263);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatient.RowHeadersWidth = 51;
            this.dgvPatient.Size = new System.Drawing.Size(1600, 264);
            this.dgvPatient.TabIndex = 2;
            this.dgvPatient.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPatient_RowHeaderMouseDoubleClick_1);
            this.dgvPatient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPatient_MouseClick);
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
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.dSAppointment;
            // 
            // taPatient1
            // 
            this.taPatient1.ClearBeforeFill = true;
            // 
            // dgvAppt
            // 
            this.dgvAppt.AutoGenerateColumns = false;
            this.dgvAppt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAppt.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn1,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.vATDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn,
            this.changeDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn1,
            this.patientSurnameDataGridViewTextBoxColumn1,
            this.doctorSurnameDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn});
            this.dgvAppt.DataSource = this.apptPaymentBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppt.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAppt.Location = new System.Drawing.Point(188, 555);
            this.dgvAppt.Name = "dgvAppt";
            this.dgvAppt.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppt.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAppt.RowHeadersWidth = 51;
            this.dgvAppt.Size = new System.Drawing.Size(1600, 315);
            this.dgvAppt.TabIndex = 1;
            this.dgvAppt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppt_CellContentClick);
            this.dgvAppt.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppt_RowHeaderMouseDoubleClick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn1
            // 
            this.patientIDDataGridViewTextBoxColumn1.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn1.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn1.Name = "patientIDDataGridViewTextBoxColumn1";
            this.patientIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.patientIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "Payment_Status";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "Payment Status";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vATDataGridViewTextBoxColumn
            // 
            this.vATDataGridViewTextBoxColumn.DataPropertyName = "VAT";
            this.vATDataGridViewTextBoxColumn.HeaderText = "VAT";
            this.vATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vATDataGridViewTextBoxColumn.Name = "vATDataGridViewTextBoxColumn";
            this.vATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Paid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "Amount Paid";
            this.amountPaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "Change";
            this.changeDataGridViewTextBoxColumn.HeaderText = "Change";
            this.changeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            this.changeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientNameDataGridViewTextBoxColumn1
            // 
            this.patientNameDataGridViewTextBoxColumn1.DataPropertyName = "Patient_Name";
            this.patientNameDataGridViewTextBoxColumn1.HeaderText = "Patient Name";
            this.patientNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn1.Name = "patientNameDataGridViewTextBoxColumn1";
            this.patientNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // patientSurnameDataGridViewTextBoxColumn1
            // 
            this.patientSurnameDataGridViewTextBoxColumn1.DataPropertyName = "Patient_Surname";
            this.patientSurnameDataGridViewTextBoxColumn1.HeaderText = "Patient Surname";
            this.patientSurnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.patientSurnameDataGridViewTextBoxColumn1.Name = "patientSurnameDataGridViewTextBoxColumn1";
            this.patientSurnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // doctorSurnameDataGridViewTextBoxColumn
            // 
            this.doctorSurnameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Surname";
            this.doctorSurnameDataGridViewTextBoxColumn.HeaderText = "Doctor Surname";
            this.doctorSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorSurnameDataGridViewTextBoxColumn.Name = "doctorSurnameDataGridViewTextBoxColumn";
            this.doctorSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Name";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "Doctor Name";
            this.doctorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taApptPayment
            // 
            this.taApptPayment.ClearBeforeFill = true;
            // 
            // generatePaymentSlipBtn
            // 
            this.generatePaymentSlipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.generatePaymentSlipBtn.FlatAppearance.BorderSize = 0;
            this.generatePaymentSlipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePaymentSlipBtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePaymentSlipBtn.ForeColor = System.Drawing.Color.White;
            this.generatePaymentSlipBtn.Location = new System.Drawing.Point(861, 922);
            this.generatePaymentSlipBtn.Name = "generatePaymentSlipBtn";
            this.generatePaymentSlipBtn.Size = new System.Drawing.Size(200, 60);
            this.generatePaymentSlipBtn.TabIndex = 3;
            this.generatePaymentSlipBtn.Text = "Generate Payment Slip";
            this.generatePaymentSlipBtn.UseVisualStyleBackColor = false;
            this.generatePaymentSlipBtn.Click += new System.EventHandler(this.generatePaymentSlipBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(842, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pay For Appointment";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(877, 190);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(932, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search By Name";
            // 
            // ApptPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatePaymentSlipBtn);
            this.Controls.Add(this.dgvPatient);
            this.Controls.Add(this.dgvAppt);
            this.Name = "ApptPayment";
            this.Text = "ApptPayment";
            this.Load += new System.EventHandler(this.ApptPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apptPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DSAppointment dSAppointment;
        private System.Windows.Forms.BindingSource apptPaymentBindingSource;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DSAppointmentTableAdapters.PatientTableAdapter taPatient1;
        private System.Windows.Forms.DataGridView dgvAppt;
        private DSAppointmentTableAdapters.ApptPaymentTableAdapter taApptPayment;
        private System.Windows.Forms.Button generatePaymentSlipBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSurnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}