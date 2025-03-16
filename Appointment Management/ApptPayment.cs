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
    public partial class ApptPayment : Form
    {
        PaymentSlip ps = new PaymentSlip();
        public ApptPayment()
        {
            InitializeComponent();
        }

        private void ApptPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSAppointment.Patient' table. You can move, or remove it, as needed.
            this.taPatient1.Fill(this.dSAppointment.Patient);

        }

        private void dgvPatient_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        

        private void dgvAppt_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvPatient_MouseClick(object sender, MouseEventArgs e)
        {
            taApptPayment.FillPatientID(dSAppointment.ApptPayment, (int)dgvPatient.CurrentRow.Cells[0].Value);
            ps.patientID = (int)dgvPatient.CurrentRow.Cells[0].Value;
        }

        private void dgvAppt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void generatePaymentSlipBtn_Click(object sender, EventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(dgvAppt.CurrentRow.Cells[0].Value.ToString());
            ps.Show();
            ps.fullName = dgvAppt.CurrentRow.Cells[6].Value.ToString() + " " + dgvAppt.CurrentRow.Cells[7].Value.ToString();
            ps.date = dateTime.ToShortDateString();
            ps.dr = "Dr " + dgvAppt.CurrentRow.Cells[8].Value.ToString() + " " + dgvAppt.CurrentRow.Cells[9].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            taPatient1.FillByName(dSAppointment.Patient, textBox1.Text);
        }
    }
}
