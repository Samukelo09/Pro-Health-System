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
    public partial class PatientVitals : Form
    {
        decimal floorBodyTemp = 36.10m;
        decimal ceilBodyTemp = 37.20m;
        decimal floorRespiratoryRate = 12;
        decimal ceilRespiratoryRate = 20;
        decimal floorBloodGlucose = 70;
        decimal ceilBloodGlucose = 99;
        decimal floorHeartRate = 60;
        decimal ceilHeartRate = 100;
        decimal ceilSBP = 120;
        decimal floorSBP = 90;
        decimal ceilDBP = 80;
        decimal floorDBP = 60;

        Color themeRed = Color.Red;
        Color themeGreen = Color.Green;
        Color themeBlue = Color.Blue;






        public PatientVitals()
        {
            InitializeComponent();
            dataGridView2.CellFormatting += dataGridView2_CellFormatting;

        }



        private void PatientVitals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAppointment.Appointment_Correct' table. You can move, or remove it, as needed.
            this.taAppointment_Correct1.Fill(this.dSAppointment.Appointment_Correct);
            // TODO: This line of code loads data into the 'dSAppointment.Patient' table. You can move, or remove it, as needed.
            this.taPatient1.Fill(this.dSAppointment.Patient);
            dataGridView2.EnableHeadersVisualStyles = false;

            button1.BackColor = themeBlue;
            button2.BackColor = themeGreen;
            button3.BackColor = themeRed;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            taAppointment_Correct1.FillByPatientId(dSAppointment.Appointment_Correct, (int)dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtReasonForVisit.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtHeartRate.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtBloodGlucose.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtRespiratoryRate.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtTemperature.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtSBP.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txtDBP.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            /*taAppointment_Correct2.UpdatePatientVitals(Convert.ToInt32(txtHeartRate.Text), Convert.ToDecimal(txtBloodGlucose.Text), Convert.ToInt32(txtRespiratoryRate.Text), txtReasonForVisit.Text, Convert.ToDecimal(txtTemperature.Text), Convert.ToDecimal(txtSBP.Text), Convert.ToInt32(txtDBP.Text), (int)dataGridView2.CurrentRow.Cells[8].Value);
            taPatient1.Fill(dSAppointment.Patient);
            taAppointment_Correct2.Fill(dSAppointment.Appointment_Correct);


            txtReasonForVisit.Text = "";
            txtHeartRate.Text = "";
            txtBloodGlucose.Text = "";
            txtRespiratoryRate.Text = "";
            txtTemperature.Text = "";
            txtSBP.Text = ""; ;
            txtDBP.Text = "";*/

            try
            {
                taAppointment_Correct2.UpdatePatientVitals(Convert.ToInt32(txtHeartRate.Text),Convert.ToDecimal(txtBloodGlucose.Text), Convert.ToInt32(txtRespiratoryRate.Text), txtReasonForVisit.Text,Convert.ToDecimal(txtTemperature.Text), Convert.ToDecimal(txtSBP.Text), Convert.ToInt32(txtDBP.Text), (int)dataGridView2.CurrentRow.Cells[8].Value);

                taPatient1.Fill(dSAppointment.Patient);
                taAppointment_Correct2.Fill(dSAppointment.Appointment_Correct);
 
                txtReasonForVisit.Text = "";
                txtHeartRate.Text = "";
                txtBloodGlucose.Text = "";
                txtRespiratoryRate.Text = "";
                txtTemperature.Text = "";
                txtSBP.Text = "";
                txtDBP.Text = "";
            }
            catch
            {
                MessageBox.Show("Please Fill In All The Required Details");
            }
            }

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            taPatient1.FillByName(dSAppointment.Patient, txtSearchPatient.Text);
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // This is for the SBP
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.White;
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {
                    
                    if (cellValue <= ceilSBP && cellValue >= floorSBP) // Middle
                    {
                        e.CellStyle.BackColor = themeGreen;
                    }
                    else if(cellValue <= floorSBP) // Lower
                    {
                        e.CellStyle.BackColor = themeBlue;
                    }
                    else // Upper
                    {
                        e.CellStyle.BackColor = themeRed;
                    }
                }
            }

            // This is for the DBP
            if (e.ColumnIndex == 7 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.White;
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {

                    if (cellValue <= ceilDBP && cellValue >= floorDBP) // Middle
                    {
                        e.CellStyle.BackColor = themeGreen;
                    }
                    else if (cellValue <= floorDBP) // Lower
                    {
                        e.CellStyle.BackColor = themeBlue;
                    }
                    else // Upper
                    {
                        e.CellStyle.BackColor = themeRed;
                    }
                }
            }


            // This is for the BodyTemperature
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.White;
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {

                    if (cellValue <= ceilBodyTemp && cellValue >= floorBodyTemp) // Middle
                    {
                        e.CellStyle.BackColor = themeGreen;
                    }
                    else if (cellValue <= floorBodyTemp) // Lower
                    {
                        e.CellStyle.BackColor = themeBlue;
                    }
                    else // Upper
                    {
                        e.CellStyle.BackColor = themeRed;
                    }
                }
            }

            // This is for the RespiratoryRate
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.White;
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {

                    if (cellValue <= ceilRespiratoryRate && cellValue >= floorRespiratoryRate) // Middle
                    {
                        e.CellStyle.BackColor = themeGreen;
                    }
                    else if (cellValue <= floorRespiratoryRate) // Lower
                    {
                        e.CellStyle.BackColor = themeBlue;
                    }
                    else // Upper
                    {
                        e.CellStyle.BackColor = themeRed;
                    }
                }
            }


            // This is for the BloodGlucose Levels
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.White;
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {

                    if (cellValue <= ceilBloodGlucose && cellValue >= floorBloodGlucose) // Middle
                    {
                        e.CellStyle.BackColor = themeGreen;
                    }
                    else if (cellValue <= floorBloodGlucose) // Lower
                    {
                        e.CellStyle.BackColor = themeBlue;
                    }
                    else // Upper
                    {
                        e.CellStyle.BackColor = themeRed;
                    }
                }
            }


            // This is for the BloodGlucose Levels
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.CellStyle.ForeColor = Color.White;
                decimal cellValue;
                if (decimal.TryParse(e.Value.ToString(), out cellValue))
                {

                    if (cellValue <= ceilHeartRate && cellValue >= floorHeartRate) // Middle
                    {
                        e.CellStyle.BackColor = themeGreen;
                    }
                    else if (cellValue <= floorHeartRate) // Lower
                    {
                        e.CellStyle.BackColor = themeBlue;
                    }
                    else // Upper
                    {
                        e.CellStyle.BackColor = themeRed;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
