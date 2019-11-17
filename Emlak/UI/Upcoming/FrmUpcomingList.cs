using Emlak.Helper;
using Emlak.UI.Rental;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.UI.Upcoming
{
    public partial class FrmUpcomingList : BaseForm
    {
        public FrmUpcomingList()
        {
            InitializeComponent();
        }

        Model.EmlakEntities db = new Model.EmlakEntities();

        void ApplyStyle2Grid()
        {
            for (int i = 0; i < dgUpcoming.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dgUpcoming.Rows[i].Cells["DueDate"].Value.ToString()) < DateTime.Today)
                {
                    dgUpcoming.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else if (Convert.ToDateTime(dgUpcoming.Rows[i].Cells["DueDate"].Value.ToString()) == DateTime.Today)
                {
                    dgUpcoming.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                }
                else
                {
                    dgUpcoming.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
        public void LoadUpcomings()
        {
            var upcomings = db.sp_getMonthlyRentalReport().OrderBy(q => q.DueDate).ToList();

            dgUpcoming.DataSource = upcomings;


            dgUpcoming.Columns[0].HeaderText = "DebtId";
            dgUpcoming.Columns[1].HeaderText = "Dosya No";
            dgUpcoming.Columns[2].HeaderText = "Komisyon Mu?";
            dgUpcoming.Columns[3].HeaderText = "Son Ödeme Tarihi";
            dgUpcoming.Columns[4].HeaderText = "Kiracı";
            dgUpcoming.Columns[5].HeaderText = "Sözleşme Tanım";
            dgUpcoming.Columns[6].HeaderText = "Borç Tanım";
            dgUpcoming.Columns[7].HeaderText = "Borç Tutar";
            dgUpcoming.Columns[8].HeaderText = "Açıklama";
            dgUpcoming.Columns[9].HeaderText = "Sözleşme Bitiş Tarihi";


            dgUpcoming.Columns[0].Visible = dgUpcoming.Columns[2].Visible = false;
            lblTotalRecord.Text = "Kayıt sayısı: " + upcomings.Count;

            ApplyStyle2Grid();
        }

        public void LoadFilter()
        {
            var upcomings = db.sp_getMonthlyRentalReport().AsQueryable();


            if (chkIsRental.Checked && chkIsCommission.Checked)
            {
                upcomings = upcomings.Where(q => q.IsCommission == true || q.IsCommission == false);
            }
            if (chkIsCommission.Checked == true && chkIsRental.Checked == false)
            {
                upcomings = upcomings.Where(q => q.IsCommission == true);
            }
            if (chkIsRental.Checked == true && chkIsCommission.Checked == false)
            {
                upcomings = upcomings.Where(q => q.IsCommission == false);
            }

            if (txtFileNumber.Text.Trim().Length > 0)
            {
                upcomings = upcomings.Where(q => q.FileNumber.ToString().Contains(txtFileNumber.Text.ToLower()));
            }
            if (txtPartyName.Text.Trim().Length > 0)
            {
                upcomings = upcomings.Where(q => q.Kiracilar != null && q.Kiracilar.ToLower().Contains(txtPartyName.Text.ToLower()));
            }

            
            var result = upcomings.OrderBy(q => q.DueDate).ToList();

            dgUpcoming.DataSource = result;

            dgUpcoming.Columns[0].HeaderText = "DebtId";
            dgUpcoming.Columns[1].HeaderText = "Dosya No";
            dgUpcoming.Columns[2].HeaderText = "Komisyon Mu?";
            dgUpcoming.Columns[3].HeaderText = "Son Ödeme Tarihi";
            dgUpcoming.Columns[4].HeaderText = "Kiracı";
            dgUpcoming.Columns[5].HeaderText = "Sözleşme Tanım";
            dgUpcoming.Columns[6].HeaderText = "Borç Tanım";
            dgUpcoming.Columns[7].HeaderText = "Borç Tutar";
            dgUpcoming.Columns[8].HeaderText = "Açıklama";
            dgUpcoming.Columns[9].HeaderText = "Sözleşme Bitiş Tarihi";


            dgUpcoming.Columns[0].Visible = dgUpcoming.Columns[2].Visible = false;
            lblTotalRecord.Text = "Kayıt sayısı: " + result.Count;


            ApplyStyle2Grid();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgUpcoming, "Yaklaşan Ödemeler.xlsx");
            excelHelper.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPartyName.Text = "";
            dgUpcoming.DataSource = null;
            lblTotalRecord.Text = "...";
        }


        private void seçilenleriÖdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Seçilenler ödensin mi?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                for (int i = 0; i < dgUpcoming.SelectedRows.Count; i++)
                {
                    int debtId = int.Parse(dgUpcoming.SelectedRows[i].Cells[0].Value.ToString());
                    Model.Debt rental = db.Debt.Where(q => q.DebtId == debtId).FirstOrDefault();

                    rental.PaymentDate = DateTime.Now.ToShortDateString();
                    rental.IsPaidByTenant = rental.IsPaidToLandlord = true;

                }
                int num = db.SaveChanges();
                if (num > 0)
                {
                    MessageBox.Show(num + " adet ödeme tamamlandı.");
                }
                else
                {
                    MessageBox.Show("Ödeme yapılamadı!");
                }
            }
        }

        private void dgUpcoming_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgUpcoming.SelectedRows.Count > 0)
            {
                int rentalId = int.Parse(dgUpcoming.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmRentalAdd>(rentalId);
            }
        }

        private void KeyDownFilter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadFilter();
            }
        }

        private void FrmUpcomingList_Shown(object sender, EventArgs e)
        {
            dgUpcoming.DoubleBuffered(true);
            LoadUpcomings();
        }
    }
}
