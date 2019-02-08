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

namespace Emlak.UI.Person
{
    public partial class FrmPersonDetail : BaseForm
    {
        public FrmPersonDetail(int personId)
        {
            InitializeComponent();

            this.PersonId = personId;
        }

        public int PersonId { get; set; }

        private Model.EmlakEntities db = new Model.EmlakEntities();


        public void LoadTenantInformation()
        {
            Model.Person person = db.Person.Where(q => q.PersonId == this.PersonId).FirstOrDefault();

            txtTenantCitizenshipId.Text = person.CitizenshipId;
            txtTenantFullName.Text = person.FullName;
            txtTenantExplanation.Text = person.Explanation;
            txtTenantPhone1.Text = person.Phone1;
            txtTenantPhone2.Text = person.Phone2;

            this.Text += " - " + person.FullName;
        }

        public void LoadContractInformation()
        {
            int contractId = db.ContractParties.Where(q => q.PersonId == this.PersonId && q.PersonType == "Kiracı").FirstOrDefault().ContractId;

            var contractInfo = db.Contract.Where(q => q.ContractId == contractId).FirstOrDefault();

            if (contractInfo != null)
            {
                txtContractDefinition.Text = contractInfo.Apartment;
                txtNeighborhood.Text = contractInfo.Neighborhood;
                txtStreet.Text = contractInfo.Street;
                txtApartment.Text = contractInfo.Apartment;
                txtCityTown.Text = contractInfo.City + " / " + contractInfo.Town;
                txtRealEstateType.Text = contractInfo.RealtyType;
                txtAimOfRent.Text = contractInfo.AimOfRent;
                txtContractStartingDate.Text = contractInfo.StartingDate.ToString();
                txtContractEndingDate.Text = contractInfo.EndingDate.ToString();
                txtTenancy.Text = contractInfo.Tenancy;
                txtRentMoneyInMonth.Text = string.Format("{0:c}", contractInfo.RentMoneyInMonth); 
                txtRentMoneyTotal.Text = string.Format("{0:c}", contractInfo.RentMoneyTotal);
                txtPaymentType.Text = contractInfo.PaymentType;
                txtPaymentDay.Text = contractInfo.PaymentDay;

                txtLandlordCitizenshipId.Text = contractInfo.LandlordCitizenshipId;
                txtLandlordFullName.Text = contractInfo.LandlordFullName;
                txtLandlordPhone.Text = contractInfo.LandlordPhone;
                txtLandlordAddress.Text = contractInfo.LandlordAddress;
                txtLandlordBankAccountName.Text = contractInfo.LandlordBankAccountName;
                txtLandlordAccountNo.Text = contractInfo.LandlordBankAccountNumber;
                txtLandlordIBAN.Text = contractInfo.LandlordIBAN;
            }
        }
        
        public void LoadRentalInformation()
        {
            var contracts = db.ContractParties.Where(w => w.PersonId == this.PersonId && w.PersonType == "Kiracı").Select(q=>q.ContractId).ToList();

            var debts = (from d in db.Debt
                         where contracts.Contains(d.ContractId) && d.IsCommission == false
                         select new
                         {
                             d.DebtId,
                             d.Definition,
                             d.Amount,
                             d.DueDate,
                             d.PaymentDate,
                             d.IsPaidByTenant,
                             d.IsPaidToLandlord,
                             d.PaymentType,
                             d.Explanation
                         }).ToList();

            dgRentals.DataSource = debts;


            // datagrid başlıklarını ayarla
            dgRentals.Columns[0].HeaderText = "Taksit Id";
            dgRentals.Columns[1].HeaderText = "Tanım";
            dgRentals.Columns[2].HeaderText = "Ücret";
            dgRentals.Columns[3].HeaderText = "Ödeme Bitiş Tarihi";
            dgRentals.Columns[4].HeaderText = "Ödeme Tarihi";
            dgRentals.Columns[5].HeaderText = "Kiracı Ödedi Mi?";
            dgRentals.Columns[6].HeaderText = "Ev Sahibine Ödendi Mi?";
            dgRentals.Columns[7].HeaderText = "Ödeme Tipi";
            dgRentals.Columns[8].HeaderText = "Açıklama";

            dgRentals.Columns[0].Visible = false;

            lblRentalsTotalRecord.Text = "Kayıt sayısı: " + debts.Count;
        }

