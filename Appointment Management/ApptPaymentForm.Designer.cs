
namespace Appointment_Management
{
    partial class ApptPaymentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apptNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptTimeslotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptPriceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentCorrectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppointment = new Appointment_Management.DSAppointment();
            this.button1 = new System.Windows.Forms.Button();
            this.appointment_CorrectTableAdapter = new Appointment_Management.DSAppointmentTableAdapters.Appointment_CorrectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCorrectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1277, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apptNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.apptTimeslotIDDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.bookingStatusIDDataGridViewTextBoxColumn,
            this.apptStatusIDDataGridViewTextBoxColumn,
            this.apptPriceIDDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentCorrectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(371, 213);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1867, 738);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // apptNoDataGridViewTextBoxColumn
            // 
            this.apptNoDataGridViewTextBoxColumn.DataPropertyName = "Appt_No";
            this.apptNoDataGridViewTextBoxColumn.HeaderText = "Appt_No";
            this.apptNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apptNoDataGridViewTextBoxColumn.Name = "apptNoDataGridViewTextBoxColumn";
            this.apptNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apptNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // apptTimeslotIDDataGridViewTextBoxColumn
            // 
            this.apptTimeslotIDDataGridViewTextBoxColumn.DataPropertyName = "Appt_Timeslot_ID";
            this.apptTimeslotIDDataGridViewTextBoxColumn.HeaderText = "Appt_Timeslot_ID";
            this.apptTimeslotIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apptTimeslotIDDataGridViewTextBoxColumn.Name = "apptTimeslotIDDataGridViewTextBoxColumn";
            this.apptTimeslotIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient_ID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingStatusIDDataGridViewTextBoxColumn
            // 
            this.bookingStatusIDDataGridViewTextBoxColumn.DataPropertyName = "Booking_Status_ID";
            this.bookingStatusIDDataGridViewTextBoxColumn.HeaderText = "Booking_Status_ID";
            this.bookingStatusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingStatusIDDataGridViewTextBoxColumn.Name = "bookingStatusIDDataGridViewTextBoxColumn";
            this.bookingStatusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // apptStatusIDDataGridViewTextBoxColumn
            // 
            this.apptStatusIDDataGridViewTextBoxColumn.DataPropertyName = "Appt_Status_ID";
            this.apptStatusIDDataGridViewTextBoxColumn.HeaderText = "Appt_Status_ID";
            this.apptStatusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apptStatusIDDataGridViewTextBoxColumn.Name = "apptStatusIDDataGridViewTextBoxColumn";
            this.apptStatusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // apptPriceIDDataGridViewTextBoxColumn
            // 
            this.apptPriceIDDataGridViewTextBoxColumn.DataPropertyName = "Appt_Price_ID";
            this.apptPriceIDDataGridViewTextBoxColumn.HeaderText = "Appt_Price_ID";
            this.apptPriceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apptPriceIDDataGridViewTextBoxColumn.Name = "apptPriceIDDataGridViewTextBoxColumn";
            this.apptPriceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "Payment_Status";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "Payment_Status";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Paid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "Amount_Paid";
            this.amountPaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.Width = 125;
            // 
            // appointmentCorrectBindingSource
            // 
            this.appointmentCorrectBindingSource.DataMember = "Appointment_Correct";
            this.appointmentCorrectBindingSource.DataSource = this.dSAppointment;
            // 
            // dSAppointment
            // 
            this.dSAppointment.DataSetName = "DSAppointment";
            this.dSAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 1094);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print Receipt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // appointment_CorrectTableAdapter
            // 
            this.appointment_CorrectTableAdapter.ClearBeforeFill = true;
            // 
            // ApptPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApptPaymentForm";
            this.Text = "ApptPaymentForm";
            this.Load += new System.EventHandler(this.ApptPaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCorrectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DSAppointment dSAppointment;
        private System.Windows.Forms.BindingSource appointmentCorrectBindingSource;
        private DSAppointmentTableAdapters.Appointment_CorrectTableAdapter appointment_CorrectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptTimeslotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptPriceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
    }
}