using Emlak.Helper;
using Emlak.UI.Upcoming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.UI.Contract
{
    public partial class FrmContractList : BaseForm
    {
        public FrmContractList()
        {
            InitializeComponent();
        }

        Model.EmlakEntities db = new Model.EmlakEntities();


        public void LoadContracts()
        {
            var contracts = db.sp_getContracts().OrderBy(q => q.FileNumber).ToList();

            dgContracts.DataSource = contracts;
            
            dgContracts.Columns[0].HeaderText = "ContractId";
            dgContracts.Columns[1].HeaderText = "Dosya No";
            dgContracts.Columns[2].HeaderText = "Taraf Bilgileri";
            dgContracts.Columns[3].HeaderText = "Kiraya Veren";
            dgContracts.Columns[4].HeaderText = "Kiraya Veren Telefon";
            dgContracts.Columns[5].HeaderText = "Sözleşme Tanımı";
            dgContracts.Columns[6].HeaderText = "Sözleşme Başlangıç Tarihi";
            dgContracts.Columns[7].HeaderText = "Sözleşme Bitiş Tarihi";
            dgContracts.Columns[8].HeaderText = "Aylık Kira";
            dgContracts.Columns[9].HeaderText = "Kira Müddeti";
            dgContracts.Columns[10].HeaderText = "Açıklama";


            dgContracts.Columns[0].Visible = false;

            lblTotalRecord.Text = "Bulunan kayıt sayısı: " + contracts.Count;
        }

        public void LoadFilter()
        {
            var contracts = db.sp_getContracts().AsQueryable();

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
                contracts = contracts.Where(q => q.RealtyDefinition.ToString().ToLower().Contains(txtRealtyDefinition.Text.ToLower()));
            }
            if (txtLandlord.Text.Trim().Length > 0)
            {
                contracts = contracts.Where(q => q.LandlordFullName.ToLower().StartsWith(txtLandlord.Text.ToLower(), StringComparison.OrdinalIgnoreCase));
            }
            if (txtPartyName.Text.Trim().Length > 0)
            {
                contracts = contracts.Where(q => q.Kiracilar != null && q.Kiracilar.ToLower().Contains(txtPartyName.Text.ToLower()));
            }

            var result = contracts.OrderBy(q => q.FileNumber).ToList();

            dgContracts.DataSource = result;

            dgContracts.Columns[0].HeaderText = "ContractId";
            dgContracts.Columns[1].HeaderText = "Dosya No";
            dgContracts.Columns[2].HeaderText = "Taraf Bilgileri";
            dgContracts.Columns[3].HeaderText = "Kiraya Veren";
            dgContracts.Columns[4].HeaderText = "Kiraya Veren Telefon";
            dgContracts.Columns[5].HeaderText = "Sözleşme Tanımı";
            dgContracts.Columns[6].HeaderText = "Sözleşme Başlangıç Tarihi";
            dgContracts.Columns[7].HeaderText = "Sözleşme Bitiş Tarihi";
            dgContracts.Columns[8].HeaderText = "Aylık Kira";
            dgContracts.Columns[9].HeaderText = "Kira Müddeti";
            dgContracts.Columns[10].HeaderText = "Açıklama";


            dgContracts.Columns[0].Visible = false;

            lblTotalRecord.Text = "Bulunan kayıt sayısı: " + result.Count;
        }

        private void FrmContractList_Load(object sender, EventArgs e)
        {
            dgContracts.DoubleBuffered(true);
            LoadContracts();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgContracts.SelectedRows.Count > 0)
            {
                int contractId = int.Parse(dgContracts.SelectedRows[0].Cells[0].Value.ToString());

                if (MessageHelper.KayitSil() == DialogResult.Yes)
                {
                    db.Contract.Remove(db.Contract.Where(q => q.ContractId == contractId).Single());
                    int num = db.SaveChanges();

                    if (num > 0)
                    {
                        LoadContracts();

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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadContracts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtEndingDate.Value = dtStartingDate.Value = DateTime.Today;
            dtEndingDate.Checked = dtStartingDate.Checked = false;
            txtLandlord.Text = txtPartyName.Text = "";
            dgContracts.DataSource = null;
            lblTotalRecord.Text = "...";
        }

        private void yeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmContractAdd>();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgContracts.SelectedRows.Count > 0)
            {
                int contractId = int.Parse(dgContracts.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmContractEdit>(contractId);
            }
            else
            {
                MessageHelper.GridSatirSecmediniz();
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgContracts, "Sözleşme Listesi.xlsx");
            excelHelper.ShowDialog();
        }

        private void dgContracts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgContracts.SelectedRows.Count > 0)
            {
                int contractId = int.Parse(dgContracts.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmContractEdit>(contractId);
            }
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
        
        private void dgContracts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DateTime today = DateTime.Now.AddMonths(1);

            for (int i = 0; i < dgContracts.Rows.Count; i++)
            {
                if (DateTime.Parse(dgContracts.Rows[i].Cells["EndingDate"].Value.ToString()) <= today)
                {
                    dgContracts.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dgContracts.Rows[i].DefaultCellStyle.BackColor = Color.White;

                }
            }
        }

        private void sözleşmeyiİptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageHelper.SozlesmeIptalEdilsinMi() == DialogResult.No)
            {
                return;
            }

            if (dgContracts.SelectedRows.Count > 0)
            {
                int contractId = int.Parse(dgContracts.SelectedRows[0].Cells[0].Value.ToString());

                Model.Contract contract = db.Contract.Where(q => q.ContractId == contractId).FirstOrDefault();
                contract.IsActive = false;


                var silinecekler = db.Debt.Where(q => q.ContractId == contract.ContractId && q.DueDate> DbFunctions.TruncateTime(DateTime.Now)).ToList();



                int num = db.SaveChanges();

                if (num > 0)
                {
                    LoadContracts();

                    FrmContractExpired frmContractExpired = (FrmContractExpired)Application.OpenForms["FrmContractExpired"];
                    if (frmContractExpired != null)
                    {
                        frmContractExpired.LoadExpiredContracts();
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

                    MessageHelper.SozlesmeIptalEdildi();
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
