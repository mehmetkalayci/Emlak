using Emlak.Helper;
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

namespace Emlak.UI.Contract
{
    public partial class FrmContractExpired : BaseForm
    {
        public FrmContractExpired()
        {
            InitializeComponent();
        }


        Model.EmlakEntities db = new Model.EmlakEntities();


        public void LoadExpiredContracts()
        {
            var contracts = db.sp_getExpiredContracts().OrderByDescending(q => q.EndingDate).ToList();

            dgExpiredContracts.DataSource = contracts;

            dgExpiredContracts.Columns[0].HeaderText = "ContractId";
            dgExpiredContracts.Columns[1].HeaderText = "Dosya No";
            dgExpiredContracts.Columns[2].HeaderText = "Taraf Bilgileri";
            dgExpiredContracts.Columns[3].HeaderText = "Kiraya Veren";
            dgExpiredContracts.Columns[4].HeaderText = "Kiraya Veren Telefon";
            dgExpiredContracts.Columns[5].HeaderText = "Sözleşme Tanımı";
            dgExpiredContracts.Columns[6].HeaderText = "Sözleşme Başlangıç Tarihi";
            dgExpiredContracts.Columns[7].HeaderText = "Sözleşme Bitiş Tarihi";
            dgExpiredContracts.Columns[8].HeaderText = "Aylık Kira";
            dgExpiredContracts.Columns[9].HeaderText = "Kira Müddeti";
            dgExpiredContracts.Columns[10].HeaderText = "Açıklama";


            dgExpiredContracts.Columns[0].Visible = false;

            lblTotalRecord.Text = "Bulunan kayıt sayısı: " + contracts.Count;
        }

        public void LoadFilter()
        {
            var contracts = db.sp_getExpiredContracts().AsQueryable();

            if (txtFileNumber.Text.Trim().Length > 0)
            {
                contracts = contracts.Where(q => q.FileNumber.ToString().Contains(txtFileNumber.Text.ToLower()));
            }
            if (dtStartingDate.Checked)
            {
                contracts = contracts.Where(q => q.StartingDate >= dtStartingDate.Value);
            }
            if (dtEndingDate.Checked)
            {
                contracts = contracts.Where(q => q.EndingDate <= dtEndingDate.Value);
            }
            if (txtRealtyDefinition.Text.Trim().Length > 0)
            {
                contracts = contracts.Where(q => q.RealtyDefinition.ToString().Contains(txtRealtyDefinition.Text.ToLower()));
            }
            if (txtLandlord.Text.Trim().Length > 0)
            {
                contracts = contracts.Where(q => q.LandlordFullName.ToLower().StartsWith(txtLandlord.Text.ToLower(), StringComparison.OrdinalIgnoreCase));
            }
            if (txtPartyName.Text.Trim().Length > 0)
            {
                contracts = contracts.Where(q => q.Kiracilar != null && q.Kiracilar.ToLower().Contains(txtPartyName.Text.ToLower()));
            }

            var result = contracts.OrderByDescending(q => q.EndingDate).ToList();

            dgExpiredContracts.DataSource = result;

            dgExpiredContracts.Columns[0].HeaderText = "ContractId";
            dgExpiredContracts.Columns[1].HeaderText = "Dosya No";
            dgExpiredContracts.Columns[2].HeaderText = "Taraf Bilgileri";
            dgExpiredContracts.Columns[3].HeaderText = "Kiraya Veren";
            dgExpiredContracts.Columns[4].HeaderText = "Kiraya Veren Telefon";
            dgExpiredContracts.Columns[5].HeaderText = "Sözleşme Tanımı";
            dgExpiredContracts.Columns[6].HeaderText = "Sözleşme Başlangıç Tarihi";
            dgExpiredContracts.Columns[7].HeaderText = "Sözleşme Bitiş Tarihi";
            dgExpiredContracts.Columns[8].HeaderText = "Aylık Kira";
            dgExpiredContracts.Columns[9].HeaderText = "Kira Müddeti";
            dgExpiredContracts.Columns[10].HeaderText = "Açıklama";


            dgExpiredContracts.Columns[0].Visible = false;

            lblTotalRecord.Text = "Bulunan kayıt sayısı: " + result.Count;
        }

