
namespace Appointment_Management
{
    partial class AddPatientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientInfo));
            this.AddPatientInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.femaleRadBtn = new System.Windows.Forms.RadioButton();
            this.maleRadBtn = new System.Windows.Forms.RadioButton();
            this.datetimePatient = new System.Windows.Forms.DateTimePicker();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddPatientEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddPatientPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddPatientSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddPatientName = new System.Windows.Forms.TextBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppointment = new Appointment_Management.DSAppointment();
            this.patientTableAdapter = new Appointment_Management.DSAppointmentTableAdapters.PatientTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.AddPatientInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPatientInfoGroupBox
            // 
            this.AddPatientInfoGroupBox.BackColor = System.Drawing.Color.White;
            this.AddPatientInfoGroupBox.Controls.Add(this.label6);
            this.AddPatientInfoGroupBox.Controls.Add(this.femaleRadBtn);
            this.AddPatientInfoGroupBox.Controls.Add(this.maleRadBtn);
            this.AddPatientInfoGroupBox.Controls.Add(this.datetimePatient);
            this.AddPatientInfoGroupBox.Controls.Add(this.AddPatientButton);
            this.AddPatientInfoGroupBox.Controls.Add(this.label5);
            this.AddPatientInfoGroupBox.Controls.Add(this.label4);
            this.AddPatientInfoGroupBox.Controls.Add(this.txtaddPatientEmail);
            this.AddPatientInfoGroupBox.Controls.Add(this.label3);
            this.AddPatientInfoGroupBox.Controls.Add(this.txtAddPatientPhone);
            this.AddPatientInfoGroupBox.Controls.Add(this.label2);
            this.AddPatientInfoGroupBox.Controls.Add(this.txtAddPatientSurname);
            this.AddPatientInfoGroupBox.Controls.Add(this.label1);
            this.AddPatientInfoGroupBox.Controls.Add(this.txtAddPatientName);
            this.AddPatientInfoGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientInfoGroupBox.Location = new System.Drawing.Point(70, 122);
            this.AddPatientInfoGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPatientInfoGroupBox.Name = "AddPatientInfoGroupBox";
            this.AddPatientInfoGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPatientInfoGroupBox.Size = new System.Drawing.Size(1600, 800);
            this.AddPatientInfoGroupBox.TabIndex = 0;
            this.AddPatientInfoGroupBox.TabStop = false;
            this.AddPatientInfoGroupBox.Text = "Add Patient Information";
            this.AddPatientInfoGroupBox.Enter += new System.EventHandler(this.AddPatientInfoGroupBox_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 453);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sex";
            // 
            // femaleRadBtn
            // 
            this.femaleRadBtn.AutoSize = true;
            this.femaleRadBtn.Location = new System.Drawing.Point(293, 493);
            this.femaleRadBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.femaleRadBtn.Name = "femaleRadBtn";
            this.femaleRadBtn.Size = new System.Drawing.Size(90, 28);
            this.femaleRadBtn.TabIndex = 14;
            this.femaleRadBtn.TabStop = true;
            this.femaleRadBtn.Text = "Female";
            this.femaleRadBtn.UseVisualStyleBackColor = true;
            // 
            // maleRadBtn
            // 
            this.maleRadBtn.AutoSize = true;
            this.maleRadBtn.Location = new System.Drawing.Point(293, 449);
            this.maleRadBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maleRadBtn.Name = "maleRadBtn";
            this.maleRadBtn.Size = new System.Drawing.Size(68, 28);
            this.maleRadBtn.TabIndex = 13;
            this.maleRadBtn.TabStop = true;
            this.maleRadBtn.Text = "Male";
            this.maleRadBtn.UseVisualStyleBackColor = true;
            // 
            // datetimePatient
            // 
            this.datetimePatient.Location = new System.Drawing.Point(293, 365);
            this.datetimePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetimePatient.Name = "datetimePatient";
            this.datetimePatient.Size = new System.Drawing.Size(710, 28);
            this.datetimePatient.TabIndex = 12;
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.AddPatientButton.FlatAppearance.BorderSize = 0;
            this.AddPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPatientButton.ForeColor = System.Drawing.Color.White;
            this.AddPatientButton.Location = new System.Drawing.Point(1093, 685);
            this.AddPatientButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(200, 60);
            this.AddPatientButton.TabIndex = 10;
            this.AddPatientButton.Text = "Add Patient";
            this.AddPatientButton.UseVisualStyleBackColor = false;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txtaddPatientEmail
            // 
            this.txtaddPatientEmail.Location = new System.Drawing.Point(293, 284);
            this.txtaddPatientEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtaddPatientEmail.Name = "txtaddPatientEmail";
            this.txtaddPatientEmail.Size = new System.Drawing.Size(1000, 28);
            this.txtaddPatientEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // txtAddPatientPhone
            // 
            this.txtAddPatientPhone.Location = new System.Drawing.Point(293, 211);
            this.txtAddPatientPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddPatientPhone.Name = "txtAddPatientPhone";
            this.txtAddPatientPhone.Size = new System.Drawing.Size(1000, 28);
            this.txtAddPatientPhone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // txtAddPatientSurname
            // 
            this.txtAddPatientSurname.Location = new System.Drawing.Point(293, 144);
            this.txtAddPatientSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddPatientSurname.Name = "txtAddPatientSurname";
            this.txtAddPatientSurname.Size = new System.Drawing.Size(1000, 28);
            this.txtAddPatientSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtAddPatientName
            // 
            this.txtAddPatientName.Location = new System.Drawing.Point(293, 82);
            this.txtAddPatientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddPatientName.Name = "txtAddPatientName";
            this.txtAddPatientName.Size = new System.Drawing.Size(1000, 28);
            this.txtAddPatientName.TabIndex = 0;
            this.txtAddPatientName.TextChanged += new System.EventHandler(this.txtAddPatientName_TextChanged);
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
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(832, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 44);
            this.label7.TabIndex = 1;
            this.label7.Text = "Add Patient";
            // 
            // AddPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddPatientInfoGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddPatientInfo";
            this.Text = "AddPatient";
            this.Load += new System.EventHandler(this.AddPatientInfo_Load);
            this.AddPatientInfoGroupBox.ResumeLayout(false);
            this.AddPatientInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AddPatientInfoGroupBox;
        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaddPatientEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddPatientPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddPatientSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddPatientName;
        private DSAppointment dSAppointment;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private DSAppointmentTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DateTimePicker datetimePatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton femaleRadBtn;
        private System.Windows.Forms.RadioButton maleRadBtn;
        private System.Windows.Forms.Label label7;
    }
}