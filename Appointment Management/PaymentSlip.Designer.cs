
namespace Appointment_Management
{
    partial class PaymentSlip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentSlip));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.payConfirmation = new System.Windows.Forms.Label();
            this.btnPayWithCard = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmontBeforeVAT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDoct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApptDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatFullName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProHealth = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.taAppointmentPriceList1 = new Appointment_Management.DSAppointmentTableAdapters.Appointment_Price_ListTableAdapter();
            this.dsAppointment1 = new Appointment_Management.DSAppointment();
            this.taApptCorrect = new Appointment_Management.DSAppointmentTableAdapters.Appointment_CorrectTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppointment1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblProHealth);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 763);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.payConfirmation);
            this.groupBox3.Controls.Add(this.txtChange);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtAmountPaid);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(13, 584);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 163);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment";
            // 
            // payConfirmation
            // 
            this.payConfirmation.AutoSize = true;
            this.payConfirmation.BackColor = System.Drawing.SystemColors.Window;
            this.payConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payConfirmation.ForeColor = System.Drawing.Color.SeaGreen;
            this.payConfirmation.Location = new System.Drawing.Point(543, 110);
            this.payConfirmation.Name = "payConfirmation";
            this.payConfirmation.Size = new System.Drawing.Size(194, 18);
            this.payConfirmation.TabIndex = 13;
            this.payConfirmation.Text = "Payment Successfully Made";
            this.payConfirmation.Visible = false;
            // 
            // btnPayWithCard
            // 
            this.btnPayWithCard.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPayWithCard.FlatAppearance.BorderSize = 0;
            this.btnPayWithCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayWithCard.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayWithCard.ForeColor = System.Drawing.Color.White;
            this.btnPayWithCard.Location = new System.Drawing.Point(311, 786);
            this.btnPayWithCard.Name = "btnPayWithCard";
            this.btnPayWithCard.Size = new System.Drawing.Size(150, 30);
            this.btnPayWithCard.TabIndex = 11;
            this.btnPayWithCard.Text = "Pay with Card";
            this.btnPayWithCard.UseVisualStyleBackColor = false;
            this.btnPayWithCard.Click += new System.EventHandler(this.btnPayWithCard_Click);
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.White;
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(565, 52);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(138, 20);
            this.txtChange.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Change : (R)";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.BackColor = System.Drawing.Color.White;
            this.txtAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountPaid.Location = new System.Drawing.Point(565, 18);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(138, 20);
            this.txtAmountPaid.TabIndex = 4;
            this.txtAmountPaid.TextChanged += new System.EventHandler(this.txtAmountPaid_TextChanged);
            this.txtAmountPaid.Enter += new System.EventHandler(this.txtAmountPaid_Enter);
            this.txtAmountPaid.Leave += new System.EventHandler(this.txtAmountPaid_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Amount Paid : (R)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtVAT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAmontBeforeVAT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDocName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 188);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fees";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(565, 153);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(138, 13);
            this.txtTotal.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "TOTAL : (R)";
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.Color.White;
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVAT.Enabled = false;
            this.txtVAT.Location = new System.Drawing.Point(565, 119);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(138, 13);
            this.txtVAT.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "VAT @ 15% : ";
            // 
            // txtAmontBeforeVAT
            // 
            this.txtAmontBeforeVAT.BackColor = System.Drawing.Color.White;
            this.txtAmontBeforeVAT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmontBeforeVAT.Enabled = false;
            this.txtAmontBeforeVAT.Location = new System.Drawing.Point(565, 90);
            this.txtAmontBeforeVAT.Name = "txtAmontBeforeVAT";
            this.txtAmontBeforeVAT.Size = new System.Drawing.Size(138, 13);
            this.txtAmontBeforeVAT.TabIndex = 6;
            this.txtAmontBeforeVAT.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Before VAT : (R) ";
            // 
            // txtDocName
            // 
            this.txtDocName.BackColor = System.Drawing.Color.White;
            this.txtDocName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocName.Enabled = false;
            this.txtDocName.Location = new System.Drawing.Point(565, 27);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new System.Drawing.Size(138, 13);
            this.txtDocName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consultation with ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDoct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApptDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPatFullName);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Details";
            // 
            // txtDoct
            // 
            this.txtDoct.BackColor = System.Drawing.Color.White;
            this.txtDoct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoct.Enabled = false;
            this.txtDoct.Location = new System.Drawing.Point(175, 64);
            this.txtDoct.Name = "txtDoct";
            this.txtDoct.Size = new System.Drawing.Size(138, 13);
            this.txtDoct.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doctor :";
            // 
            // txtApptDate
            // 
            this.txtApptDate.BackColor = System.Drawing.Color.White;
            this.txtApptDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApptDate.Enabled = false;
            this.txtApptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApptDate.ForeColor = System.Drawing.Color.Black;
            this.txtApptDate.Location = new System.Drawing.Point(566, 33);
            this.txtApptDate.Name = "txtApptDate";
            this.txtApptDate.Size = new System.Drawing.Size(138, 12);
            this.txtApptDate.TabIndex = 4;
            this.txtApptDate.TextChanged += new System.EventHandler(this.txtApptDate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appointment Date :";
            // 
            // txtPatFullName
            // 
            this.txtPatFullName.BackColor = System.Drawing.Color.White;
            this.txtPatFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatFullName.Enabled = false;
            this.txtPatFullName.Location = new System.Drawing.Point(175, 33);
            this.txtPatFullName.Name = "txtPatFullName";
            this.txtPatFullName.Size = new System.Drawing.Size(138, 13);
            this.txtPatFullName.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(13, 64);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(0, 15);
            this.lblSurname.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(162, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name(s) and Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nyala Mall\r\n201 Nyala Road\r\nKwaMashu\r\n4359";
            // 
            // lblProHealth
            // 
            this.lblProHealth.AutoSize = true;
            this.lblProHealth.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProHealth.Location = new System.Drawing.Point(349, 35);
            this.lblProHealth.Name = "lblProHealth";
            this.lblProHealth.Size = new System.Drawing.Size(338, 34);
            this.lblProHealth.TabIndex = 2;
            this.lblProHealth.Text = "Prohealth Medical Practice";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(352, 185);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "lblDate";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(28, 785);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 30);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Make Payment";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(600, 785);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // taAppointmentPriceList1
            // 
            this.taAppointmentPriceList1.ClearBeforeFill = true;
            // 
            // dsAppointment1
            // 
            this.dsAppointment1.DataSetName = "DSAppointment";
            this.dsAppointment1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taApptCorrect
            // 
            this.taApptCorrect.ClearBeforeFill = true;
            // 
            // PaymentSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 847);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPayWithCard);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaymentSlip";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentSlip";
            this.Load += new System.EventHandler(this.PaymentSlip_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppointment1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPatFullName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProHealth;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAmontBeforeVAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApptDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private DSAppointmentTableAdapters.Appointment_Price_ListTableAdapter taAppointmentPriceList1;
        private DSAppointment dsAppointment1;
        private System.Windows.Forms.Button btnPayWithCard;
        private System.Windows.Forms.Button btnPay;
        private DSAppointmentTableAdapters.Appointment_CorrectTableAdapter taApptCorrect;
        private System.Windows.Forms.Label payConfirmation;
    }
}