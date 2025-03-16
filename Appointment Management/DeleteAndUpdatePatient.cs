using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Management
{
    public partial class DeleteAndUpdatePatient : Form
    {

        PatientRecord patientRecord = new PatientRecord();
        bool chk = true;
        bool archive = true;

        public DeleteAndUpdatePatient()
        {
            InitializeComponent();
        }
        private void DeleteAndUpdatePatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAppointment.Customer' table. You can move, or remove it, as needed


            LoadPatientData();
        }

        private void LoadPatientData()
        {
            taPatient1.FillByArchiveStatus(dSAppointment.Patient, "NotArchived");

            tglColor.BackgroundImage = Properties.Resources.btnBlue;
            tglColor.Text = "Not Archived                 Archived";
            

        }
        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            if(archive)
            {
                taPatient1.UpdateArchiveStatus("Archived", (int)dgvPatientList.CurrentRow.Cells[0].Value);
                taPatient1.FillByArchiveStatus(dSAppointment.Patient, "NotArchived");
            }
            else
            {
                taPatient1.UpdateArchiveStatus("NotArchived", (int)dgvPatientList.CurrentRow.Cells[0].Value);
                taPatient1.FillByArchiveStatus(dSAppointment.Patient, "Archived");
            }

        }


        private void buttonUpdatePatient_Click(object sender, EventArgs e)
        {
            if (dgvPatientList.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvPatientList.SelectedRows[0].Index;

                // Get the patient ID from the selected row
                object cellValue = dgvPatientList.Rows[selectedRowIndex].Cells["patientIdDataGridViewTextBoxColumn"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int patientID))
                {
                    
                    UpdatePatientFrom updateForm = new UpdatePatientFrom(patientID);
                    updateForm.ShowDialog();
                    
                    LoadPatientData();
                }
                else
                {
                    MessageBox.Show("Selected patient ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void dgvPatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPatientRecord_Click(object sender, EventArgs e)
        {

            decimal averageTemp = 0;
            decimal averageRR = 0;
            decimal averageBG = 0;
            decimal averageHR = 0;
            decimal averageDBP = 0;
            decimal averageSBP = 0;
            int count = 0;
            int index = 0;
            taAppointment_Correct1.FillByPatientId(dSAppointment.Appointment_Correct, (int)dgvPatientList.CurrentRow.Cells[0].Value);
            foreach (DataRow row in dSAppointment.Appointment_Correct)
            {
                index++;

                // Null checks for each column
                if (row["Appt_No"] != DBNull.Value &&
                    row["Temperature"] != DBNull.Value &&
                    row["Respiratory_Rate"] != DBNull.Value &&
                    row["Blood_Glucose"] != DBNull.Value &&
                    row["Heart_Rate"] != DBNull.Value &&
                    row["Diastolic_BP"] != DBNull.Value &&
                    row["Systolic_BP"] != DBNull.Value)
                {
                    decimal temp = Convert.ToDecimal(row["Temperature"]);
                    int respiratory = Convert.ToInt32(row["Respiratory_Rate"]);
                    int bloodGlu = Convert.ToInt32(row["Blood_Glucose"]);
                    int heartR = Convert.ToInt32(row["Heart_Rate"]);
                    decimal diastolic = Convert.ToDecimal(row["Diastolic_BP"]);
                    decimal systolic = Convert.ToDecimal(row["Systolic_BP"]);

                    // Accumulate sum for each column
                    averageTemp += temp;
                    averageRR += respiratory;
                    averageBG += bloodGlu;
                    averageHR += heartR;
                    averageDBP += diastolic;
                    averageSBP += systolic;

                    count++; // Increment count for valid rows
                }
                else
                {
                    continue; // Skip invalid rows
                }
            }

            // Calculate final averages
            if (count == 0)
            {
                count = 1; // To avoid division by zero
            }
            decimal finalAverageTemp = averageTemp / count;
            decimal finalAverageRR = averageRR / count;
            decimal finalAverageBG = averageBG / count;
            decimal finalAverageHR = averageHR / count;
            decimal finalAverageDBP = averageDBP / count;
            decimal finalAverageSBP = averageSBP / count;

            // Further processing and display of results can be done here




            if (dgvPatientList.SelectedRows.Count > 0)
            {
                int selectedPatientID = Convert.ToInt32(dgvPatientList.CurrentRow.Cells[0].Value);
                string firstName = dgvPatientList.CurrentRow.Cells[1].Value?.ToString();
                string lastName = dgvPatientList.CurrentRow.Cells[2].Value?.ToString();
                string phone = dgvPatientList.CurrentRow.Cells[3].Value?.ToString();
                string email = dgvPatientList.CurrentRow.Cells[4].Value?.ToString();


                if (firstName != null && lastName != null)
                {
                    string fullName = firstName;
                    string Surname = lastName;
                    PatientRecord patientRecord = new PatientRecord();
                    patientRecord.PatientName = fullName;
                    patientRecord.PatientSurname = lastName;
                    patientRecord.finalAverageTemp = finalAverageTemp.ToString("0.0");
                    patientRecord.finalAverageRR = finalAverageRR.ToString("0.0");
                    patientRecord.finalAverageBG = finalAverageBG.ToString("0.0");
                    patientRecord.finalAverageHR = finalAverageHR.ToString("0.0");
                    patientRecord.finalAverageDBP = finalAverageDBP.ToString("0.0");
                    patientRecord.finalAverageSBP = finalAverageSBP.ToString("0.0");

                    /*UpdatePatientFrom updatePatientFrom = new UpdatePatientFrom(selectedPatientID);
                    updatePatientFrom.PatientName = fullName;
                    updatePatientFrom.PatientSurname = Surname;
                    updatePatientFrom.PatientPhone = phone;
                    updatePatientFrom.PatientEmail = email;*/



                    patientRecord.Show();
                }
                else
                {
                    MessageBox.Show("Please Ensure That All Details Are Available", "Confirmation", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please Select Patient", "Confirmation", MessageBoxButtons.OK);
            }

           /*tring fullName = dgvPatientList.CurrentRow.Cells[1].Value.ToString() + " " + dgvPatientList.CurrentRow.Cells[2].Value.ToString();

            PatientRecord atientRecord = new PatientRecord();
            atientRecord.Name = fullName;
            atientRecord.Show();*/
        }

        private void tglColor_Click(object sender, EventArgs e)
        {
            if (chk != true)
            {
                tglColor.BackgroundImage = Properties.Resources.btnBlue;
                chk = true;
                patientTableAdapter.FillByArchiveStatus(dSAppointment.Patient, "NotArchived");
                buttonArchivePatient.Text = "Archive Patient";
                archive = true;
            }
            else
            {
                tglColor.BackgroundImage = Properties.Resources.btnRed;
                chk = false;
                patientTableAdapter.FillByArchiveStatus(dSAppointment.Patient, "Archived");
                buttonArchivePatient.Text = "UnArchive Patient";
                archive = false;
            }

            dgvPatientList.DataSource = dSAppointment.Patient;
        }

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            if(archive == true)
            {
                taPatient2.FillByNameArchiveStatus(dSAppointment.Patient, txtSearchPatient.Text, "NotArchived");
            }
            else
            {
                taPatient2.FillByNameArchiveStatus(dSAppointment.Patient, txtSearchPatient.Text, "Archived");
            }
            
        }
    }
}
