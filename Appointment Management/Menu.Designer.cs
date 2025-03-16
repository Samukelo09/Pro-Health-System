
namespace Appointment_Management
{
    partial class MDIParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPateintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientVitalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payForAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.doctorsToolStripMenuItem,
            this.payForAppointmentToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1904, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addViewToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("appointmentsToolStripMenuItem.Image")));
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.appointmentsToolStripMenuItem_Click);
            // 
            // addViewToolStripMenuItem
            // 
            this.addViewToolStripMenuItem.Name = "addViewToolStripMenuItem";
            this.addViewToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.addViewToolStripMenuItem.Text = "Add/View";
            this.addViewToolStripMenuItem.Click += new System.EventHandler(this.addViewToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPateintToolStripMenuItem,
            this.patientDetailsToolStripMenuItem,
            this.patientVitalsToolStripMenuItem});
            this.patientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientsToolStripMenuItem.Image")));
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // addPateintToolStripMenuItem
            // 
            this.addPateintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addPateintToolStripMenuItem.Image")));
            this.addPateintToolStripMenuItem.Name = "addPateintToolStripMenuItem";
            this.addPateintToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.addPateintToolStripMenuItem.Text = "Add Patient";
            this.addPateintToolStripMenuItem.Click += new System.EventHandler(this.addPateintToolStripMenuItem_Click);
            // 
            // patientDetailsToolStripMenuItem
            // 
            this.patientDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientDetailsToolStripMenuItem.Image")));
            this.patientDetailsToolStripMenuItem.Name = "patientDetailsToolStripMenuItem";
            this.patientDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.patientDetailsToolStripMenuItem.Text = "Patient Details";
            this.patientDetailsToolStripMenuItem.Click += new System.EventHandler(this.patientDetailsToolStripMenuItem_Click);
            // 
            // patientVitalsToolStripMenuItem
            // 
            this.patientVitalsToolStripMenuItem.Name = "patientVitalsToolStripMenuItem";
            this.patientVitalsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.patientVitalsToolStripMenuItem.Text = "Patient Vitals";
            this.patientVitalsToolStripMenuItem.Click += new System.EventHandler(this.patientVitalsToolStripMenuItem_Click);
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorsToolStripMenuItem,
            this.deleteDoctorsToolStripMenuItem});
            this.doctorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorsToolStripMenuItem.Image")));
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            // 
            // addDoctorsToolStripMenuItem
            // 
            this.addDoctorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addDoctorsToolStripMenuItem.Image")));
            this.addDoctorsToolStripMenuItem.Name = "addDoctorsToolStripMenuItem";
            this.addDoctorsToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.addDoctorsToolStripMenuItem.Text = "Add Doctors";
            this.addDoctorsToolStripMenuItem.Click += new System.EventHandler(this.addDoctorsToolStripMenuItem_Click);
            // 
            // deleteDoctorsToolStripMenuItem
            // 
            this.deleteDoctorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteDoctorsToolStripMenuItem.Image")));
            this.deleteDoctorsToolStripMenuItem.Name = "deleteDoctorsToolStripMenuItem";
            this.deleteDoctorsToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.deleteDoctorsToolStripMenuItem.Text = "Doctor Details";
            this.deleteDoctorsToolStripMenuItem.Click += new System.EventHandler(this.deleteDoctorsToolStripMenuItem_Click);
            // 
            // payForAppointmentToolStripMenuItem
            // 
            this.payForAppointmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("payForAppointmentToolStripMenuItem.Image")));
            this.payForAppointmentToolStripMenuItem.Name = "payForAppointmentToolStripMenuItem";
            this.payForAppointmentToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.payForAppointmentToolStripMenuItem.Text = "Pay for Appointment";
            this.payForAppointmentToolStripMenuItem.Click += new System.EventHandler(this.payForAppointmentToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MDIParent";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPateintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payForAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientVitalsToolStripMenuItem;
    }
}

