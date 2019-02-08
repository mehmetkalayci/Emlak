namespace Emlak.UI.Upcoming
{
    partial class FrmDebtsToLandlord
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgDebtList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgUpcoming = new System.Windows.Forms.DataGridView();
            this.stsPerson = new System.Windows.Forms.StatusStrip();
            this.lblTotalRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLandlord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebtList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUpcoming)).BeginInit();
            this.stsPerson.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgDebtList);
            this.groupBox3.Controls.Add(this.dgUpcoming);
            this.groupBox3.Controls.Add(this.stsPerson);
            this.groupBox3.Location = new System.Drawing.Point(189, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 426);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ev Sahibine Ödenecek Borçlar";
            // 
            // dgDebtList
            // 
            this.dgDebtList.AccessibleName = "";
            this.dgDebtList.AllowUserToAddRows = false;
            this.dgDebtList.AllowUserToDeleteRows = false;
            this.dgDebtList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgDebtList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDebtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDebtList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgDebtList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDebtList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgDebtList.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgDebtList.Location = new System.Drawing.Point(3, 16);
            this.dgDebtList.MultiSelect = false;
            this.dgDebtList.Name = "dgDebtList";
            this.dgDebtList.ReadOnly = true;
            this.dgDebtList.RowHeadersWidth = 25;
            this.dgDebtList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDebtList.Size = new System.Drawing.Size(593, 385);
            this.dgDebtList.TabIndex = 8;
            this.dgDebtList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDebtList_CellContentDoubleClick);
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
            // dgUpcoming
            // 
            this.dgUpcoming.AccessibleName = "";
            this.dgUpcoming.AllowUserToAddRows = false;
            this.dgUpcoming.AllowUserToDeleteRows = false;
            this.dgUpcoming.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgUpcoming.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUpcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUpcoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUpcoming.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgUpcoming.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgUpcoming.Location = new System.Drawing.Point(3, 16);
            this.dgUpcoming.MultiSelect = false;
            this.dgUpcoming.Name = "dgUpcoming";
            this.dgUpcoming.ReadOnly = true;
            this.dgUpcoming.RowHeadersWidth = 25;
            this.dgUpcoming.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUpcoming.Size = new System.Drawing.Size(593, 385);
            this.dgUpcoming.TabIndex = 7;
            // 
            // stsPerson
            // 
            this.stsPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalRecord});
            this.stsPerson.Location = new System.Drawing.Point(3, 401);
            this.stsPerson.Name = "stsPerson";
            this.stsPerson.Padding = new System.Windows.Forms.Padding(2, 0, 15, 0);
            this.stsPerson.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stsPerson.Size = new System.Drawing.Size(593, 22);
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
            this.groupBox4.Controls.Add(this.txtLandlord);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtFileNumber);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtPartyName);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 426);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrele";
            // 
            // txtLandlord
            // 
            this.txtLandlord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLandlord.Location = new System.Drawing.Point(13, 125);
            this.txtLandlord.MaxLength = 25;
            this.txtLandlord.Name = "txtLandlord";
            this.txtLandlord.Size = new System.Drawing.Size(150, 20);
            this.txtLandlord.TabIndex = 2;
            this.txtLandlord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ev Sahibi";
            // 
            // txtFileNumber
            // 
            this.txtFileNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileNumber.Location = new System.Drawing.Point(13, 37);
            this.txtFileNumber.Name = "txtFileNumber";
            this.txtFileNumber.Size = new System.Drawing.Size(150, 20);
            this.txtFileNumber.TabIndex = 0;
            this.txtFileNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Dosya No";
            // 
            // txtPartyName
            // 
            this.txtPartyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartyName.Location = new System.Drawing.Point(13, 81);
            this.txtPartyName.MaxLength = 25;
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(150, 20);
            this.txtPartyName.TabIndex = 1;
            this.txtPartyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kiracı";
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Location = new System.Drawing.Point(13, 151);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // FrmDebtsToLandlord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = true;
            this.Name = "FrmDebtsToLandlord";
            this.Text = "Ev Sahiplerine Ödenecek Borçlar";
            this.Load += new System.EventHandler(this.FrmDebtsToLandlord_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDebtList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUpcoming)).EndInit();
            this.stsPerson.ResumeLayout(false);
            this.stsPerson.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgDebtList;
        private System.Windows.Forms.DataGridView dgUpcoming;
        private System.Windows.Forms.StatusStrip stsPerson;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalRecord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFileNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtLandlord;
        private System.Windows.Forms.Label label2;
    }
}