        public void LoadDebtInformation()
        {
            var contracts = db.ContractParties.Where(w => w.PersonId == this.PersonId && w.PersonType == "Kiracı").Select(q => q.ContractId).ToList();

            var debts = (from d in db.Debt
                         where contracts.Contains(d.ContractId) && d.IsCommission == true
                         select new {
                             d.DebtId,
                             d.Definition,
                             d.Amount,
                             d.DueDate,
                             d.PaymentDate,
                             d.IsPaidByTenant,
                             d.PaymentType,
                             d.Explanation
                         }).ToList();

            dgDebts.DataSource = debts;
            

            // datagrid başlıklarını ayarla
            dgDebts.Columns[0].HeaderText = "Debt Id";
            dgDebts.Columns[1].HeaderText = "Tanım";
            dgDebts.Columns[2].HeaderText = "Ücret";
            dgDebts.Columns[3].HeaderText = "Ödeme Bitiş Tarihi";
            dgDebts.Columns[4].HeaderText = "Ödeme Tarihi";
            dgDebts.Columns[5].HeaderText = "Kiracı Ödedi Mi?";
            dgDebts.Columns[6].HeaderText = "Ödeme Tipi";
            dgDebts.Columns[7].HeaderText = "Açıklama";

            dgDebts.Columns[0].Visible = false;

            lblDebtsTotalRecord.Text = "Kayıt sayısı: " + debts.Count;
        }

        private void FrmPersonDetail_Load(object sender, EventArgs e)
        {
            if (this.PersonId == -1)
            {
                return;
            }
            try
            {

                LoadTenantInformation();
                LoadContractInformation();
                LoadRentalInformation();
                LoadDebtInformation();
            }
            catch 
            {
            }
        }

        private void dgRentals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgRentals.Rows.Count; i++)
            {

                if (bool.Parse(dgRentals.Rows[i].Cells["IsPaidByTenant"].Value.ToString()) && bool.Parse(dgRentals.Rows[i].Cells["IsPaidToLandlord"].Value.ToString()))
                {
                    // tamamen ödendiyse yeşil
                    dgRentals.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(139, 195, 74);
                }
                else if (bool.Parse(dgRentals.Rows[i].Cells["IsPaidByTenant"].Value.ToString()) == true && bool.Parse(dgRentals.Rows[i].Cells["IsPaidToLandlord"].Value.ToString()) == false)
                {
                    // IsPaidByTenant ise turuncu olacak
                    dgRentals.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 7);
                }
                else if (bool.Parse(dgRentals.Rows[i].Cells["IsPaidByTenant"].Value.ToString()) == false && bool.Parse(dgRentals.Rows[i].Cells["IsPaidToLandlord"].Value.ToString()) == false )
                {
                    // hiç ödenmemiş ve ödeme günü geçmiş ise kırmızı
                    dgRentals.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(244, 67, 54);
                }

            }
        }

        private void dgDebts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgDebts.Rows.Count; i++)
            {

                if (bool.Parse(dgDebts.Rows[i].Cells["IsPaidByTenant"].Value.ToString()))
                {
                    // tamamen ödendiyse yeşil
                    dgDebts.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(139, 195, 74);
                }
                else
                {
                    // IsPaidByTenant ise turuncu olacak
                    dgDebts.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(244, 67, 54);
                }

            }
        }

        private void dgRentals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRentals.SelectedRows.Count > 0)
            {
                int debtId = int.Parse(dgRentals.SelectedRows[0].Cells[0].Value.ToString());
                
                FormHelper.ShowDialog<FrmRentalAdd>(debtId);
            }
        }

        private void dgDebts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDebts.SelectedRows.Count > 0)
            {
                int debtId = int.Parse(dgDebts.SelectedRows[0].Cells[0].Value.ToString());

                FormHelper.ShowDialog<FrmRentalAdd>(debtId);
            }
        }
    }
}
