using Emlak.Helper;
using Emlak.UI.CashBook;
using Emlak.UI.Contract;
using Emlak.UI.Settings;
using Emlak.UI.Person;
using Emlak.UI.Realty;
using Emlak.UI.Rental;
using Emlak.UI.Upcoming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Deployment.Application;
using System.Data.Entity.SqlServer;
using System.Data.Entity;
using AutoUpdaterDotNET;

namespace Emlak.UI
{
    public partial class FrmMain : BaseForm, INotifyPropertyChanged
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void LoadUpcomings()
        {
            DateTime today = new DateTime().AddMonths(1);

            using (Model.EmlakEntities db = new Model.EmlakEntities())
            {
                lblUpcomings.Text = "1 Ay İçinde Ödemesi Yaklaşan Borçlar (" + db.sp_getMonthlyRentalReport().Count() + ")";

                lblFinishedContracts.Text = "Biten Sözleşmeler (" + db.sp_getExpiredContracts().Count() + ")";
                lblDebtsToLandlord.Text = "Ev Sahiplerine Yapılacak Ödemeler (" + db.sp_getDebtsToLandlord().Count() + ")";
            }
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmContractAdd>();
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmContractList>(this, FormWindowState.Maximized);
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmPersonAdd>(-1);
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmPersonList>(this, FormWindowState.Maximized);
        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmRealtyAdd>(-1);
        }

        private void listeleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmRealtyList>(this, FormWindowState.Maximized);
        }

        private void ayİçindeÖdemeYapmasıGerekenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmUpcomingList>(this, FormWindowState.Maximized);
        }

        private void ekleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmCashBookAdd>(-1);
        }

        private void listeleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmCashBookList>(this, FormWindowState.Maximized);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadUpcomings();
        }

        private void lblUpcomings_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmUpcomingList>(this, FormWindowState.Maximized);
        }

        private void makbuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<Invoice.FrmInvoicePrepare>();
        }

        private void aylıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmMonthlyReportList>(this, FormWindowState.Maximized);
        }

        private void veritabanınıYedekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormHelper.ShowDialog<FrmBackupRestore>();
        }

        private void yıllıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmYearlyReportList>(this, FormWindowState.Maximized);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmAbout>();
        }

        private void kilitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            if (!frmLogin.IsLoggedin)
            {
                Application.Exit();
            }
        }

        private void şifreyiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmLoginSetting>();
        }
        

        private void lblFinishedContracts_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmContractExpired>(this, FormWindowState.Maximized);
        }

        private void evSahibineÖdenecekBorçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmDebtsToLandlord>(this, FormWindowState.Maximized);
        }

        private void bitenSözleşmelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmContractExpired>(this, FormWindowState.Maximized);
        }

        private void lblDebtsToLandlord_Click(object sender, EventArgs e)
        {
            FormHelper.Show<FrmDebtsToLandlord>(this, FormWindowState.Maximized);
        }

        private void raporAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmReportSettings>();
        }

        private void lblCompany_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmReportSettings>();
        }

        private void arkaplanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmSelectBackground>();
        }

        private void fontTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Font = fontDialog.Font;
                Properties.Settings.Default.Save();
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            AutoUpdater.Start("http://telgrafla.com/emlakupdate/app.xml");

            if (!Properties.Settings.Default.NoBackground && System.IO.File.Exists(Properties.Settings.Default.Background))
            {
                BackgroundImage = Image.FromFile(Properties.Settings.Default.Background);
            }
        }
    }
}
