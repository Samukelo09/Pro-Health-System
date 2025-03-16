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
    public partial class ApptPaymentForm : Form
    {
        public ApptPaymentForm()
        {
            InitializeComponent();
        }

        private void ApptPaymentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAppointment.Appointment_Correct' table. You can move, or remove it, as needed.
            this.appointment_CorrectTableAdapter.Fill(this.dSAppointment.Appointment_Correct);
           
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
