using Emlak.Helper;
using Emlak.UI.Rental;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.UI.Upcoming
{
    public partial class FrmDebtsToLandlord : BaseForm
    {
        public FrmDebtsToLandlord()
        {
            InitializeComponent();
        }


        Model.EmlakEntities db = new Model.EmlakEntities();

        public void LoadDebts()
        {

            var debts = db.sp_getDebtsToLandlord().AsQueryable();


            if (txtFileNumber.Text.Trim().Length > 0)
            {
                debts = debts.Where(q => q.FileNumber.ToString().Contains(txtFileNumber.Text.ToLower()));
            }
            if (txtPartyName.Text.Trim().Length > 0)
            {
                debts = debts.Where(q => q.Kiracilar != null && q.Kiracilar.ToLower().Contains(txtPartyName.Text.ToLower()));
            }
            if (txtLandlord.Text.Trim().Length > 0)
            {
                debts = debts.Where(q => q.LandlordFullName != null && q.LandlordFullName.ToLower().Contains(txtLandlord.Text.ToLower()));
            }
            if (txtContractDefinition.Text.Trim().Length > 0)
            {
                debts = debts.Where(q => q.RealtyDefinition.ToLower().StartsWith(txtContractDefinition.Text.ToLower()));
            }

            var debtList = debts.ToList();

            dgDebtList.DataSource = debtList;

            dgDebtList.Columns[0].HeaderText = "DebtId";
            dgDebtList.Columns[1].HeaderText = "Dosya No";
            dgDebtList.Columns[2].HeaderText = "Ev Sahibine Ödendi Mi?";
            dgDebtList.Columns[3].HeaderText = "Son Ödeme Tarihi";
            dgDebtList.Columns[4].HeaderText = "Ödeme Tarihi";
            dgDebtList.Columns[5].HeaderText = "Kiracı";
            dgDebtList.Columns[6].HeaderText = "Ev Sahibi";
            dgDebtList.Columns[7].HeaderText = "Sözleşme Tanım";
            dgDebtList.Columns[8].HeaderText = "Borç Tanım";
            dgDebtList.Columns[9].HeaderText = "Kira Ücreti";
            dgDebtList.Columns[10].HeaderText = "Açıklama";
            dgDebtList.Columns[11].HeaderText = "Sözleşme Bitiş Tarihi";


            dgDebtList.Columns[0].Visible = dgDebtList.Columns[2].Visible = false;
            lblTotalRecord.Text = "Kayıt sayısı: " + debtList.Count;

        }

        private void FrmDebtsToLandlord_Load(object sender, EventArgs e)
        {
            dgDebtList.DoubleBuffered(true);
            LoadDebts();
        }

        private void dgDebtList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDebtList.SelectedRows.Count > 0)
            {
                int debtId = int.Parse(dgDebtList.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmRentalAdd>(debtId);
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgDebtList, "Ev Sahiplerine Ödenecek Borçlar.xlsx");
            excelHelper.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadDebts();
        }

        private void KeyDownFilter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDebts();
            }
        }
    }
}
