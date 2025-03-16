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
    public partial class ModifyDrInfo : Form
    {

        public ModifyDrInfo()
        {
            InitializeComponent();
        }

        public string DRName { get; set; }
        public string DRSurname { get; set; }
        public string DRPhone { get; set; }
        public string DREmail { get; set; }
        public int DRID { get; set; }
        private void ModifyDrInfo_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = DRName;
            txtLastName.Text = DRSurname;
            txtEmail.Text = DREmail;
            txtPhone.Text = DRPhone;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"Are You Sure You Want {DRName}'s Details?", "Condirmtion", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                doctorTableAdapter1.UpdateDr(txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtEmail.Text, (int)DRID);
                
                this.Close();
                this.doctorTableAdapter2.Fill(this.dSAppointment.Doctor);
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        public void fill()
        {
            this.doctorTableAdapter2.Fill(this.dSAppointment.Doctor);
        }

        


    }
} 