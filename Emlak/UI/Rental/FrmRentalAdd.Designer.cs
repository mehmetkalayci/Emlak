namespace Emlak.UI.Rental
{
    partial class FrmRentalAdd
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDebtDefinition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.dtPaymentDateToLandlord = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRealtyDefinition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenantFullname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLandlordFullname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(263, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(182, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ödeme Tipi:";
            // 
            // txtDebtDefinition
            // 
            this.txtDebtDefinition.Location = new System.Drawing.Point(138, 91);
            this.txtDebtDefinition.Name = "txtDebtDefinition";
            this.txtDebtDefinition.ReadOnly = true;
            this.txtDebtDefinition.Size = new System.Drawing.Size(200, 20);
            this.txtDebtDefinition.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kiracı Ödediği Tarih:";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPaymentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaymentType.Enabled = false;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "",
            "BANKA",
            "DİĞER",
            "ELDEN"});
            this.cmbPaymentType.Location = new System.Drawing.Point(138, 221);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(200, 21);
            this.cmbPaymentType.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ödeme Bitiş Tarihi:";
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.Checked = false;
            this.dtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaymentDate.Location = new System.Drawing.Point(138, 169);
            this.dtPaymentDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.ShowCheckBox = true;
            this.dtPaymentDate.Size = new System.Drawing.Size(200, 20);
            this.dtPaymentDate.TabIndex = 6;
            this.dtPaymentDate.ValueChanged += new System.EventHandler(this.dtPaymentDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ücret:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Borç Tanım:";
            // 
            // dtDueDate
            // 
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDueDate.Location = new System.Drawing.Point(138, 143);
            this.dtDueDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtDueDate.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(138, 117);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(138, 248);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(200, 46);
            this.txtExplanation.TabIndex = 9;
            // 
            // dtPaymentDateToLandlord
            // 
            this.dtPaymentDateToLandlord.Checked = false;
            this.dtPaymentDateToLandlord.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaymentDateToLandlord.Location = new System.Drawing.Point(138, 195);
            this.dtPaymentDateToLandlord.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtPaymentDateToLandlord.Name = "dtPaymentDateToLandlord";
            this.dtPaymentDateToLandlord.ShowCheckBox = true;
            this.dtPaymentDateToLandlord.Size = new System.Drawing.Size(200, 20);
            this.dtPaymentDateToLandlord.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ev sahibine ödendi mi? :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Sözleşme Tanım:";
            // 
            // txtRealtyDefinition
            // 
            this.txtRealtyDefinition.Location = new System.Drawing.Point(138, 65);
            this.txtRealtyDefinition.Name = "txtRealtyDefinition";
            this.txtRealtyDefinition.ReadOnly = true;
            this.txtRealtyDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRealtyDefinition.Size = new System.Drawing.Size(200, 20);
            this.txtRealtyDefinition.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kiracı:";
            // 
            // txtTenantFullname
            // 
            this.txtTenantFullname.Location = new System.Drawing.Point(138, 13);
            this.txtTenantFullname.Name = "txtTenantFullname";
            this.txtTenantFullname.ReadOnly = true;
            this.txtTenantFullname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTenantFullname.Size = new System.Drawing.Size(200, 20);
            this.txtTenantFullname.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ev Sahibi:";
            // 
            // txtLandlordFullname
            // 
            this.txtLandlordFullname.Location = new System.Drawing.Point(138, 39);
            this.txtLandlordFullname.Name = "txtLandlordFullname";
            this.txtLandlordFullname.ReadOnly = true;
            this.txtLandlordFullname.Size = new System.Drawing.Size(200, 20);
            this.txtLandlordFullname.TabIndex = 1;
            // 
            // FrmRentalAdd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 336);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtPaymentDateToLandlord);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenantFullname);
            this.Controls.Add(this.txtRealtyDefinition);
            this.Controls.Add(this.txtLandlordFullname);
            this.Controls.Add(this.txtDebtDefinition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtPaymentDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDueDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtExplanation);
            this.Name = "FrmRentalAdd";
            this.Text = "Borç";
            this.Load += new System.EventHandler(this.FrmRentalAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDebtDefinition;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtPaymentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtDueDate;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.TextBox txtExplanation;
        public System.Windows.Forms.DateTimePicker dtPaymentDateToLandlord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtRealtyDefinition;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtTenantFullname;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtLandlordFullname;
    }
}