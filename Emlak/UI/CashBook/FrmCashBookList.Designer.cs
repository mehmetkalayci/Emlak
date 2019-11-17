namespace Emlak.UI.CashBook
{
    partial class FrmCashBookList
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
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.dtTransactionTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtTransactionTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblTotalRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgTransactionList = new System.Windows.Forms.DataGridView();
            this.cntxCashBookList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactionList)).BeginInit();
            this.cntxCashBookList.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "İşlem Tipi Seçin",
            "Giriş",
            "Çıkış"});
            this.cmbTransactionType.Location = new System.Drawing.Point(94, 71);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(139, 21);
            this.cmbTransactionType.TabIndex = 2;
            this.cmbTransactionType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTransactionType_KeyDown);
            // 
            // dtTransactionTimeEnd
            // 
            this.dtTransactionTimeEnd.Checked = false;
            this.dtTransactionTimeEnd.CustomFormat = "";
            this.dtTransactionTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransactionTimeEnd.Location = new System.Drawing.Point(94, 45);
            this.dtTransactionTimeEnd.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtTransactionTimeEnd.Name = "dtTransactionTimeEnd";
            this.dtTransactionTimeEnd.ShowCheckBox = true;
            this.dtTransactionTimeEnd.Size = new System.Drawing.Size(139, 20);
            this.dtTransactionTimeEnd.TabIndex = 1;
            this.dtTransactionTimeEnd.ValueChanged += new System.EventHandler(this.dtTransactionTimeStart_ValueChanged);
            // 
            // dtTransactionTimeStart
            // 
            this.dtTransactionTimeStart.Checked = false;
            this.dtTransactionTimeStart.CustomFormat = "";
            this.dtTransactionTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTransactionTimeStart.Location = new System.Drawing.Point(94, 19);
            this.dtTransactionTimeStart.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtTransactionTimeStart.Name = "dtTransactionTimeStart";
            this.dtTransactionTimeStart.ShowCheckBox = true;
            this.dtTransactionTimeStart.Size = new System.Drawing.Size(139, 20);
            this.dtTransactionTimeStart.TabIndex = 0;
            this.dtTransactionTimeStart.ValueChanged += new System.EventHandler(this.dtTransactionTimeStart_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tanım:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Bitiş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "İşlem Tipi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // txtDefinition
            // 
            this.txtDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDefinition.Location = new System.Drawing.Point(94, 98);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDefinition.Size = new System.Drawing.Size(139, 40);
            this.txtDefinition.TabIndex = 3;
            this.txtDefinition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTransactionType_KeyDown);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.Location = new System.Drawing.Point(94, 252);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(139, 23);
            this.btnLastMonth.TabIndex = 7;
            this.btnLastMonth.Text = "Son 1 Ay";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnLastWeek
            // 
            this.btnLastWeek.Location = new System.Drawing.Point(94, 223);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(139, 23);
            this.btnLastWeek.TabIndex = 6;
            this.btnLastWeek.Text = "Son 1 Hafta";
            this.btnLastWeek.UseVisualStyleBackColor = true;
            this.btnLastWeek.Click += new System.EventHandler(this.btnLastWeek_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(94, 165);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(139, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblTotalRecord
            // 
            this.lblTotalRecord.Name = "lblTotalRecord";
            this.lblTotalRecord.Size = new System.Drawing.Size(16, 17);
            this.lblTotalRecord.Text = "...";
            // 
            // dgTransactionList
            // 
            this.dgTransactionList.AccessibleName = "";
            this.dgTransactionList.AllowUserToAddRows = false;
            this.dgTransactionList.AllowUserToDeleteRows = false;
            this.dgTransactionList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTransactionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTransactionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactionList.ContextMenuStrip = this.cntxCashBookList;
            this.dgTransactionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTransactionList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgTransactionList.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgTransactionList.Location = new System.Drawing.Point(3, 16);
            this.dgTransactionList.MultiSelect = false;
            this.dgTransactionList.Name = "dgTransactionList";
            this.dgTransactionList.ReadOnly = true;
            this.dgTransactionList.RowHeadersWidth = 25;
            this.dgTransactionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransactionList.Size = new System.Drawing.Size(511, 376);
            this.dgTransactionList.TabIndex = 1;
            this.dgTransactionList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransactionList_CellContentDoubleClick);
            this.dgTransactionList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgTransactionList_CellFormatting);
            // 
            // cntxCashBookList
            // 
            this.cntxCashBookList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniEkleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.cntxCashBookList.Name = "cntxPersonList";
            this.cntxCashBookList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cntxCashBookList.Size = new System.Drawing.Size(121, 92);
            // 
            // yeniEkleToolStripMenuItem
            // 
            this.yeniEkleToolStripMenuItem.Name = "yeniEkleToolStripMenuItem";
            this.yeniEkleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.yeniEkleToolStripMenuItem.Text = "Yeni Ekle";
            this.yeniEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniEkleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::Emlak.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.statusStrip2.Font = global::Emlak.Properties.Settings.Default.Font;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalRecord});
            this.statusStrip2.Location = new System.Drawing.Point(3, 392);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(2, 0, 15, 0);
            this.statusStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip2.Size = new System.Drawing.Size(511, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgTransactionList);
            this.groupBox3.Controls.Add(this.statusStrip2);
            this.groupBox3.Location = new System.Drawing.Point(257, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 417);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlem Listesi";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.cmbTransactionType);
            this.groupBox4.Controls.Add(this.dtTransactionTimeEnd);
            this.groupBox4.Controls.Add(this.dtTransactionTimeStart);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtDefinition);
            this.groupBox4.Controls.Add(this.btnToday);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnLastMonth);
            this.groupBox4.Controls.Add(this.btnLastWeek);
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 417);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrele";
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(94, 194);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(139, 23);
            this.btnToday.TabIndex = 5;
            this.btnToday.Text = "Bugün";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(94, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmCashBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FrmCashBookList";
            this.Text = "Kasa Raporu";
            this.Load += new System.EventHandler(this.FrmCashBookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactionList)).EndInit();
            this.cntxCashBookList.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.DateTimePicker dtTransactionTimeEnd;
        private System.Windows.Forms.DateTimePicker dtTransactionTimeStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnLastWeek;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalRecord;
        private System.Windows.Forms.DataGridView dgTransactionList;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.ContextMenuStrip cntxCashBookList;
        private System.Windows.Forms.ToolStripMenuItem yeniEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
    }
}