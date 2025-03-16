using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Management
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }
        public void PrepareForm(Form f)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addPateintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPateintToolStripMenuItem.Enabled = false;
            AddPatientInfo addPatientForm = new AddPatientInfo();
            PrepareForm(addPatientForm);
            patientVitalsToolStripMenuItem.Enabled = true;
            cancelToolStripMenuItem.Enabled = true;
            patientDetailsToolStripMenuItem.Enabled = true;
            deleteDoctorsToolStripMenuItem.Enabled = true;
            homeToolStripMenuItem.Enabled = true;
            payForAppointmentToolStripMenuItem.Enabled = true;
            addDoctorsToolStripMenuItem.Enabled = true;
            addViewToolStripMenuItem.Enabled = true;
        }

        private void deletePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAndUpdatePatient deleteAndUpdatePatientForm = new DeleteAndUpdatePatient();
            PrepareForm(deleteAndUpdatePatientForm);
        }

        private void addAppointmentCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           MainMenu defaultMenu = new MainMenu();
           PrepareForm(defaultMenu);
            homeToolStripMenuItem.Enabled = false;
        }

        private void addDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addDoctorsToolStripMenuItem.Enabled = false;
            AddDoctorForm addDoctor = new AddDoctorForm();
            PrepareForm(addDoctor);
            patientVitalsToolStripMenuItem.Enabled = true;;
            cancelToolStripMenuItem.Enabled = true;
            patientDetailsToolStripMenuItem.Enabled = true;
            deleteDoctorsToolStripMenuItem.Enabled = true;
            homeToolStripMenuItem.Enabled = true;
            payForAppointmentToolStripMenuItem.Enabled = true;
            addViewToolStripMenuItem.Enabled = true;
        }

        private void deleteDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteDoctorsToolStripMenuItem.Enabled = false;
            UpdateDrInfo drInfo = new UpdateDrInfo();
            PrepareForm(drInfo);
            patientVitalsToolStripMenuItem.Enabled = true;
            addPateintToolStripMenuItem.Enabled = true;
            cancelToolStripMenuItem.Enabled = true;
            patientDetailsToolStripMenuItem.Enabled = true;
            homeToolStripMenuItem.Enabled = true;
            payForAppointmentToolStripMenuItem.Enabled = true;
            addDoctorsToolStripMenuItem.Enabled = true;
            addViewToolStripMenuItem.Enabled = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void payForAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payForAppointmentToolStripMenuItem.Enabled = false;
            ApptPayment ap = new ApptPayment();
            PrepareForm(ap);
            patientVitalsToolStripMenuItem.Enabled = true;
            addPateintToolStripMenuItem.Enabled = true;
            cancelToolStripMenuItem.Enabled = true;
            patientDetailsToolStripMenuItem.Enabled = true;
            deleteDoctorsToolStripMenuItem.Enabled = true;
            homeToolStripMenuItem.Enabled = true;
            addDoctorsToolStripMenuItem.Enabled = true;
            addViewToolStripMenuItem.Enabled = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeToolStripMenuItem.Enabled = false;
            MainMenu mainMenu = new MainMenu();
            PrepareForm(mainMenu);
            patientVitalsToolStripMenuItem.Enabled = true;
            addPateintToolStripMenuItem.Enabled = true;
            cancelToolStripMenuItem.Enabled = true;
            patientDetailsToolStripMenuItem.Enabled = true;
            deleteDoctorsToolStripMenuItem.Enabled = true;
            homeToolStripMenuItem.Enabled = true;
            payForAppointmentToolStripMenuItem.Enabled = true;
            addDoctorsToolStripMenuItem.Enabled = true;
            addViewToolStripMenuItem.Enabled = true;
        }

        private void patientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientDetailsToolStripMenuItem.Enabled = false;
            DeleteAndUpdatePatient deleteAndUpdatePatient = new DeleteAndUpdatePatient();
            PrepareForm(deleteAndUpdatePatient);
            patientVitalsToolStripMenuItem.Enabled = true;
            addPateintToolStripMenuItem.Enabled = true;
            cancelToolStripMenuItem.Enabled = true;
            deleteDoctorsToolStripMenuItem.Enabled = true;
            homeToolStripMenuItem.Enabled = true;
            payForAppointmentToolStripMenuItem.Enabled = true;
            addDoctorsToolStripMenuItem.Enabled = true;
            addViewToolStripMenuItem.Enabled = true;
        }

        private void addViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar calendar = Calendar.Instance;
            PrepareForm(calendar);
            addViewToolStripMenuItem.Enabled = false;
            patientVitalsToolStripMenuItem.Enabled = true;
            addPateintToolStripMenuItem.Enabled = true;
            cancelToolStripMenuItem.Enabled = true;
            patientDetailsToolStripMenuItem.Enabled = true;
            deleteDoctorsToolStripMenuItem.Enabled = true;
            homeToolStripMenuItem.Enabled = true;
            payForAppointmentToolStripMenuItem.Enabled = true;
            addDoctorsToolStripMenuItem.Enabled = true;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelAppt cancelAppt = new CancelAppt();
            PrepareForm(cancelAppt);
            cancelToolStripMenuItem.Enabled = false;
            patientVitalsToolStripMenuItem.Enabled = true;
            addPateintToolStripMenuItem.Enabled = true;
            patientDetailsToolStripMenuItem.Enabled = true;
            deleteDoctorsToolStripMenuItem.Enabled = true;
            homeToolStripMenuItem.Enabled = true;
            payForAppointmentToolStripMenuItem.Enabled = true;
            addDoctorsToolStripMenuItem.Enabled = true;
            addViewToolStripMenuItem.Enabled = true;
        }

        private void patientVitalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientVitals patientVitals = new PatientVitals();
            PrepareForm(patientVitals);
            patientVitalsToolStripMenuItem.Enabled = false;
            addPateintToolStripMenuItem.Enabled = true;
            cancelToolStripMenuItem.Enabled = true;
            patientDetailsToolStripMenuItem.Enabled = true;
            deleteDoctorsToolStripMenuItem.Enabled = true;
            homeToolStripMenuItem.Enabled = true;
            payForAppointmentToolStripMenuItem.Enabled = true;
            addDoctorsToolStripMenuItem.Enabled = true;
            addViewToolStripMenuItem.Enabled = true;
        }
    }
}
