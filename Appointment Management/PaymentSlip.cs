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
    public partial class PaymentSlip : Form
    {
        
        CardPaymentDetails cardPaymentDetails = new CardPaymentDetails();
        public string fullName { get; set; }
        public string date { get; set; }
        public string dr { get; set; }
        public int patientID { get; set; }

        public PaymentSlip()
        {
            InitializeComponent();
            cardPaymentDetails.PaymentMade += HandlePaymentMade;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();

            
            pd.PrintPage += (s, ev) =>
            {
               
                Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(bmp, new Rectangle(Point.Empty, panel1.Size));

                
                ev.Graphics.DrawImage(bmp, Point.Empty);
            };

            
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        decimal beforeVAT;
        private void PaymentSlip_Load(object sender, EventArgs e)
        {
            taAppointmentPriceList1.FillByApptPriceID(dsAppointment1.Appointment_Price_List, 1);
            foreach (DataRow row in dsAppointment1.Appointment_Price_List)
            {
                beforeVAT = (decimal)row["Appt_Cost"];
                txtAmontBeforeVAT.Text = (beforeVAT - beforeVAT * 15/100).ToString("");
            }
            lblDate.Text = DateTime.Today.ToShortDateString();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtPatFullName.Text = fullName;
            txtApptDate.Text = date;
            txtDoct.Text = dr;
            txtDocName.Text = dr;
            txtChange.Enabled = false;
            txtVAT.Text = (Convert.ToDecimal(beforeVAT) * 15/100).ToString("0.00");
            txtTotal.Text = (Convert.ToDecimal(txtAmontBeforeVAT.Text) + Convert.ToDecimal(txtVAT.Text)).ToString();
        }

        private void txtApptDate_TextChanged(object sender, EventArgs e)
        {

        }

        public void HandlePaymentMade(string amount)
        {
            txtAmountPaid.Text = amount;
            payConfirmation.Visible = true;
        }

        private void btnPayWithCard_Click(object sender, EventArgs e)
        {
            cardPaymentDetails.totalAmount = txtTotal.Text;
            cardPaymentDetails.patientID = patientID;
            cardPaymentDetails.ShowDialog();
            txtChange.Visible = false;
            btnPayWithCard.Visible = false;
            btnPay.Visible = false;
            label10.Visible = false;
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAmountPaid_Enter(object sender, EventArgs e)
        {

        }

        private void txtAmountPaid_Leave(object sender, EventArgs e)
        {


        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            btnPayWithCard.Visible = false;
            if (decimal.TryParse(txtAmountPaid.Text, out _))
            {
                if (Convert.ToDecimal(txtAmountPaid.Text) >= Convert.ToDecimal(txtTotal.Text))
                {
                    decimal vat = 75;
                    txtChange.Text = (Convert.ToDecimal(txtAmountPaid.Text) - Convert.ToDecimal(txtTotal.Text)).ToString("C2");

                    DialogResult dia = MessageBox.Show("Are You Sure You Want to Proceed With Payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dia == DialogResult.Yes)
                    {
                        decimal change = Convert.ToDecimal(txtChange.Text.Substring(1, txtChange.Text.Length-2));
                        taApptCorrect.UpdatePayment(patientID, 2, 1, "Paid", Convert.ToDecimal(txtAmountPaid.Text), vat, change);
                        /*txtChange.Clear();
                        txtAmountPaid.Clear();*/
                        btnPay.Visible = false;
                        payConfirmation.Visible = true;
                    }
                    else
                    {
                        txtChange.Clear();
                        txtAmountPaid.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("This Amount is Insufficient");
                    txtAmountPaid.Clear();
                }
            }
            else
            {
                MessageBox.Show("The Amount Paid Must be Numeric");
            }
        }
    }
}
