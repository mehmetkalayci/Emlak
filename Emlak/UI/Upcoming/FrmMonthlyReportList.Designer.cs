namespace Emlak.UI.Upcoming
{
    partial class FrmMonthlyReportList
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgUpcoming = new System.Windows.Forms.DataGridView();
            this.stsPerson = new System.Windows.Forms.StatusStrip();
            this.lblTotalRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFileNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtMonth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpcoming)).BeginInit();
            this.stsPerson.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazdırToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgUpcoming);
            this.groupBox3.Controls.Add(this.stsPerson);
            this.groupBox3.Location = new System.Drawing.Point(189, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 417);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Listesi";
            // 
            // dgUpcoming
            // 
            this.dgUpcoming.AccessibleName = "";
            this.dgUpcoming.AllowUserToAddRows = false;
            this.dgUpcoming.AllowUserToDeleteRows = false;
            this.dgUpcoming.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgUpcoming.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUpcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUpcoming.ContextMenuStrip = this.contextMenuStrip1;
            this.dgUpcoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUpcoming.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgUpcoming.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgUpcoming.Location = new System.Drawing.Point(3, 16);
            this.dgUpcoming.MultiSelect = false;
            this.dgUpcoming.Name = "dgUpcoming";
            this.dgUpcoming.ReadOnly = true;
            this.dgUpcoming.RowHeadersWidth = 25;
            this.dgUpcoming.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUpcoming.Size = new System.Drawing.Size(577, 376);
            this.dgUpcoming.TabIndex = 7;
            this.dgUpcoming.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUpcoming_CellContentDoubleClick);
            this.dgUpcoming.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgUpcoming_CellFormatting);
            // 
            // stsPerson
            // 
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
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.txtFileNumber);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtPartyName);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Controls.Add(this.dtMonth);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 417);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrele";
            // 
            // txtFileNumber
            // 
            this.txtFileNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileNumber.Location = new System.Drawing.Point(12, 66);
            this.txtFileNumber.Name = "txtFileNumber";
            this.txtFileNumber.Size = new System.Drawing.Size(150, 20);
            this.txtFileNumber.TabIndex = 1;
            this.txtFileNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Dosya No";
            // 
            // txtPartyName
            // 
            this.txtPartyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartyName.Location = new System.Drawing.Point(12, 110);
            this.txtPartyName.MaxLength = 25;
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(150, 20);
            this.txtPartyName.TabIndex = 2;
            this.txtPartyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kiracı";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 379);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Yaklaşan Borçlar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Location = new System.Drawing.Point(12, 136);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtMonth
            // 
            this.dtMonth.CustomFormat = "MMMM yyyy";
            this.dtMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonth.Location = new System.Drawing.Point(12, 22);
            this.dtMonth.Name = "dtMonth";
            this.dtMonth.Size = new System.Drawing.Size(150, 20);
            this.dtMonth.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.BackColor = System.Drawing.Color.YellowGreen;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 359);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ödendi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 339);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ödenmedi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMonthlyReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.Name = "FrmMonthlyReportList";
            this.Text = "Aylık Rapor";
            this.Load += new System.EventHandler(this.FrmMonthlyReportList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpcoming)).EndInit();
            this.stsPerson.ResumeLayout(false);
            this.stsPerson.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgUpcoming;
        private System.Windows.Forms.StatusStrip stsPerson;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalRecord;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFileNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.Label label3;
    }
}