        private void FrmContractExpired_Load(object sender, EventArgs e)
        {
            LoadExpiredContracts();
        }

        private void KeyDownFilter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadFilter();
            }
        }

        private void dtValueChangedFilter(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadExpiredContracts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtEndingDate.Value = dtStartingDate.Value = DateTime.Today;
            dtEndingDate.Checked = dtStartingDate.Checked = false;
            txtLandlord.Text = txtPartyName.Text = "";
            dgExpiredContracts.DataSource = null;
            lblTotalRecord.Text = "...";
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgExpiredContracts.SelectedRows.Count > 0)
            {
                int contractId = int.Parse(dgExpiredContracts.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmContractEdit>(contractId);
            }
            else
            {
                MessageHelper.GridSatirSecmediniz();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgExpiredContracts.SelectedRows.Count > 0)
            {
                int contractId = int.Parse(dgExpiredContracts.SelectedRows[0].Cells[0].Value.ToString());

                if (MessageHelper.KayitSil() == DialogResult.Yes)
                {
                    db.Contract.Remove(db.Contract.Where(q => q.ContractId == contractId).Single());
                    int num = db.SaveChanges();

                    if (num > 0)
                    {
                        LoadExpiredContracts();

                        FrmMain frmMain = (FrmMain)Application.OpenForms["FrmMain"];
                        if (frmMain != null)
                        {
                            frmMain.LoadUpcomings();
                        }
                        FrmUpcomingList frmUpcomingRentals = (FrmUpcomingList)Application.OpenForms["FrmUpcomingRentals"];
                        if (frmUpcomingRentals != null)
                        {
                            frmUpcomingRentals.LoadUpcomings();
                        }

                        MessageHelper.KayitSilindi();
                    }
                    else
                    {
                        MessageHelper.BeklenmedikHata();
                    }
                }
            }
            else
            {
                Helper.MessageHelper.GridSatirSecmediniz();
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgExpiredContracts, "Biten Sözleşmeler Listesi.xlsx");
            excelHelper.ShowDialog();
        }

        private void dgExpiredContracts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgExpiredContracts.SelectedRows.Count > 0)
            {
                int contractId = int.Parse(dgExpiredContracts.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmContractEdit>(contractId);
            }
        }

        private void sözleşmeyiAktiveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageHelper.SozlesmeAktiveEdilsinMi() == DialogResult.No)
            {
                return;
            }

            if (dgExpiredContracts.SelectedRows.Count > 0)
            {
                int contractId = int.Parse(dgExpiredContracts.SelectedRows[0].Cells[0].Value.ToString());

                Model.Contract contract = db.Contract.Where(q => q.ContractId == contractId).FirstOrDefault();
                contract.IsActive = true;

                int num = db.SaveChanges();

                if (num > 0)
                {
                    LoadExpiredContracts();

                    FrmContractList frmContractList = (FrmContractList)Application.OpenForms["FrmContractList"];
                    if (frmContractList != null)
                    {
                        frmContractList.LoadContracts();
                    }

                    FrmMain frmMain = (FrmMain)Application.OpenForms["FrmMain"];
                    if (frmMain != null)
                    {
                        frmMain.LoadUpcomings();
                    }

                    FrmUpcomingList frmUpcomingList = (FrmUpcomingList)Application.OpenForms["FrmUpcomingList"];
                    if (frmUpcomingList != null)
                    {
                        frmUpcomingList.LoadUpcomings();
                    }

                    MessageHelper.SozlesmeAktiveEdildi();
                }
                else
                {
                    MessageHelper.BeklenmedikHata();
                }

            }
            else
            {
                MessageHelper.GridSatirSecmediniz();
            }
        }
    }
}
