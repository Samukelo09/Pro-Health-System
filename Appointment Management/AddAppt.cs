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
    public partial class AddAppointment : Form
    {
        string printName;
        bool addPatientBtnState = false;
        public event Action<string> PatientAdded;
        string btnText;
        int rState;
        
        Calendar calendar1;

        // Static instance variable to hold the single instance
        private static AddAppointment instance = null;

        // Object for locking to ensure thread safety
        private static readonly object padlock = new object();

        // Private constructor to prevent instantiation
        private AddAppointment()
        {
            InitializeComponent();


        }

        // Static method to provide global access point
        public static AddAppointment Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new AddAppointment();
                    }
                    return instance;
                }
            }
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            this.specialtyTableAdapter.Fill(this.dSAppointment.Specialty);
            // TODO: This line of code loads data into the 'dSAppointment.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.dSAppointment.Patient);
            this.timeslotTableAdapter.Fill(this.dSAppointment.Timeslot);
        }
    
        

        private void searchFieldTextBox_TextChanged_1(object sender, EventArgs e)
        {
            patientTableAdapter1.FillByName(dSAppointment.Patient, searchFieldTextBox.Text);
        }

        private void patientDataGridView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            patientNameTextBox.Text = patientDataGridView.CurrentRow.Cells[1].Value.ToString();
            patientSurnameTextBox.Text = patientDataGridView.CurrentRow.Cells[2].Value.ToString();
        }



       

        private void addApptPatientBtn_Click(object sender, EventArgs e)
        {
            addPatientBtnState = true;

            calendar1 = Calendar.Instance;

            string printName = $"{patientDataGridView.CurrentRow.Cells[1].Value} {patientDataGridView.CurrentRow.Cells[2].Value}";
            string aPatientID = patientDataGridView.CurrentRow.Cells[0].Value.ToString();
            int aTimeSlotID = calendar1.getTimeSlotID();
            

            int aDoctorID;
            
            // Get the selected date from the calendar
            DateTime aSelectedDate = calendar1.getDate();

            
            string selectedSpecialty = string.Empty;
            
            aDoctorID = rState;






            DialogResult result = MessageBox.Show("Do you want to add this appointment?", "Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {

                calendar1.initName = printName;

                taAppointmentCorrect1.InsertQuery(aSelectedDate.ToString("yyyy-MM-dd"), Convert.ToInt32(aTimeSlotID), Convert.ToInt32(aDoctorID), Convert.ToInt32(aPatientID), null, null, null, null, null);
                MessageBox.Show("The appointment has been added.");
                btnText = printName;
                calendar1.PatientAdded(printName, aTimeSlotID);


                //Trigger event
                PatientAdded?.Invoke(printName);

            }
            else
            {
                MessageBox.Show("The appointment has not been added.");
            }



            this.Hide();
        }

        public string getButtonText()
        {
            return btnText;
        }

        public void setRState(int rState1)
        {
            rState = rState1;
        }

        
        
    }
}
