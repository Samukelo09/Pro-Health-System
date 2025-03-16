namespace Appointment_Management
{
    partial class CancelAppt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelAppt));
            this.dgvAppt = new System.Windows.Forms.DataGridView();
            this.apptNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptTimeslotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentsINNERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAppointment1 = new Appointment_Management.DSAppointment();
            this.appointmentCorrectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taAppointment_Correct1 = new Appointment_Management.DSAppointmentTableAdapters.Appointment_CorrectTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.appointments_INNERTableAdapter = new Appointment_Management.DSAppointmentTableAdapters.Appointments_INNERTableAdapter();
            this.taAppointments_INNER1 = new Appointment_Management.DSAppointmentTableAdapters.Appointments_INNERTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dsAppointment2 = new Appointment_Management.DSAppointment();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsINNERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppointment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCorrectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppointment2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppt
            // 
            this.dgvAppt.AutoGenerateColumns = false;
            this.dgvAppt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAppt.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apptNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientSurnameDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.doctorSurnameDataGridViewTextBoxColumn,
            this.apptTimeslotIDDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn});
            this.dgvAppt.DataSource = this.appointmentsINNERBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppt.Location = new System.Drawing.Point(146, 249);
            this.dgvAppt.Name = "dgvAppt";
            this.dgvAppt.ReadOnly = true;
            this.dgvAppt.Size = new System.Drawing.Size(1600, 400);
            this.dgvAppt.TabIndex = 0;
            // 
            // apptNoDataGridViewTextBoxColumn
            // 
            this.apptNoDataGridViewTextBoxColumn.DataPropertyName = "Appt_No";
            this.apptNoDataGridViewTextBoxColumn.HeaderText = "Appointment No";
            this.apptNoDataGridViewTextBoxColumn.Name = "apptNoDataGridViewTextBoxColumn";
            this.apptNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Name";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientSurnameDataGridViewTextBoxColumn
            // 
            this.patientSurnameDataGridViewTextBoxColumn.DataPropertyName = "Patient_Surname";
            this.patientSurnameDataGridViewTextBoxColumn.HeaderText = "Patient Surname";
            this.patientSurnameDataGridViewTextBoxColumn.Name = "patientSurnameDataGridViewTextBoxColumn";
            this.patientSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Name";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "Doctor Name";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorSurnameDataGridViewTextBoxColumn
            // 
            this.doctorSurnameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Surname";
            this.doctorSurnameDataGridViewTextBoxColumn.HeaderText = "Doctor Surname";
            this.doctorSurnameDataGridViewTextBoxColumn.Name = "doctorSurnameDataGridViewTextBoxColumn";
            this.doctorSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apptTimeslotIDDataGridViewTextBoxColumn
            // 
            this.apptTimeslotIDDataGridViewTextBoxColumn.DataPropertyName = "Appt_Timeslot_ID";
            this.apptTimeslotIDDataGridViewTextBoxColumn.HeaderText = "Appointment Time";
            this.apptTimeslotIDDataGridViewTextBoxColumn.Name = "apptTimeslotIDDataGridViewTextBoxColumn";
            this.apptTimeslotIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "Doctor ID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient ID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentsINNERBindingSource
            // 
            this.appointmentsINNERBindingSource.DataMember = "Appointments_INNER";
            this.appointmentsINNERBindingSource.DataSource = this.dsAppointment1;
            // 
            // dsAppointment1
            // 
            this.dsAppointment1.DataSetName = "DSAppointment";
            this.dsAppointment1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentCorrectBindingSource
            // 
            this.appointmentCorrectBindingSource.DataMember = "Appointment_Correct";
            this.appointmentCorrectBindingSource.DataSource = this.dsAppointment1;
            // 
            // taAppointment_Correct1
            // 
            this.taAppointment_Correct1.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(844, 854);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(250, 60);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel Appointment";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // appointments_INNERTableAdapter
            // 
            this.appointments_INNERTableAdapter.ClearBeforeFill = true;
            // 
            // taAppointments_INNER1
            // 
            this.taAppointments_INNER1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(908, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by Patient Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(844, 168);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dsAppointment2
            // 
            this.dsAppointment2.DataSetName = "DSAppointment";
            this.dsAppointment2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cancel Appointment";
            // 
            // CancelAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvAppt);
            this.Name = "CancelAppt";
            this.ShowIcon = false;
            this.Text = "CancelAppt";
            this.Load += new System.EventHandler(this.CancelAppt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsINNERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppointment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCorrectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppointment2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppt;
        private System.Windows.Forms.BindingSource appointmentCorrectBindingSource;
        private DSAppointment dsAppointment1;
        private DSAppointmentTableAdapters.Appointment_CorrectTableAdapter taAppointment_Correct1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource appointmentsINNERBindingSource;
        private DSAppointmentTableAdapters.Appointments_INNERTableAdapter appointments_INNERTableAdapter;
        private DSAppointmentTableAdapters.Appointments_INNERTableAdapter taAppointments_INNER1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private DSAppointment dsAppointment2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptTimeslotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}