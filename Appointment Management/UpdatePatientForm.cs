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
    public partial class UpdatePatientFrom : Form
    {
        private int patientID;
        private string connectionString = "Data Source=146.230.177.46; Initial Catalog=G7Wst2024; User Id=G7Wst2024; Password=621id";

        public UpdatePatientFrom(int patientID)
        {
            InitializeComponent();
            this.patientID = patientID;
            LoadPatientDetails();
        }
        private void LoadPatientDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Patient WHERE Patient_Id = @PatientId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientId", patientID);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            
                            txtFirstName.Text = reader["Patient_Name"].ToString();
                            txtLastName.Text = reader["Patient_Surname"].ToString();
                            txtEmail.Text = reader["Patient_Email"].ToString();
                            txtPhone.Text = reader["Patient_Phone_No"].ToString();
                            
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading patient details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void UpdatePatientFrom_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Patient SET Patient_Name = @PatientName, Patient_Surname = @PatientSurname, Patient_Email = @PatientEmail, Patient_Phone_No = @Phone WHERE Patient_Id = @PatientId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientName", txtFirstName.Text);
                        command.Parameters.AddWithValue("@PatientSurname", txtLastName.Text);
                        command.Parameters.AddWithValue("@PatientId", patientID);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@PatientEmail", txtEmail.Text);
                        
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to update patient details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating patient details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
