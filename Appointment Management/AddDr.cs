using System;
using System.Windows.Forms;


namespace Appointment_Management
{
    public partial class AddDoctorForm : Form
    {
        public AddDoctorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string radText;

            if (rdBtnMale.Checked)
            {
                radText = "Male";
            }
            else
            {
                radText = "Female";
            }
            if (rdBtnMale.Checked || rdBtnFemale.Checked)
            {
                DialogResult result = MessageBox.Show($"Do you wish to add {txtDocName.Text} {txtDrSurname.Text} as the new doctor?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    doctorTableAdapter1.InsertDoctor(Convert.ToInt32(specialtyCb.SelectedValue), txtDocName.Text.ToString(), txtDrSurname.Text.ToString(), txtDrPhone.Text.ToString(), txtDrEmail.Text.ToString(), null, null, drDOBdatetime.Value.Date.ToString(), radText);
                }
            }
            else
            {
                MessageBox.Show("Please select a gender");
            }
            txtDocName.Clear();
            txtDrEmail.Clear();
            txtDrPhone.Clear();
            txtDrSurname.Clear(); 
        }

        private void txtDrName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAppointment.Specialty' table. You can move, or remove it, as needed.
            this.specialtyTableAdapter.Fill(this.dSAppointment.Specialty);

        }
    }
}
