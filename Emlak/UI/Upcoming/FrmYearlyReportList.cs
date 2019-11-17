using Emlak.Helper;
using Emlak.UI.Rental;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.UI.Upcoming
{
    public partial class FrmYearlyReportList : BaseForm
    {
        public FrmYearlyReportList()
        {
            InitializeComponent();
        }


        Model.EmlakEntities db = new Model.EmlakEntities();

        void ApplyStyle2Grid()
        {
            for (int i = 0; i < dgUpcoming.Rows.Count; i++)
            {
                if (bool.Parse(dgUpcoming.Rows[i].Cells["IsPaidByTenant"].Value.ToString()))
                {
                    dgUpcoming.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                else
                {
                    if (DateTime.Parse(dgUpcoming.Rows[i].Cells["DueDate"].Value.ToString()) > DateTime.Now)
                    {
                        dgUpcoming.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                    else
                    {
                        dgUpcoming.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                    }
                }
            }
        }


        public void LoadYearlyReport()
        {
            var debts = db.sp_getYearlyReport(dtMonth.Value.Year).OrderBy(q => q.DueDate).AsQueryable();

            if (txtFileNumber.Text.Trim().Length > 0)
            {
                debts = debts.Where(q => q.FileNumber.ToString().Contains(txtFileNumber.Text.ToLower()));
            }
            if (txtPartyName.Text.Trim().Length > 0)
            {
                debts = debts.Where(q => q.Kiracilar != null && q.Kiracilar.ToLower().Contains(txtPartyName.Text.ToLower()));
            }


            var debtList = debts.ToList();

            dgUpcoming.DataSource = debtList;

            dgUpcoming.Columns[0].HeaderText = "DebtId";
            dgUpcoming.Columns[1].HeaderText = "Dosya No";
            dgUpcoming.Columns[2].HeaderText = "Kiracı Ödedi Mi?";
            dgUpcoming.Columns[3].HeaderText = "Son Ödeme Tarihi";
            dgUpcoming.Columns[4].HeaderText = "Ödeme Tarihi";
            dgUpcoming.Columns[5].HeaderText = "Kiracı";
            dgUpcoming.Columns[6].HeaderText = "Sözleşme Tanım";
            dgUpcoming.Columns[7].HeaderText = "Tanım";
            dgUpcoming.Columns[8].HeaderText = "Kira Ücreti";
            dgUpcoming.Columns[9].HeaderText = "Açıklama";
            dgUpcoming.Columns[10].HeaderText = "Sözleşme Bitiş Tarihi";


            dgUpcoming.Columns[0].Visible = dgUpcoming.Columns[2].Visible = false;
            lblTotalRecord.Text = "Kayıt sayısı: " + debtList.Count;

            ApplyStyle2Grid();
        }


        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgUpcoming, "Yıllık Rapor.xlsx");
            excelHelper.ShowDialog();
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
                LoadYearlyReport();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadYearlyReport();
        }

        private void FrmYearlyReportList_Shown(object sender, EventArgs e)
        {
            dgUpcoming.DoubleBuffered(true);
            LoadYearlyReport();
        }
    }
}
