using Appointment_Management.DSAppointmentTableAdapters;
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
    public partial class UpdateDrInfo : Form
    {
        bool chk = true;
        bool archive = true;
        bool refresh = true;
        public UpdateDrInfo()
        {
            InitializeComponent();
        }

        private void UpdateDrInfo_Load(object sender, EventArgs e)
        {

            //taDoctor2.Fill(dSAppointment.Doctor);
            taDoctor1.FillByArchiveStatus(dSAppointment.Doctor, "NotArchived");

            tglColor.BackgroundImage = Properties.Resources.btnBlue;
            tglColor.Text = "Not Archived                 Archived";
            buttonArchiveDoctor1.Text = "Archive Doctor";

        }

        private void btnUpdateDr_Click(object sender, EventArgs e)
        {
            if (dgvDr.CurrentRow != null)
            {
                ModifyDrInfo modify = new ModifyDrInfo();
                string drName = (string)dgvDr.CurrentRow.Cells[2].Value.ToString();
                string drsname = (string)dgvDr.CurrentRow.Cells[3].Value.ToString();
                string drPhone = (string)dgvDr.CurrentRow.Cells[4].Value.ToString();
                string drEmail = (string)dgvDr.CurrentRow.Cells[5].Value.ToString();
                int drId = (int)dgvDr.CurrentRow.Cells[0].Value;

                modify.DRName = drName;
                modify.DRSurname = drsname;
                modify.DREmail = drEmail;
                modify.DRPhone = drPhone;
                modify.DRID = drId;
                modify.Show();
            }
            else
            {
            }
        }




                    private void dgvDr_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
                    {

                    }



                    private void button2_Click_1(object sender, EventArgs e)
                    {

        }

    private void button1_Click(object sender, EventArgs e)
    {
            if (refresh == true)
            {
                taDoctor2.FillByArchiveStatus(dSAppointment.Doctor, "NotArchived");
            }
            else
            {
                taDoctor2.FillByArchiveStatus(dSAppointment.Doctor, "Archived");
            }
    }

        private void tglColor_Click(object sender, EventArgs e)
        {
            if (chk != true)
            {
                tglColor.BackgroundImage = Properties.Resources.btnBlue;
                chk = true;
                taDoctor2.FillByArchiveStatus(dSAppointment.Doctor, "NotArchived");
                buttonArchiveDoctor1.Text = "Archive Doctor";
                archive = true;
                refresh = true;
                
            }
            else
            {
                tglColor.BackgroundImage = Properties.Resources.btnRed;
                chk = false;
                taDoctor2.FillByArchiveStatus(dSAppointment.Doctor, "Archived");
                buttonArchiveDoctor1.Text = "UnArchive Doctor";
                archive = false;
                refresh = false;

            }
            dgvDr.DataSource = dSAppointment.Doctor;
        }

        private void buttonArchiveDoctor1_Click(object sender, EventArgs e)
        {
            if (archive)
            {
                taDoctor2.UpdateArchiveStatus("Archived", (int)dgvDr.CurrentRow.Cells[0].Value);
                taDoctor2.FillByArchiveStatus(dSAppointment.Doctor, "NotArchived");
            }
            else
            {
                taDoctor2.UpdateArchiveStatus("NotArchived", (int)dgvDr.CurrentRow.Cells[0].Value);
                taDoctor2.FillByArchiveStatus(dSAppointment.Doctor, "Archived");
            }
        }

        private void dgvDr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}  
    

