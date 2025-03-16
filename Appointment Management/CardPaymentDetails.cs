using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Appointment_Management
{
    public partial class CardPaymentDetails : Form
    {
        public string totalAmount { get; set; }
        public int patientID { get; set; }
        public delegate void PaymentMadeEventHandler(string amount);
        public event PaymentMadeEventHandler PaymentMade;

        public CardPaymentDetails()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string cardNumber = txtCreditCardNumber.Text.Trim();
            if(cardNumber.Length >16)
            {
                lblInvalidCardNumber.Visible = true;
                lblInvalidCardNumber.ForeColor = Color.Red;
                lblInvalidCardNumber.Text = "Invalid Card Number";
                iconBtn.Visible = false;
                
            }
            else if (cardNumber.Length == 16)
            {
                if (IsVisa(cardNumber))
                {
                    
                    iconBtn.Visible = true;
                    iconBtn.BackgroundImage = Properties.Resources.visa_icon;
                }
                else if (IsMastercard(cardNumber))
                {
                   
                    iconBtn.Visible = true;
                    iconBtn.BackgroundImage = Properties.Resources.mastercard_icon;
                }

                else
                {
                    
                    iconBtn.Visible = false;
                }
                lblInvalidCardNumber.Text = "";
            }
            else
            {
                
                iconBtn.Visible = false;
                lblInvalidCardNumber.Text = "";
            }

        }

        private bool IsVisa(string cardNumber)
        {
            return cardNumber.StartsWith("4") && (cardNumber.Length == 13 || cardNumber.Length == 16);
        }

        private bool IsMastercard(string cardNumber)
        {
            if (cardNumber.Length == 16 && int.TryParse(cardNumber.Substring(0, 2), out int firstTwoDigits))
            {
                return firstTwoDigits >= 51 && firstTwoDigits <= 55;
            }
            else
            {
                return false;
            }
        }

        private void txtCVV_TextChanged(object sender, EventArgs e)
        {
            if (lblFillCVV.Text != "")
            {
                lblFillCVV.Text = "";
            }
            // Check if the input contains only digits and has exactly four characters
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCVV.Text, @"^\d{3}$"))
            {
                // Display success message in lblCVV label
                lblCVV.Text = "Valid CVV";
                lblCVV.ForeColor = Color.Green;
            }
            else
            {
                // Display error message in lblCVV label
                lblCVV.Text = "Invalid CVV";
                lblCVV.ForeColor = Color.Red;
            }
        }

        private void dtpExpiryDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNameOnCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardPaymentDetails_Load(object sender, EventArgs e)
        {
            iconBtn.Enabled = false;
            iconBtn.Visible = false;
            iconBtn.BackColor = Color.White;
            lblCVV.Text = "";
            
            txtTotal.Text = totalAmount;

            lblInvalidCardNumber.Visible = false;

            lblFillCardDescription.ForeColor = Color.Red;
            lblFillNameOnCard.ForeColor = Color.Red;
            lblFillCardNumber.ForeColor = Color.Red;
            lblFillCVV.ForeColor = Color.Red;

        }

        private void iconBtn_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void iconBtn_Click(object sender, EventArgs e)
        {
            
        }

        private bool isValidNum(string str)
        { 
            bool valid = true;
            char[] charArray = str.ToCharArray();
            foreach(char chr in charArray)
            {
                if (!int.TryParse(chr.ToString(), out _)){
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (txtCardDescription.Text == "")
            {
                lblFillCardDescription.Visible = true;
                lblFillCardDescription.Text = "Fill in your Card Description";
                isValid = false;
            }
            else
            {
                lblFillCardDescription.Visible = false;
            }

            if (txtNameOnCard.Text == "")
            {
                lblFillNameOnCard.Visible = true;
                lblFillNameOnCard.Text = "Fill in your Name";
                isValid = false;
            }
            else
            {
                lblFillNameOnCard.Visible = false;
            }

            if (txtCreditCardNumber.Text == "" || txtCreditCardNumber.Text.Length < 16)
            {
                lblFillCardNumber.Visible = true;
                lblFillCardNumber.Text = "Your card number is too short";
                isValid = false;
            }
            else if (!isValidNum(txtCreditCardNumber.Text))
            {
                lblFillCardNumber.Visible = true;
                lblFillCardNumber.Text = "Card number must be numeric";
                isValid = false;
            }
            else
            {
                lblFillCardNumber.Visible = false;
            }

            if (isValid)
            {
                DialogResult dia = MessageBox.Show("Are You Sure You Want to Proceed With Payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    PaymentMade?.Invoke(txtTotal.Text);
                    taApptCorrect.UpdatePayment(patientID, 2, 1, "Paid", 500, 75, 0);
                    this.Close();
                }
                else
                {
                    txtCardDescription.Clear();
                    txtNameOnCard.Clear();
                    txtCVV.Clear();
                    txtCreditCardNumber.Clear();
                }
            }
        }
    }
}