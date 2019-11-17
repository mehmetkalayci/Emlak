namespace Emlak.UI.Contract
{
    partial class FrmContractExpired
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
            this.components = new System.ComponentModel.Container();
            this.txtFileNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtEndingDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartingDate = new System.Windows.Forms.DateTimePicker();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtRealtyDefinition = new System.Windows.Forms.TextBox();
            this.txtLandlord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stsPerson = new System.Windows.Forms.StatusStrip();
            this.lblTotalRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgExpiredContracts = new System.Windows.Forms.DataGridView();
            this.cntxContractList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sözleşmeyiAktiveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4.SuspendLayout();
            this.stsPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpiredContracts)).BeginInit();
            this.cntxContractList.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileNumber
            // 
            this.txtFileNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileNumber.Location = new System.Drawing.Point(9, 37);
            this.txtFileNumber.Name = "txtFileNumber";
            this.txtFileNumber.Size = new System.Drawing.Size(150, 20);
            this.txtFileNumber.TabIndex = 0;
            this.txtFileNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dosya No";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(9, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.txtFileNumber);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.dtEndingDate);
            this.groupBox4.Controls.Add(this.dtStartingDate);
            this.groupBox4.Controls.Add(this.btnAll);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Controls.Add(this.txtRealtyDefinition);
            this.groupBox4.Controls.Add(this.txtLandlord);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtPartyName);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 417);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrele";
            // 
            // dtEndingDate
            // 
            this.dtEndingDate.Checked = false;
            this.dtEndingDate.Location = new System.Drawing.Point(9, 125);
            this.dtEndingDate.Name = "dtEndingDate";
            this.dtEndingDate.ShowCheckBox = true;
            this.dtEndingDate.Size = new System.Drawing.Size(150, 20);
            this.dtEndingDate.TabIndex = 2;
            this.dtEndingDate.ValueChanged += new System.EventHandler(this.dtValueChangedFilter);
            // 
            // dtStartingDate
            // 
            this.dtStartingDate.Checked = false;
            this.dtStartingDate.Location = new System.Drawing.Point(9, 81);
            this.dtStartingDate.Name = "dtStartingDate";
            this.dtStartingDate.ShowCheckBox = true;
            this.dtStartingDate.Size = new System.Drawing.Size(150, 20);
            this.dtStartingDate.TabIndex = 1;
            this.dtStartingDate.ValueChanged += new System.EventHandler(this.dtValueChangedFilter);
            // 
            // btnAll
            // 
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.Location = new System.Drawing.Point(84, 283);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "Hepsi";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Location = new System.Drawing.Point(9, 283);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtRealtyDefinition
            // 
            this.txtRealtyDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRealtyDefinition.Location = new System.Drawing.Point(9, 169);
            this.txtRealtyDefinition.Name = "txtRealtyDefinition";
            this.txtRealtyDefinition.Size = new System.Drawing.Size(150, 20);
            this.txtRealtyDefinition.TabIndex = 3;
            this.txtRealtyDefinition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // txtLandlord
            // 
            this.txtLandlord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLandlord.Location = new System.Drawing.Point(9, 213);
            this.txtLandlord.Name = "txtLandlord";
            this.txtLandlord.Size = new System.Drawing.Size(150, 20);
            this.txtLandlord.TabIndex = 4;
            this.txtLandlord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tanım";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kiraya Veren";
            // 
            // txtPartyName
            // 
            this.txtPartyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartyName.Location = new System.Drawing.Point(9, 257);
            this.txtPartyName.MaxLength = 25;
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(150, 20);
            this.txtPartyName.TabIndex = 5;
            this.txtPartyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Taraf Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // stsPerson
            // 
            this.stsPerson.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Emlak.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stsPerson.Font = global::Emlak.Properties.Settings.Default.Font;
            this.stsPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalRecord});
            this.stsPerson.Location = new System.Drawing.Point(3, 392);
            this.stsPerson.Name = "stsPerson";
            this.stsPerson.Padding = new System.Windows.Forms.Padding(2, 0, 15, 0);
            this.stsPerson.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stsPerson.Size = new System.Drawing.Size(577, 22);
            this.stsPerson.SizingGrip = false;
            this.stsPerson.TabIndex = 0;
            // 
            // lblTotalRecord
            // 
            this.lblTotalRecord.Name = "lblTotalRecord";
            this.lblTotalRecord.Size = new System.Drawing.Size(16, 17);
            this.lblTotalRecord.Text = "...";
            // 
            // dgExpiredContracts
            // 
            this.dgExpiredContracts.AccessibleName = "";
            this.dgExpiredContracts.AllowUserToAddRows = false;
            this.dgExpiredContracts.AllowUserToDeleteRows = false;
            this.dgExpiredContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgExpiredContracts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgExpiredContracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgExpiredContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExpiredContracts.ContextMenuStrip = this.cntxContractList;
            this.dgExpiredContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgExpiredContracts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgExpiredContracts.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgExpiredContracts.Location = new System.Drawing.Point(3, 16);
            this.dgExpiredContracts.MultiSelect = false;
            this.dgExpiredContracts.Name = "dgExpiredContracts";
            this.dgExpiredContracts.ReadOnly = true;
            this.dgExpiredContracts.RowHeadersWidth = 25;
            this.dgExpiredContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgExpiredContracts.Size = new System.Drawing.Size(577, 376);
            this.dgExpiredContracts.TabIndex = 1;
            this.dgExpiredContracts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExpiredContracts_CellContentDoubleClick);
            // 
            // cntxContractList
            // 
            this.cntxContractList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.toolStripMenuItem1,
            this.yazdırToolStripMenuItem,
            this.toolStripSeparator1,
            this.sözleşmeyiAktiveEtToolStripMenuItem});
            this.cntxContractList.Name = "cntxPersonList";
            this.cntxContractList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cntxContractList.Size = new System.Drawing.Size(182, 98);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "Sil";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // sözleşmeyiAktiveEtToolStripMenuItem
            // 
            this.sözleşmeyiAktiveEtToolStripMenuItem.Name = "sözleşmeyiAktiveEtToolStripMenuItem";
            this.sözleşmeyiAktiveEtToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sözleşmeyiAktiveEtToolStripMenuItem.Text = "Sözleşmeyi Aktive Et";
            this.sözleşmeyiAktiveEtToolStripMenuItem.Click += new System.EventHandler(this.sözleşmeyiAktiveEtToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgExpiredContracts);
            this.groupBox3.Controls.Add(this.stsPerson);
            this.groupBox3.Location = new System.Drawing.Point(189, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 417);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Süresi Dolan Sözleşmeler Listesi";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // FrmContractExpired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.Name = "FrmContractExpired";
            this.Text = "Süresi Dolan Sözleşmeler";
            this.Load += new System.EventHandler(this.FrmContractExpired_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.stsPerson.ResumeLayout(false);
            this.stsPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpiredContracts)).EndInit();
            this.cntxContractList.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtEndingDate;
        private System.Windows.Forms.DateTimePicker dtStartingDate;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtRealtyDefinition;
        private System.Windows.Forms.TextBox txtLandlord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip stsPerson;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalRecord;
        private System.Windows.Forms.DataGridView dgExpiredContracts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cntxContractList;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeyiAktiveEtToolStripMenuItem;
    }
}