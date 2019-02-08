namespace Emlak.UI.Realty
{
    partial class FrmRealtyAdd
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbTown = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cmbRealtyType = new System.Windows.Forms.ComboBox();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtApartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(189, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(270, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbTown
            // 
            this.cmbTown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTown.DropDownHeight = 212;
            this.cmbTown.FormattingEnabled = true;
            this.cmbTown.IntegralHeight = false;
            this.cmbTown.Location = new System.Drawing.Point(225, 65);
            this.cmbTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTown.Name = "cmbTown";
            this.cmbTown.Size = new System.Drawing.Size(120, 21);
            this.cmbTown.TabIndex = 3;
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.DropDownHeight = 212;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.IntegralHeight = false;
            this.cmbCity.Location = new System.Drawing.Point(95, 65);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(120, 21);
            this.cmbCity.TabIndex = 2;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(45, 70);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 15);
            this.label32.TabIndex = 204;
            this.label32.Text = "İl / İlçe:";
            // 
            // cmbRealtyType
            // 
            this.cmbRealtyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRealtyType.FormattingEnabled = true;
            this.cmbRealtyType.Location = new System.Drawing.Point(95, 39);
            this.cmbRealtyType.Name = "cmbRealtyType";
            this.cmbRealtyType.Size = new System.Drawing.Size(250, 21);
            this.cmbRealtyType.TabIndex = 1;
            // 
            // txtExplanation
            // 
            this.txtExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExplanation.Location = new System.Drawing.Point(95, 172);
            this.txtExplanation.MaxLength = 500;
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(250, 45);
            this.txtExplanation.TabIndex = 7;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.Location = new System.Drawing.Point(29, 178);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(60, 15);
            this.label42.TabIndex = 203;
            this.label42.Text = "Açıklama:";
            // 
            // txtApartment
            // 
            this.txtApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtApartment.Location = new System.Drawing.Point(95, 145);
            this.txtApartment.MaxLength = 500;
            this.txtApartment.Name = "txtApartment";
            this.txtApartment.Size = new System.Drawing.Size(250, 21);
            this.txtApartment.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 201;
            this.label4.Text = "Daire:";
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStreet.Location = new System.Drawing.Point(95, 118);
            this.txtStreet.MaxLength = 500;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(250, 21);
            this.txtStreet.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 199;
            this.label3.Text = "Cadde/Sokak:";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNeighborhood.Location = new System.Drawing.Point(95, 91);
            this.txtNeighborhood.MaxLength = 500;
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(250, 21);
            this.txtNeighborhood.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(34, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 200;
            this.label14.Text = "Mahalle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 197;
            this.label2.Text = "Emlak Tipi:";
            // 
            // txtDefinition
            // 
            this.txtDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDefinition.Location = new System.Drawing.Point(95, 12);
            this.txtDefinition.MaxLength = 500;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(250, 21);
            this.txtDefinition.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(41, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 202;
            this.label11.Text = "Tanımı:";
            // 
            // FrmRealtyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 260);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTown);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.cmbRealtyType);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.txtApartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNeighborhood);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.label11);
            this.Name = "FrmRealtyAdd";
            this.Text = "Gayrimenkul";
            this.Load += new System.EventHandler(this.FrmRealtyAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbTown;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cmbRealtyType;
        private System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtApartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Label label11;
    }
}