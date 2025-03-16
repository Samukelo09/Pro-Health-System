
namespace Appointment_Management
{
    partial class AddDoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDoctorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDrSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDrPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDrEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drDOBdatetime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRecordDr = new System.Windows.Forms.Button();
            this.gbDrInfo = new System.Windows.Forms.GroupBox();
            this.txtDocName = new System.Windows.Forms.TextBox();
            this.specialtyCb = new System.Windows.Forms.ComboBox();
            this.specialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAppointment = new Appointment_Management.DSAppointment();
            this.label8 = new System.Windows.Forms.Label();
            this.rdBtnFemale = new System.Windows.Forms.RadioButton();
            this.rdBtnMale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.doctorTableAdapter1 = new Appointment_Management.DSAppointmentTableAdapters.DoctorTableAdapter();
            this.specialtyTableAdapter = new Appointment_Management.DSAppointmentTableAdapters.SpecialtyTableAdapter();
            this.gbDrInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(938, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtDrSurname
            // 
            this.txtDrSurname.Location = new System.Drawing.Point(305, 136);
            this.txtDrSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDrSurname.Name = "txtDrSurname";
            this.txtDrSurname.Size = new System.Drawing.Size(1000, 29);
            this.txtDrSurname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname";
            // 
            // txtDrPhone
            // 
            this.txtDrPhone.Location = new System.Drawing.Point(305, 217);
            this.txtDrPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDrPhone.Name = "txtDrPhone";
            this.txtDrPhone.Size = new System.Drawing.Size(1000, 29);
            this.txtDrPhone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone No";
            // 
            // txtDrEmail
            // 
            this.txtDrEmail.Location = new System.Drawing.Point(305, 287);
            this.txtDrEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDrEmail.Name = "txtDrEmail";
            this.txtDrEmail.Size = new System.Drawing.Size(1000, 29);
            this.txtDrEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // drDOBdatetime
            // 
            this.drDOBdatetime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drDOBdatetime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.drDOBdatetime.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.drDOBdatetime.Location = new System.Drawing.Point(305, 444);
            this.drDOBdatetime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drDOBdatetime.Name = "drDOBdatetime";
            this.drDOBdatetime.Size = new System.Drawing.Size(747, 29);
            this.drDOBdatetime.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 444);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date Of Birth";
            // 
            // btnRecordDr
            // 
            this.btnRecordDr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.btnRecordDr.FlatAppearance.BorderSize = 0;
            this.btnRecordDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordDr.ForeColor = System.Drawing.Color.White;
            this.btnRecordDr.Location = new System.Drawing.Point(1119, 672);
            this.btnRecordDr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecordDr.Name = "btnRecordDr";
            this.btnRecordDr.Size = new System.Drawing.Size(200, 60);
            this.btnRecordDr.TabIndex = 11;
            this.btnRecordDr.Text = "Record Doctor";
            this.btnRecordDr.UseVisualStyleBackColor = false;
            this.btnRecordDr.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbDrInfo
            // 
            this.gbDrInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDrInfo.BackColor = System.Drawing.Color.White;
            this.gbDrInfo.Controls.Add(this.txtDocName);
            this.gbDrInfo.Controls.Add(this.specialtyCb);
            this.gbDrInfo.Controls.Add(this.label8);
            this.gbDrInfo.Controls.Add(this.rdBtnFemale);
            this.gbDrInfo.Controls.Add(this.rdBtnMale);
            this.gbDrInfo.Controls.Add(this.label7);
            this.gbDrInfo.Controls.Add(this.drDOBdatetime);
            this.gbDrInfo.Controls.Add(this.btnRecordDr);
            this.gbDrInfo.Controls.Add(this.txtDrEmail);
            this.gbDrInfo.Controls.Add(this.label2);
            this.gbDrInfo.Controls.Add(this.txtDrPhone);
            this.gbDrInfo.Controls.Add(this.label6);
            this.gbDrInfo.Controls.Add(this.txtDrSurname);
            this.gbDrInfo.Controls.Add(this.label3);
            this.gbDrInfo.Controls.Add(this.label4);
            this.gbDrInfo.Controls.Add(this.label5);
            this.gbDrInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDrInfo.Location = new System.Drawing.Point(143, 118);
            this.gbDrInfo.Name = "gbDrInfo";
            this.gbDrInfo.Size = new System.Drawing.Size(1600, 800);
            this.gbDrInfo.TabIndex = 12;
            this.gbDrInfo.TabStop = false;
            this.gbDrInfo.Text = "Doctor Details";
            // 
            // txtDocName
            // 
            this.txtDocName.Location = new System.Drawing.Point(305, 65);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new System.Drawing.Size(1000, 29);
            this.txtDocName.TabIndex = 17;
            // 
            // specialtyCb
            // 
            this.specialtyCb.DataSource = this.specialtyBindingSource;
            this.specialtyCb.DisplayMember = "Specialty_Name";
            this.specialtyCb.FormattingEnabled = true;
            this.specialtyCb.Location = new System.Drawing.Point(305, 540);
            this.specialtyCb.Name = "specialtyCb";
            this.specialtyCb.Size = new System.Drawing.Size(747, 32);
            this.specialtyCb.TabIndex = 16;
            this.specialtyCb.ValueMember = "Specialty_ID";
            // 
            // specialtyBindingSource
            // 
            this.specialtyBindingSource.DataMember = "Specialty";
            this.specialtyBindingSource.DataSource = this.dSAppointment;
            // 
            // dSAppointment
            // 
            this.dSAppointment.DataSetName = "DSAppointment";
            this.dSAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 535);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Specialty";
            // 
            // rdBtnFemale
            // 
            this.rdBtnFemale.AutoSize = true;
            this.rdBtnFemale.Location = new System.Drawing.Point(305, 396);
            this.rdBtnFemale.Name = "rdBtnFemale";
            this.rdBtnFemale.Size = new System.Drawing.Size(90, 28);
            this.rdBtnFemale.TabIndex = 14;
            this.rdBtnFemale.TabStop = true;
            this.rdBtnFemale.Text = "Female";
            this.rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdBtnMale
            // 
            this.rdBtnMale.AutoSize = true;
            this.rdBtnMale.Location = new System.Drawing.Point(305, 358);
            this.rdBtnMale.Name = "rdBtnMale";
            this.rdBtnMale.Size = new System.Drawing.Size(68, 28);
            this.rdBtnMale.TabIndex = 13;
            this.rdBtnMale.TabStop = true;
            this.rdBtnMale.Text = "Male";
            this.rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 349);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sex";
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // specialtyTableAdapter
            // 
            this.specialtyTableAdapter.ClearBeforeFill = true;
            // 
            // AddDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDrInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddDoctorForm";
            this.Text = "Add Doctor";
            this.Load += new System.EventHandler(this.AddDoctorForm_Load);
            this.gbDrInfo.ResumeLayout(false);
            this.gbDrInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDrSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDrPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDrEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker drDOBdatetime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRecordDr;
        private DSAppointmentTableAdapters.DoctorTableAdapter doctorTableAdapter1;
        private System.Windows.Forms.GroupBox gbDrInfo;
        private System.Windows.Forms.ComboBox specialtyCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdBtnFemale;
        private System.Windows.Forms.RadioButton rdBtnMale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocName;
        private DSAppointment dSAppointment;
        private System.Windows.Forms.BindingSource specialtyBindingSource;
        private DSAppointmentTableAdapters.SpecialtyTableAdapter specialtyTableAdapter;
    }
}