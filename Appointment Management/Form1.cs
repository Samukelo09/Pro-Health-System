using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Management
{
    /// <summary>
    /// 1. The objects are disposing themselves. (Calendar, Add Appointment)
    /// Solution: Recreate the objects
    /// 2. Cancelling of appointments is working, but when I toggle, the color comes back.
    /// 
    /// 
    /// 
    /// 3. When the date of the appointment has passed, then the appointment needs to automatically delete itself.
    /// 4. When the time of the appointment has passed, then the appointment needs to automatically delete itself.
    /// 
    /// 5. When an object is deleted, create a new instance where you need it.
    /// </summary>
    public partial class Calendar : Form
    {
        public string initName { get; set; }
        private static Calendar instance;
        string printName1 = "";
        private DateTime selectedDate;
        private bool isPatientAddedForSelectedDate = false;
        public bool color = false;

        int slotID;
        public DateTime apptDate;
        Color tsColor; // Blue
        Color tsColor1; // Red
        bool btnEnable = true;
        bool apptCancellable = false;

        DateTime currentDate = DateTime.Today;

        int deletionApptNo;
        bool deleted = false;

        int tglID;
        string tglName;

        string globalName = "";

        string[] printnames = new string[16];

        public static Calendar Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Calendar();
                }
                return instance;
            }
        }
        private Calendar()
        {
            InitializeComponent();
            initializeHexColor();
            selectedDate = monthCalendar1.SelectionStart.Date;  // Initialize selected date with today's date

        }

        private void initializeHexColor()
        {
            string tsHexColor = "#38B6F4";
            tsColor = ColorTranslator.FromHtml(tsHexColor);
            string tsHexColor1 = "#F43232";
            tsColor1 = ColorTranslator.FromHtml(tsHexColor1);
        }


        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Calendar_Load(object sender, EventArgs e)
        {


            updateByDateAndDoctor();

        }

        private void panel15_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel15_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel15_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeslot1Label_Click(object sender, EventArgs e)
        {
            
        }
      
        private void timeslot1Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 1;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }

        }

        public void PatientAdded(string printName, int tsID)
        {
            

            switch(tsID)
            {
                case 1:
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(1);
                    timeslot1Btn.BackColor = tsColor;
                    timeslot1Btn.Text = printName;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 2:
                    timeslot2Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(2);
                    timeslot2Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 3:
                    timeslot3Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(3);
                    timeslot3Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 4:
                    timeslot4Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(4);
                    timeslot4Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 5:
                    timeslot5Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(5);
                    timeslot5Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 6:
                    timeslot6Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(6);
                    timeslot6Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 7:
                    timeslot7Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(7);
                    timeslot7Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 8:
                    timeslot8Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(8);
                    timeslot8Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 9:
                    timeslot9Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(9);
                    timeslot9Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 10:
                    timeslot10Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(10);
                    timeslot10Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 11:
                    timeslot11Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(11);
                    timeslot11Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 12:
                    timeslot12Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(12);
                    timeslot12Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 13:
                    timeslot13Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(13);
                    timeslot13Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 14:
                    timeslot14Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(14);
                    timeslot14Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 15:
                    timeslot15Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(15);
                    timeslot15Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
                case 16:
                    timeslot16Btn.Text = printName;
                    globalName = printName;
                    printName1 = printName;
                    UpdateTimeslotButton(16);
                    timeslot16Btn.BackColor = tsColor;
                    isPatientAddedForSelectedDate = true;
                    break;
            }

        }

        public void UpdateTimeslotButton(int sID) 
        {

            switch (sID)
            {
                
                case 1:
                    printName1 = globalName;
                    timeslot1Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot1Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 2:
                    printName1 = globalName;
                    timeslot2Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot2Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 3:
                    printName1 = globalName;
                    timeslot3Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot3Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 4:
                    printName1 = globalName;
                    timeslot4Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot4Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 5:
                    printName1 = globalName;
                    timeslot5Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot5Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 6:
                    printName1 = globalName;
                    timeslot6Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot6Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 7:
                    printName1 = globalName;
                    timeslot7Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot7Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 8:
                    printName1 = globalName;
                    timeslot8Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot8Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 9:
                    printName1 = globalName;
                    timeslot9Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot9Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 10:
                    printName1 = globalName;
                    timeslot10Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot10Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 11:
                    printName1 = globalName;
                    timeslot11Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot11Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 12:
                    printName1 = globalName;
                    timeslot12Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot12Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 13:
                    printName1 = globalName;
                    timeslot13Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot13Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 14:
                    printName1 = globalName;
                    timeslot14Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot14Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 15:
                    printName1 = globalName;
                    timeslot15Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot15Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
                case 16:
                    printName1 = globalName;
                    timeslot16Btn.Enabled = string.IsNullOrEmpty(printName1);
                    timeslot16Btn.BackColor = string.IsNullOrEmpty(printName1) ? Color.White : tsColor;
                    break;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            taAppointment_Correct2.Fill(dSAppointment.Appointment_Correct);
            selectedDate = monthCalendar1.SelectionStart.Date; // Update selected date
            int doctorID = radioState();

            // Fetch appointments for the selected date
            taAppointment_Correct2.FillByDateAndDoctor(dSAppointment.Appointment_Correct, selectedDate.ToString(), doctorID);

            // Clear timeslot buttons
            for (int i = 1; i < 17; i++)
            {
                ClearTimeslotButtons(i);
            }

            foreach (DataRow row in dSAppointment.Appointment_Correct.Rows)
            {
                int patientId = Convert.ToInt32(row["Patient_ID"]);

                // Fill the Patient table with the specific patient ID
                taPatient2.FillByPatientID(dSAppointment.Patient, patientId);

                // Assuming the Patient table has columns "Patient_Name" and "Patient_Surname"
                DataRow patientRow = dSAppointment.Patient.Rows[0];
                string patientName = $"{patientRow["Patient_Name"]} {patientRow["Patient_Surname"]}";

                int slotId = Convert.ToInt32(row["Appt_Timeslot_ID"]);

                // Update the timeslot button with the patient's name
                UpdateTimeslotButton(slotId, patientName);
            }
        }

        private void ClearTimeslotButtons(int sID)
        {
            switch (sID)
            {
                case 1:
                    timeslot1Btn.Text = "";
                    timeslot1Btn.Enabled = true;
                    timeslot1Btn.BackColor = Color.White;
                    break;
                case 2:
                    timeslot2Btn.Text = "";
                    timeslot2Btn.Enabled = true;
                    timeslot2Btn.BackColor = Color.White;
                    break;
                case 3:
                    timeslot3Btn.Text = "";
                    timeslot3Btn.Enabled = true;
                    timeslot3Btn.BackColor = Color.White;
                    break;
                case 4:
                    timeslot4Btn.Text = "";
                    timeslot4Btn.Enabled = true;
                    timeslot4Btn.BackColor = Color.White;
                    break;
                case 5:
                    timeslot5Btn.Text = "";
                    timeslot5Btn.Enabled = true;
                    timeslot5Btn.BackColor = Color.White;
                    break;
                case 6:
                    timeslot6Btn.Text = "";
                    timeslot6Btn.Enabled = true;
                    timeslot6Btn.BackColor = Color.White;
                    break;
                case 7:
                    timeslot7Btn.Text = "";
                    timeslot7Btn.Enabled = true;
                    timeslot7Btn.BackColor = Color.White;
                    break;
                case 8:
                    timeslot8Btn.Text = "";
                    timeslot8Btn.Enabled = true;
                    timeslot8Btn.BackColor = Color.White;
                    break;
                case 9:
                    timeslot9Btn.Text = "";
                    timeslot9Btn.Enabled = true;
                    timeslot9Btn.BackColor = Color.White;
                    break;
                case 10:
                    timeslot10Btn.Text = "";
                    timeslot10Btn.Enabled = true;
                    timeslot10Btn.BackColor = Color.White;
                    break;
                case 11:
                    timeslot11Btn.Text = "";
                    timeslot11Btn.Enabled = true;
                    timeslot11Btn.BackColor = Color.White;
                    break;
                case 12:
                    timeslot12Btn.Text = "";
                    timeslot12Btn.Enabled = true;
                    timeslot12Btn.BackColor = Color.White;
                    break;
                case 13:
                    timeslot13Btn.Text = "";
                    timeslot13Btn.Enabled = true;
                    timeslot13Btn.BackColor = Color.White;
                    break;
                case 14:
                    timeslot14Btn.Text = "";
                    timeslot14Btn.Enabled = true;
                    timeslot14Btn.BackColor = Color.White;
                    break;
                case 15:
                    timeslot15Btn.Text = "";
                    timeslot15Btn.Enabled = true;
                    timeslot15Btn.BackColor = Color.White;
                    break;
                case 16:
                    timeslot16Btn.Text = "";
                    timeslot16Btn.Enabled = true;
                    timeslot16Btn.BackColor = Color.White;
                    break;
            }
        }

        private void UpdateTimeslotButton(int slotId, string patientName)
        {
            
            switch (slotId)
            {
                case 1:


                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 1;
                        printnames[1-1] = patientName;
                        timeslot1Btn.Text = patientName;
                        timeslot1Btn.Enabled = true;
                        timeslot1Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 1;

                        printnames[1 - 1] = patientName;
                        timeslot1Btn.Text = patientName;
                        timeslot1Btn.Enabled = false;
                        timeslot1Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 2:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 2;

                        printnames[2 - 1] = patientName;
                        printnames[2 - 1] = patientName;
                        timeslot2Btn.Text = patientName;
                        timeslot2Btn.Enabled = true;
                        timeslot2Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 2;

                        printnames[2 - 1] = patientName;
                        timeslot2Btn.Text = patientName;
                        timeslot2Btn.Enabled = false;
                        timeslot2Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 3:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 3;

                        printnames[3 - 1] = patientName;
                        timeslot3Btn.Text = patientName;
                        timeslot3Btn.Enabled = true;
                        timeslot3Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 3;

                        printnames[tglID - 1] = patientName;
                        timeslot3Btn.Text = patientName;
                        timeslot3Btn.Enabled = false;
                        timeslot3Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 4:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 4;
                        printnames[tglID - 1] = patientName;
                        timeslot4Btn.Text = patientName;
                        timeslot4Btn.Enabled = true;
                        timeslot4Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 4;
                        printnames[tglID - 1] = patientName;
                        timeslot4Btn.Text = patientName;
                        timeslot4Btn.Enabled = false;
                        timeslot4Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 5:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 5;
                        printnames[tglID - 1] = patientName;
                        timeslot5Btn.Text = patientName;
                        timeslot5Btn.Enabled = true;
                        timeslot5Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 5;
                        printnames[tglID - 1] = patientName;
                        timeslot5Btn.Text = patientName;
                        timeslot5Btn.Enabled = false;
                        timeslot5Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 6:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 6;
                        printnames[tglID - 1] = patientName;
                        timeslot6Btn.Text = patientName;
                        timeslot6Btn.Enabled = true;
                        timeslot6Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 6;
                        printnames[tglID - 1] = patientName;
                        timeslot6Btn.Text = patientName;
                        timeslot6Btn.Enabled = false;
                        timeslot6Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 7:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 7;
                        printnames[tglID - 1] = patientName;
                        timeslot7Btn.Text = patientName;
                        timeslot7Btn.Enabled = true;
                        timeslot7Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 7;
                        printnames[tglID - 1] = patientName;
                        timeslot7Btn.Text = patientName;
                        timeslot7Btn.Enabled = false;
                        timeslot7Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 8:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 8;
                        printnames[tglID - 1] = patientName;
                        timeslot8Btn.Text = patientName;
                        timeslot8Btn.Enabled = true;
                        timeslot8Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 8;
                        printnames[tglID - 1] = patientName;
                        timeslot8Btn.Text = patientName;
                        timeslot8Btn.Enabled = false;
                        timeslot8Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 9:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 9;
                        printnames[tglID - 1] = patientName;
                        timeslot9Btn.Text = patientName;
                        timeslot9Btn.Enabled = true;
                        timeslot9Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 9;
                        printnames[tglID - 1] = patientName;
                        timeslot9Btn.Text = patientName;
                        timeslot9Btn.Enabled = false;
                        timeslot9Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 10:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 10;
                        printnames[tglID - 1] = patientName;
                        timeslot10Btn.Text = patientName;
                        timeslot10Btn.Enabled = true;
                        timeslot10Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 10;
                        printnames[tglID - 1] = patientName;
                        timeslot10Btn.Text = patientName;
                        timeslot10Btn.Enabled = false;
                        timeslot10Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 11:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 11;
                        printnames[tglID - 1] = patientName;
                        timeslot11Btn.Text = patientName;
                        timeslot11Btn.Enabled = true;
                        timeslot11Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 11;
                        printnames[tglID - 1] = patientName;
                        timeslot11Btn.Text = patientName;
                        timeslot11Btn.Enabled = false;
                        timeslot11Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 12:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 12;
                        printnames[tglID - 1] = patientName;
                        timeslot12Btn.Text = patientName;
                        timeslot12Btn.Enabled = true;
                        timeslot12Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 12;
                        printnames[tglID - 1] = patientName;
                        timeslot12Btn.Text = patientName;
                        timeslot12Btn.Enabled = false;
                        timeslot12Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 13:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 13;
                        printnames[tglID - 1] = patientName;
                        timeslot13Btn.Text = patientName;
                        timeslot13Btn.Enabled = true;
                        timeslot13Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 13;
                        printnames[tglID - 1] = patientName;
                        timeslot13Btn.Text = patientName;
                        timeslot13Btn.Enabled = false;
                        timeslot13Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 14:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 14;
                        printnames[tglID - 1] = patientName;
                        timeslot14Btn.Text = patientName;
                        timeslot14Btn.Enabled = true;
                        timeslot14Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 14;
                        printnames[tglID - 1] = patientName;
                        timeslot14Btn.Text = patientName;
                        timeslot14Btn.Enabled = false;
                        timeslot14Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 15:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 15;
                        printnames[tglID - 1] = patientName;
                        timeslot15Btn.Text = patientName;
                        timeslot15Btn.Enabled = true;
                        timeslot15Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 15;
                        printnames[tglID - 1] = patientName;
                        timeslot15Btn.Text = patientName;
                        timeslot15Btn.Enabled = false;
                        timeslot15Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
                case 16:
                    if (!btnEnable)
                    {
                        tglName = patientName;
                        tglID = 16;
                        printnames[tglID - 1] = patientName;
                        timeslot16Btn.Text = patientName;
                        timeslot16Btn.Enabled = true;
                        timeslot16Btn.BackColor = tsColor1;
                        apptCancellable = true;
                    }
                    else
                    {
                        tglName = patientName;
                        tglID = 16;
                        printnames[tglID - 1] = patientName;
                        timeslot16Btn.Text = patientName;
                        timeslot16Btn.Enabled = false;
                        timeslot16Btn.BackColor = tsColor;
                        apptCancellable = false;

                    }
                    break;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            updateByDateAndDoctor();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            updateByDateAndDoctor();
        }

        public int radioState()
        {
            if (radbtnGP.Checked)
            {

                return 1;
            }
            else if (radBtnDentist.Checked)
            {
                return 2;
            }
            else if (radBtnPhysio.Checked)
            {
                return 3;
            }
            else if(radBtnCardiologist.Checked)
            {
                return 4;
            }
            else if(radBtnAudio.Checked)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

        public DateTime getDate()
        {
            // Assuming selectCalendar is your MonthCalendar control
            return monthCalendar1.SelectionRange.Start;
        }

        private void timeslot2Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 2;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
            else
            {

                DialogResult result = MessageBox.Show("Do you want to cancel this appointment? ", " Cancellation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    taAppointment_Correct3.DeleteFill(dSAppointment.Appointment_Correct, selectedDate.ToString(), 2);

                    foreach (DataRow row in dSAppointment.Appointment_Correct.Rows)
                    {
                        deletionApptNo = Convert.ToInt32(row["Appt_No"]);
                    }
                    taAppointment_Correct3.DeleteQuery(deletionApptNo);

                    taAppointment_Correct3.Fill(dSAppointment.Appointment_Correct);

                    MessageBox.Show("Appointment Cancelled");
                    deleted = true;
                    UpdateTimeslotDeletion(2);
                }
                else
                {

                }
            }
        }

        public int getTimeSlotID()
        {
            return slotID;
        }

        private void timeslot3Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 3;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void timeslot4Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 4;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }

        }

        private void timeslot5Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 5;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }

        }

        private void timeslot6Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 6;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void timeslot7Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 7;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }

        }

        private void timeslot8Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 8;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void timeslot9Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 9;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void timeslot10Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 10;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void timeslot11Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 11;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void timeslot12Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 12;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void timeslot13Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 13;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void timeslot14Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 14;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void timeslot15Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 15;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void timeslot16Btn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointmentForm1;
            if (apptCancellable == false)
            {
                slotID = 16;
                if (radioState() != 0)
                {
                    addAppointmentForm1 = AddAppointment.Instance;
                    addAppointmentForm1.setRState(radioState());
                    addAppointmentForm1.Show();
                }
                else
                {
                    MessageBox.Show("Please Select a Doctor");
                }
            }
        }

        private void doctorSelectionGB_Enter(object sender, EventArgs e)
        {

        }

        private void radbtnGP_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void radBtnDentist_CheckedChanged(object sender, EventArgs e)
        {
            updateByDateAndDoctor();
        }

        private void radBtnPhysio_CheckedChanged(object sender, EventArgs e)
        {
            updateByDateAndDoctor();
        }

        private void radBtnAudio_CheckedChanged(object sender, EventArgs e)
        {
            updateByDateAndDoctor();
        }

        public void updateByDateAndDoctor()
        {
            selectedDate = monthCalendar1.SelectionStart.Date; // Update selected date
            int doctorID = radioState();

            // Fetch appointments for the selected date
            taAppointment_Correct2.FillByDateAndDoctor(dSAppointment.Appointment_Correct, selectedDate.ToString(), doctorID);

            // Clear timeslot buttons
            for (int i = 1; i < 17; i++)
            {
                ClearTimeslotButtons(i);
            }

            foreach (DataRow row in dSAppointment.Appointment_Correct.Rows)
            {
                int patientId = Convert.ToInt32(row["Patient_ID"]);

                // Fill the Patient table with the specific patient ID
                taPatient2.FillByPatientID(dSAppointment.Patient, patientId);

                // Assuming the Patient table has columns "Patient_Name" and "Patient_Surname"
                DataRow patientRow = dSAppointment.Patient.Rows[0];
                string patientName = $"{patientRow["Patient_Name"]} {patientRow["Patient_Surname"]}";


                int slotId = Convert.ToInt32(row["Appt_Timeslot_ID"]);

                // Update the timeslot button with the patient's name

                UpdateTimeslotButton(slotId, patientName);


            }
        }

        private void tglColor_Click(object sender, EventArgs e)
        {    
            
        }

        private void timeslot1Btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void timeslot1Btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void timeslot1Btn_MouseEnter(object sender, EventArgs e)
        {

        }

        public Color UpdateToggleColor()
        {
            return Color.White;
        }
        private void UpdateTimeslotDeletion(int slotID)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
