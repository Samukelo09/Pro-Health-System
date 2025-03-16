using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Appointment_Management
{
    public partial class PatientRecord : Form
    {
        public string finalAverageTemp { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string Temp { get; set; }
        public string Respiratory { get; set; }
        public string Glucose { get; set; }
        public string HRate { get; set; }
        public string DiaBp { get; set; }
        public string SysBp { get; set; }

        public string finalAverageRR { get; set; }
        public string finalAverageBG { get; set; }
        public string finalAverageHR { get; set; }
        public string finalAverageDBP { get; set; }
        public string finalAverageSBP { get; set; }

        public PatientRecord()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();

            doc.PrintPage += (s, ev) =>
            {

                Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(bmp, new Rectangle(Point.Empty, panel1.Size));


                ev.Graphics.DrawImage(bmp, Point.Empty);
            };


            if (printDia.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void PatientRecord_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PatientName)) // Check if PatientName is not null or empty
            {
                txtPatName.Text = PatientName;
                txtPatSurname.Text = PatientSurname;
                txtDiaBP.Text = finalAverageDBP;
                txtGlucose.Text = finalAverageBG;
                txtHrate.Text = finalAverageHR;
                txtRespRate.Text = finalAverageRR;
                txtSysBp.Text = finalAverageSBP;
                txtTemp.Text = finalAverageTemp;

            }
            else
            {
                // Handle the case where PatientName is null or empty (e.g., display a message)
            }
            lblDate.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void txtDiaBP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
