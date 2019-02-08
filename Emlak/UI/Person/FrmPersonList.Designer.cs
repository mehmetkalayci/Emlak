namespace Emlak.UI.Person
{
    partial class FrmPersonList
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
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFilterFullName = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterCitizenshipId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stsPerson = new System.Windows.Forms.StatusStrip();
            this.lblTotalRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxPersonList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgPersonList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.stsPerson.SuspendLayout();
            this.cntxPersonList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(8, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.txtFilterFullName);
            this.groupBox4.Controls.Add(this.btnAll);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Controls.Add(this.txtFilterCitizenshipId);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 417);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrele";
            // 
            // txtFilterFullName
            // 
            this.txtFilterFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterFullName.Location = new System.Drawing.Point(9, 81);
            this.txtFilterFullName.Name = "txtFilterFullName";
            this.txtFilterFullName.Size = new System.Drawing.Size(149, 20);
            this.txtFilterFullName.TabIndex = 1;
            this.txtFilterFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // btnAll
            // 
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.Location = new System.Drawing.Point(83, 107);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "Hepsi";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Location = new System.Drawing.Point(8, 107);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterCitizenshipId
            // 
            this.txtFilterCitizenshipId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterCitizenshipId.Location = new System.Drawing.Point(9, 37);
            this.txtFilterCitizenshipId.MaxLength = 25;
            this.txtFilterCitizenshipId.Name = "txtFilterCitizenshipId";
            this.txtFilterCitizenshipId.Size = new System.Drawing.Size(149, 20);
            this.txtFilterCitizenshipId.TabIndex = 0;
            this.txtFilterCitizenshipId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFilter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC Kimlik No";
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
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // yeniEkleToolStripMenuItem
            // 
            this.yeniEkleToolStripMenuItem.Name = "yeniEkleToolStripMenuItem";
            this.yeniEkleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.yeniEkleToolStripMenuItem.Text = "Yeni Ekle";
            this.yeniEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniEkleToolStripMenuItem_Click);
            // 
            // cntxPersonList
            // 
            this.cntxPersonList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniEkleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.cntxPersonList.Name = "cntxPersonList";
            this.cntxPersonList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cntxPersonList.Size = new System.Drawing.Size(121, 92);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // dgPersonList
            // 
            this.dgPersonList.AccessibleName = "";
            this.dgPersonList.AllowUserToAddRows = false;
            this.dgPersonList.AllowUserToDeleteRows = false;
            this.dgPersonList.AllowUserToOrderColumns = true;
            this.dgPersonList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPersonList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonList.ContextMenuStrip = this.cntxPersonList;
            this.dgPersonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPersonList.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgPersonList.Location = new System.Drawing.Point(3, 16);
            this.dgPersonList.MultiSelect = false;
            this.dgPersonList.Name = "dgPersonList";
            this.dgPersonList.ReadOnly = true;
            this.dgPersonList.RowHeadersWidth = 25;
            this.dgPersonList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPersonList.Size = new System.Drawing.Size(577, 376);
            this.dgPersonList.TabIndex = 1;
            this.dgPersonList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersonList_CellContentDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgPersonList);
            this.groupBox3.Controls.Add(this.stsPerson);
            this.groupBox3.Location = new System.Drawing.Point(189, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 417);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kişi Listesi";
            // 
            // FrmPersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.Name = "FrmPersonList";
            this.Text = "Kiracı Listesi";
            this.Load += new System.EventHandler(this.FrmPersonList_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.stsPerson.ResumeLayout(false);
            this.stsPerson.PerformLayout();
            this.cntxPersonList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFilterFullName;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterCitizenshipId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip stsPerson;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalRecord;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniEkleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cntxPersonList;
        private System.Windows.Forms.DataGridView dgPersonList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
    }
}