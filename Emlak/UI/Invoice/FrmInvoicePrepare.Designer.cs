namespace Emlak.UI.Invoice
{
    partial class FrmInvoicePrepare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoicePrepare));
            this.btnShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDates = new System.Windows.Forms.TextBox();
            this.txtAmounts = new System.Windows.Forms.TextBox();
            this.txtApartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(514, 312);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 28);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Hazırla";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(577, 65);
            this.label5.TabIndex = 6;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fiş No:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(44, 115);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Tarih: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(49, 141);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Saat:";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Location = new System.Drawing.Point(87, 213);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(176, 13);
            this.txtFullName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Adı Soyadı:";
            // 
            // txtTime
            // 
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Location = new System.Drawing.Point(87, 141);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(176, 13);
            this.txtTime.TabIndex = 2;
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Location = new System.Drawing.Point(87, 115);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(176, 13);
            this.txtDate.TabIndex = 1;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoiceNumber.Location = new System.Drawing.Point(87, 89);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(176, 13);
            this.txtInvoiceNumber.TabIndex = 0;
            // 
            // txtPaid
            // 
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaid.Location = new System.Drawing.Point(87, 245);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(176, 13);
            this.txtPaid.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tahsilat:";
            // 
            // txtRemaining
            // 
            this.txtRemaining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemaining.Location = new System.Drawing.Point(87, 271);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(176, 13);
            this.txtRemaining.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Kalan Borç:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "TARİH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "MİKTAR";
            // 
            // txtDates
            // 
            this.txtDates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDates.Location = new System.Drawing.Point(316, 108);
            this.txtDates.Multiline = true;
            this.txtDates.Name = "txtDates";
            this.txtDates.Size = new System.Drawing.Size(111, 176);
            this.txtDates.TabIndex = 7;
            this.txtDates.Text = "  \r\n";
            this.txtDates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmounts
            // 
            this.txtAmounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmounts.Location = new System.Drawing.Point(433, 108);
            this.txtAmounts.Multiline = true;
            this.txtAmounts.Name = "txtAmounts";
            this.txtAmounts.Size = new System.Drawing.Size(111, 176);
            this.txtAmounts.TabIndex = 8;
            this.txtAmounts.Text = "  \r\n";
            this.txtAmounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApartment
            // 
            this.txtApartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApartment.Location = new System.Drawing.Point(87, 167);
            this.txtApartment.Multiline = true;
            this.txtApartment.Name = "txtApartment";
            this.txtApartment.Size = new System.Drawing.Size(176, 40);
            this.txtApartment.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daire:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Emlak.Properties.Settings.Default, "CompanyName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCompanyName.Location = new System.Drawing.Point(15, 17);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(574, 17);
            this.lblCompanyName.TabIndex = 10;
            this.lblCompanyName.Text = global::Emlak.Properties.Settings.Default.CompanyName;
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Emlak.Properties.Settings.Default, "CompanyAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCompanyAddress.Location = new System.Drawing.Point(15, 34);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(574, 17);
            this.lblCompanyAddress.TabIndex = 10;
            this.lblCompanyAddress.Text = global::Emlak.Properties.Settings.Default.CompanyAddress;
            this.lblCompanyAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Emlak.Properties.Settings.Default, "CompanyPhone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblCompanyPhone.Location = new System.Drawing.Point(15, 51);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(574, 17);
            this.lblCompanyPhone.TabIndex = 10;
            this.lblCompanyPhone.Text = global::Emlak.Properties.Settings.Default.CompanyPhone;
            this.lblCompanyPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInvoicePrepare
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 352);
            this.Controls.Add(this.lblCompanyPhone);
            this.Controls.Add(this.lblCompanyAddress);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtAmounts);
            this.Controls.Add(this.txtDates);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtApartment);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtRemaining);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label5);
            this.Name = "FrmInvoicePrepare";
            this.Text = "Makbuz Yaz";
            this.Load += new System.EventHandler(this.FrmInvoiceShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDates;
        private System.Windows.Forms.TextBox txtAmounts;
        private System.Windows.Forms.TextBox txtApartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblCompanyPhone;
    }
}