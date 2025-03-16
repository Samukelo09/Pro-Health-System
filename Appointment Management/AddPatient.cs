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
    public partial class AddPatientInfo : Form
    {

        public AddPatientInfo()
        {
            InitializeComponent();
        }

       private void AddPatientButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=146.230.177.46; Initial Catalog=G7Wst2024; User Id=G7Wst2024; Password=621id";
            string patientName = txtAddPatientName.Text;
            string patientSurname = txtAddPatientSurname.Text;
            string patientPhoneNo = txtAddPatientPhone.Text;
            string patientEmail = txtaddPatientEmail.Text;
            string patientDOB = datetimePatient.Value.ToString();
            

            if (string.IsNullOrEmpty(patientName) ||
                string.IsNullOrEmpty(patientSurname) ||
                string.IsNullOrEmpty(patientPhoneNo) ||
                string.IsNullOrEmpty(patientEmail)||string.IsNullOrEmpty(patientDOB))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sexSelected ="";
                if (maleRadBtn.Checked)
                {
                    sexSelected = "Male";
                }
                else if (femaleRadBtn.Checked)
                {
                    sexSelected = "Female";
                }
                else
                {
                    MessageBox.Show("Please Select Gender");
                }
                try
                {
                    connection.Open();

                    string checkDuplicate = "SELECT COUNT(*) FROM Patient WHERE Patient_Email = @Email";
                    using (SqlCommand checkDuplicateCmd = new SqlCommand(checkDuplicate, connection))
                    {
                        checkDuplicateCmd.Parameters.AddWithValue("@Email", patientEmail);
                        int count = (int)checkDuplicateCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("The Patient already exists in the database.");
                            return;
                        }
                    }

                    
                    string insertPatientQuery = "INSERT INTO Patient (Patient_Name, Patient_Surname, Patient_Phone_No, Patient_Email, Patient_DOB, Patient_Sex)" +
                                                "VALUES (@Name, @Surname, @Phone, @Email, @DOB, @Sex)";
                    using (SqlCommand insertPatientCmd = new SqlCommand(insertPatientQuery, connection))
                    {
                        insertPatientCmd.Parameters.AddWithValue("@Name", patientName);
                        insertPatientCmd.Parameters.AddWithValue("@Surname", patientSurname);
                        insertPatientCmd.Parameters.AddWithValue("@Phone", patientPhoneNo);
                        insertPatientCmd.Parameters.AddWithValue("@Email", patientEmail);
                        insertPatientCmd.Parameters.AddWithValue("@DOB", patientDOB);
                        insertPatientCmd.Parameters.AddWithValue("@Sex", sexSelected);

                        int rowsAffected = insertPatientCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient information added successfully.");
                            
                            
                            txtAddPatientName.Text = "";
                            txtAddPatientSurname.Text = "";
                            txtAddPatientPhone.Text = "";
                            txtaddPatientEmail.Text = "";
                            
                        }
                        else
                        {
                            MessageBox.Show("Failed to add patient information.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    
                }
            }
       }

        private void txtAddPatientName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddPatientInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void AddPatientInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}