namespace Emlak.UI
{
    partial class FrmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUpcomings = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFinishedContracts = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDebtsToLandlord = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.cariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gayrimenkulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bitenSözleşmelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeYapmasıGerekenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yıllıkRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.evSahibineÖdenecekBorçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.makbuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veritabanınıYedekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreyiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCompany,
            this.lblUpcomings,
            this.lblFinishedContracts,
            this.lblDebtsToLandlord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(784, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            // 
            // lblCompany
            // 
            this.lblCompany.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCompany.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblCompany.Size = new System.Drawing.Size(90, 19);
            this.lblCompany.Text = global::Emlak.Properties.Settings.Default.CompanyName;
            this.lblCompany.Click += new System.EventHandler(this.lblCompany_Click);
            // 
            // lblUpcomings
            // 
            this.lblUpcomings.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblUpcomings.IsLink = true;
            this.lblUpcomings.LinkColor = System.Drawing.Color.Black;
            this.lblUpcomings.Name = "lblUpcomings";
            this.lblUpcomings.Size = new System.Drawing.Size(210, 19);
            this.lblUpcomings.Text = "1 Ay İçinde Ödemesi Yaklaşan Borçlar ";
            this.lblUpcomings.VisitedLinkColor = System.Drawing.Color.Black;
            this.lblUpcomings.Click += new System.EventHandler(this.lblUpcomings_Click);
            // 
            // lblFinishedContracts
            // 
            this.lblFinishedContracts.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblFinishedContracts.IsLink = true;
            this.lblFinishedContracts.LinkColor = System.Drawing.Color.Black;
            this.lblFinishedContracts.Name = "lblFinishedContracts";
            this.lblFinishedContracts.Size = new System.Drawing.Size(103, 19);
            this.lblFinishedContracts.Text = "Biten Sözleşmeler";
            this.lblFinishedContracts.Click += new System.EventHandler(this.lblFinishedContracts_Click);
            // 
            // lblDebtsToLandlord
            // 
            this.lblDebtsToLandlord.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblDebtsToLandlord.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblDebtsToLandlord.IsLink = true;
            this.lblDebtsToLandlord.LinkColor = System.Drawing.Color.Black;
            this.lblDebtsToLandlord.Name = "lblDebtsToLandlord";
            this.lblDebtsToLandlord.Size = new System.Drawing.Size(191, 19);
            this.lblDebtsToLandlord.Text = "Ev Sahiplerine Yapılacak Ödemeler";
            this.lblDebtsToLandlord.Click += new System.EventHandler(this.lblDebtsToLandlord_Click);
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cariToolStripMenuItem,
            this.gayrimenkulToolStripMenuItem,
            this.sözleşmeToolStripMenuItem,
            this.kasaToolStripMenuItem,
            this.ödemeYapmasıGerekenlerToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(784, 24);
            this.mnMain.TabIndex = 4;
            this.mnMain.Text = "menuStrip1";
            // 
            // cariToolStripMenuItem
            // 
            this.cariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.cariToolStripMenuItem.Name = "cariToolStripMenuItem";
            this.cariToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.cariToolStripMenuItem.Text = "Kiracı";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // gayrimenkulToolStripMenuItem
            // 
            this.gayrimenkulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem2,
            this.listeleToolStripMenuItem2});
            this.gayrimenkulToolStripMenuItem.Name = "gayrimenkulToolStripMenuItem";
            this.gayrimenkulToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.gayrimenkulToolStripMenuItem.Text = "Gayrimenkul";
            // 
            // ekleToolStripMenuItem2
            // 
            this.ekleToolStripMenuItem2.Name = "ekleToolStripMenuItem2";
            this.ekleToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.ekleToolStripMenuItem2.Text = "Ekle";
            this.ekleToolStripMenuItem2.Click += new System.EventHandler(this.ekleToolStripMenuItem2_Click);
            // 
            // listeleToolStripMenuItem2
            // 
            this.listeleToolStripMenuItem2.Name = "listeleToolStripMenuItem2";
            this.listeleToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.listeleToolStripMenuItem2.Text = "Listele";
            this.listeleToolStripMenuItem2.Click += new System.EventHandler(this.listeleToolStripMenuItem2_Click);
            // 
            // sözleşmeToolStripMenuItem
            // 
            this.sözleşmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem1,
            this.listeleToolStripMenuItem1,
            this.toolStripSeparator3,
            this.bitenSözleşmelerToolStripMenuItem});
            this.sözleşmeToolStripMenuItem.Name = "sözleşmeToolStripMenuItem";
            this.sözleşmeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.sözleşmeToolStripMenuItem.Text = "Sözleşme";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            this.ekleToolStripMenuItem1.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // listeleToolStripMenuItem1
            // 
            this.listeleToolStripMenuItem1.Name = "listeleToolStripMenuItem1";
            this.listeleToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.listeleToolStripMenuItem1.Text = "Listele";
            this.listeleToolStripMenuItem1.Click += new System.EventHandler(this.listeleToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // bitenSözleşmelerToolStripMenuItem
            // 
            this.bitenSözleşmelerToolStripMenuItem.Name = "bitenSözleşmelerToolStripMenuItem";
            this.bitenSözleşmelerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.bitenSözleşmelerToolStripMenuItem.Text = "Biten Sözleşmeler";
            this.bitenSözleşmelerToolStripMenuItem.Click += new System.EventHandler(this.bitenSözleşmelerToolStripMenuItem_Click);
            // 
            // kasaToolStripMenuItem
            // 
            this.kasaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem3,
            this.listeleToolStripMenuItem3});
            this.kasaToolStripMenuItem.Name = "kasaToolStripMenuItem";
            this.kasaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.kasaToolStripMenuItem.Text = "Kasa";
            // 
            // ekleToolStripMenuItem3
            // 
            this.ekleToolStripMenuItem3.Name = "ekleToolStripMenuItem3";
            this.ekleToolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.ekleToolStripMenuItem3.Text = "Ekle";
            this.ekleToolStripMenuItem3.Click += new System.EventHandler(this.ekleToolStripMenuItem3_Click);
            // 
            // listeleToolStripMenuItem3
            // 
            this.listeleToolStripMenuItem3.Name = "listeleToolStripMenuItem3";
            this.listeleToolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.listeleToolStripMenuItem3.Text = "Listele";
            this.listeleToolStripMenuItem3.Click += new System.EventHandler(this.listeleToolStripMenuItem3_Click);
            // 
            // ödemeYapmasıGerekenlerToolStripMenuItem
            // 
            this.ödemeYapmasıGerekenlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem,
            this.aylıkRaporToolStripMenuItem,
            this.yıllıkRaporToolStripMenuItem,
            this.toolStripSeparator1,
            this.evSahibineÖdenecekBorçlarToolStripMenuItem,
            this.toolStripSeparator2,
            this.makbuzToolStripMenuItem});
            this.ödemeYapmasıGerekenlerToolStripMenuItem.Name = "ödemeYapmasıGerekenlerToolStripMenuItem";
            this.ödemeYapmasıGerekenlerToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ödemeYapmasıGerekenlerToolStripMenuItem.Text = "Raporlar";
            // 
            // ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem
            // 
            this.ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem.Name = "ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem";
            this.ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem.Text = "1 Ay İçinde Ödemesi Yaklaşan Borçlar ";
            this.ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem.Click += new System.EventHandler(this.ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem_Click);
            // 
            // aylıkRaporToolStripMenuItem
            // 
            this.aylıkRaporToolStripMenuItem.Name = "aylıkRaporToolStripMenuItem";
            this.aylıkRaporToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.aylıkRaporToolStripMenuItem.Text = "Aylık Rapor";
            this.aylıkRaporToolStripMenuItem.Click += new System.EventHandler(this.aylıkRaporToolStripMenuItem_Click);
            // 
            // yıllıkRaporToolStripMenuItem
            // 
            this.yıllıkRaporToolStripMenuItem.Name = "yıllıkRaporToolStripMenuItem";
            this.yıllıkRaporToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.yıllıkRaporToolStripMenuItem.Text = "Yıllık Rapor";
            this.yıllıkRaporToolStripMenuItem.Click += new System.EventHandler(this.yıllıkRaporToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(270, 6);
            // 
            // evSahibineÖdenecekBorçlarToolStripMenuItem
            // 
            this.evSahibineÖdenecekBorçlarToolStripMenuItem.Name = "evSahibineÖdenecekBorçlarToolStripMenuItem";
            this.evSahibineÖdenecekBorçlarToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.evSahibineÖdenecekBorçlarToolStripMenuItem.Text = "Ev Sahibine Ödenecek Borçlar";
            this.evSahibineÖdenecekBorçlarToolStripMenuItem.Click += new System.EventHandler(this.evSahibineÖdenecekBorçlarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(270, 6);
            // 
            // makbuzToolStripMenuItem
            // 
            this.makbuzToolStripMenuItem.Name = "makbuzToolStripMenuItem";
            this.makbuzToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.makbuzToolStripMenuItem.Text = "Makbuz";
            this.makbuzToolStripMenuItem.Click += new System.EventHandler(this.makbuzToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporAyarlarıToolStripMenuItem,
            this.veritabanınıYedekleToolStripMenuItem,
            this.şifreyiDeğiştirToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.kilitleToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // raporAyarlarıToolStripMenuItem
            // 
            this.raporAyarlarıToolStripMenuItem.Name = "raporAyarlarıToolStripMenuItem";
            this.raporAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.raporAyarlarıToolStripMenuItem.Text = "Rapor Ayarları";
            this.raporAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.raporAyarlarıToolStripMenuItem_Click);
            // 
            // veritabanınıYedekleToolStripMenuItem
            // 
            this.veritabanınıYedekleToolStripMenuItem.Name = "veritabanınıYedekleToolStripMenuItem";
            this.veritabanınıYedekleToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.veritabanınıYedekleToolStripMenuItem.Text = "Veritabınını Yedekle && Geri Yükle";
            this.veritabanınıYedekleToolStripMenuItem.Click += new System.EventHandler(this.veritabanınıYedekleToolStripMenuItem_Click);
            // 
            // şifreyiDeğiştirToolStripMenuItem
            // 
            this.şifreyiDeğiştirToolStripMenuItem.Name = "şifreyiDeğiştirToolStripMenuItem";
            this.şifreyiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.şifreyiDeğiştirToolStripMenuItem.Text = "Şifreyi Değiştir";
            this.şifreyiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreyiDeğiştirToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // kilitleToolStripMenuItem
            // 
            this.kilitleToolStripMenuItem.Name = "kilitleToolStripMenuItem";
            this.kilitleToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.kilitleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.kilitleToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.kilitleToolStripMenuItem.Text = "Kilitle";
            this.kilitleToolStripMenuItem.Click += new System.EventHandler(this.kilitleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.IsCloseable = false;
            this.IsMdiContainer = true;
            this.MaximizeBox = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kira Takip";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCompany;
        private System.Windows.Forms.ToolStripStatusLabel lblUpcomings;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem cariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gayrimenkulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ödemeYapmasıGerekenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem makbuzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veritabanınıYedekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yıllıkRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreyiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblFinishedContracts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem evSahibineÖdenecekBorçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem bitenSözleşmelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblDebtsToLandlord;
        private System.Windows.Forms.ToolStripMenuItem raporAyarlarıToolStripMenuItem;
    }
}