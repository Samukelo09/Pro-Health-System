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
    public partial class CancelAppt : Form
    {
        DateTime date;
        public CancelAppt()
        {
            InitializeComponent();
        }


        private void CancelAppt_Load(object sender, EventArgs e)
        {
            date = DateTime.Today;
            // TODO: This line of code loads data into the 'dsAppointment1.Appointments_INNER' table. You can move, or remove it, as needed.
            this.appointments_INNERTableAdapter.Fill(this.dsAppointment1.Appointments_INNER,date.ToShortDateString());




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this appointment? ", "Cancellation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The appointment has been cancelled");
                taAppointment_Correct1.DeleteQuery((int)dgvAppt.CurrentRow.Cells[0].Value);
                this.appointments_INNERTableAdapter.Fill(this.dsAppointment1.Appointments_INNER, date.ToShortDateString());
            }
            else
            {
                MessageBox.Show("The appointment has not been cancelled");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            taAppointments_INNER1.FillByPatientName(dsAppointment1.Appointments_INNER, textBox1.Text, date.ToShortDateString());
        }
    }
}
