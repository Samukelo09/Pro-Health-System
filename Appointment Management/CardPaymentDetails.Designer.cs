namespace Appointment_Management
{
    partial class CardPaymentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPaymentDetails));
            this.txtCardDescription = new System.Windows.Forms.TextBox();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.payBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInvalidCardNumber = new System.Windows.Forms.Label();
            this.lblFillCVV = new System.Windows.Forms.Label();
            this.lblFillCardNumber = new System.Windows.Forms.Label();
            this.lblFillNameOnCard = new System.Windows.Forms.Label();
            this.lblFillCardDescription = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.iconBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.taApptCorrect = new Appointment_Management.DSAppointmentTableAdapters.Appointment_CorrectTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCardDescription
            // 
            this.txtCardDescription.Location = new System.Drawing.Point(272, 107);
            this.txtCardDescription.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCardDescription.Name = "txtCardDescription";
            this.txtCardDescription.Size = new System.Drawing.Size(396, 28);
            this.txtCardDescription.TabIndex = 0;
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameOnCard.Location = new System.Drawing.Point(272, 244);
            this.txtNameOnCard.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(396, 28);
            this.txtNameOnCard.TabIndex = 1;
            this.txtNameOnCard.TextChanged += new System.EventHandler(this.txtNameOnCard_TextChanged);
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreditCardNumber.Location = new System.Drawing.Point(327, 406);
            this.txtCreditCardNumber.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(396, 28);
            this.txtCreditCardNumber.TabIndex = 2;
            this.txtCreditCardNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCVV
            // 
            this.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCVV.Location = new System.Drawing.Point(327, 636);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(196, 28);
            this.txtCVV.TabIndex = 3;
            this.txtCVV.TextChanged += new System.EventHandler(this.txtCVV_TextChanged);
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(327, 497);
            this.dtpExpiryDate.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(396, 28);
            this.dtpExpiryDate.TabIndex = 4;
            this.dtpExpiryDate.Value = new System.DateTime(2024, 6, 8, 19, 23, 50, 0);
            this.dtpExpiryDate.ValueChanged += new System.EventHandler(this.dtpExpiryDate_ValueChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(244)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(220, 750);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(250, 60);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(169)))), ((int)(((byte)(92)))));
            this.payBtn.FlatAppearance.BorderSize = 0;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(607, 750);
            this.payBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(250, 60);
            this.payBtn.TabIndex = 6;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pay with Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Card Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name on Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Card Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 449);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Expiry Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 585);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "CVV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Eg. My FNB Card";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblInvalidCardNumber);
            this.panel1.Controls.Add(this.lblFillCVV);
            this.panel1.Controls.Add(this.lblFillNameOnCard);
            this.panel1.Controls.Add(this.lblCVV);
            this.panel1.Controls.Add(this.iconBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCreditCardNumber);
            this.panel1.Controls.Add(this.dtpExpiryDate);
            this.panel1.Controls.Add(this.txtCVV);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 967);
            this.panel1.TabIndex = 14;
            // 
            // lblInvalidCardNumber
            // 
            this.lblInvalidCardNumber.AutoSize = true;
            this.lblInvalidCardNumber.Location = new System.Drawing.Point(575, 370);
            this.lblInvalidCardNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInvalidCardNumber.Name = "lblInvalidCardNumber";
            this.lblInvalidCardNumber.Size = new System.Drawing.Size(61, 24);
            this.lblInvalidCardNumber.TabIndex = 24;
            this.lblInvalidCardNumber.Text = "label9";
            // 
            // lblFillCVV
            // 
            this.lblFillCVV.AutoSize = true;
            this.lblFillCVV.Location = new System.Drawing.Point(325, 600);
            this.lblFillCVV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFillCVV.Name = "lblFillCVV";
            this.lblFillCVV.Size = new System.Drawing.Size(61, 24);
            this.lblFillCVV.TabIndex = 23;
            this.lblFillCVV.Text = "label9";
            this.lblFillCVV.Visible = false;
            // 
            // lblFillCardNumber
            // 
            this.lblFillCardNumber.AutoSize = true;
            this.lblFillCardNumber.Location = new System.Drawing.Point(272, 317);
            this.lblFillCardNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFillCardNumber.Name = "lblFillCardNumber";
            this.lblFillCardNumber.Size = new System.Drawing.Size(61, 24);
            this.lblFillCardNumber.TabIndex = 22;
            this.lblFillCardNumber.Text = "label9";
            this.lblFillCardNumber.Visible = false;
            // 
            // lblFillNameOnCard
            // 
            this.lblFillNameOnCard.AutoSize = true;
            this.lblFillNameOnCard.Location = new System.Drawing.Point(321, 261);
            this.lblFillNameOnCard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFillNameOnCard.Name = "lblFillNameOnCard";
            this.lblFillNameOnCard.Size = new System.Drawing.Size(61, 24);
            this.lblFillNameOnCard.TabIndex = 21;
            this.lblFillNameOnCard.Text = "label9";
            this.lblFillNameOnCard.Visible = false;
            // 
            // lblFillCardDescription
            // 
            this.lblFillCardDescription.AutoSize = true;
            this.lblFillCardDescription.Location = new System.Drawing.Point(272, 76);
            this.lblFillCardDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFillCardDescription.Name = "lblFillCardDescription";
            this.lblFillCardDescription.Size = new System.Drawing.Size(61, 24);
            this.lblFillCardDescription.TabIndex = 20;
            this.lblFillCardDescription.Text = "label9";
            this.lblFillCardDescription.Visible = false;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(325, 600);
            this.lblCVV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(61, 24);
            this.lblCVV.TabIndex = 17;
            this.lblCVV.Text = "label8";
            // 
            // iconBtn
            // 
            this.iconBtn.BackgroundImage = global::Appointment_Management.Properties.Resources.mastercard_icon;
            this.iconBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBtn.Location = new System.Drawing.Point(739, 406);
            this.iconBtn.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.iconBtn.Name = "iconBtn";
            this.iconBtn.Size = new System.Drawing.Size(54, 51);
            this.iconBtn.TabIndex = 16;
            this.iconBtn.UseVisualStyleBackColor = true;
            this.iconBtn.Click += new System.EventHandler(this.iconBtn_Click);
            this.iconBtn.MouseHover += new System.EventHandler(this.iconBtn_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblFillCardNumber);
            this.groupBox1.Controls.Add(this.lblFillCardDescription);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.payBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCardDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNameOnCard);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(53, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1138, 835);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Details";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(619, 583);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(288, 28);
            this.txtTotal.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 585);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total";
            // 
            // taApptCorrect
            // 
            this.taApptCorrect.ClearBeforeFill = true;
            // 
            // CardPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 967);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CardPaymentDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CardPaymentDetails";
            this.Load += new System.EventHandler(this.CardPaymentDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardDescription;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button iconBtn;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFillCVV;
        private System.Windows.Forms.Label lblFillCardNumber;
        private System.Windows.Forms.Label lblFillNameOnCard;
        private System.Windows.Forms.Label lblFillCardDescription;
        private System.Windows.Forms.Label lblInvalidCardNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private DSAppointmentTableAdapters.Appointment_CorrectTableAdapter taApptCorrect;
    }
}