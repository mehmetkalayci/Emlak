namespace Emlak.UI.Settings
{
    partial class FrmSelectBackground
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkNoImage = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(454, 237);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Resim dosyası (*.jpg)|*.jpg";
            this.openFileDialog1.ShowHelp = true;
            this.openFileDialog1.Title = "Arkaplan Resmi Seçin";
            // 
            // chkNoImage
            // 
            this.chkNoImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNoImage.AutoSize = true;
            this.chkNoImage.BackColor = System.Drawing.Color.Transparent;
            this.chkNoImage.Checked = global::Emlak.Properties.Settings.Default.NoBackground;
            this.chkNoImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoImage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Emlak.Properties.Settings.Default, "NoBackground", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkNoImage.Location = new System.Drawing.Point(352, 246);
            this.chkNoImage.Name = "chkNoImage";
            this.chkNoImage.Size = new System.Drawing.Size(90, 17);
            this.chkNoImage.TabIndex = 2;
            this.chkNoImage.Text = "Arkaplan Yok";
            this.chkNoImage.UseVisualStyleBackColor = false;
            this.chkNoImage.CheckedChanged += new System.EventHandler(this.chkNoImage_CheckedChanged);
            // 
            // FrmSelectBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 271);
            this.Controls.Add(this.chkNoImage);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmSelectBackground";
            this.Text = "Arkaplan Seç";
            this.Load += new System.EventHandler(this.FrmSelectBackground_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkNoImage;
    }
}