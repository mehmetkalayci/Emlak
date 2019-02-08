using Emlak.Helper;
using Emlak.Properties;
using Emlak.UI.Upcoming;
using FluentValidation.Results;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Emlak.UI.Contract
{
    public partial class FrmContractAdd : BaseForm
    {
        public FrmContractAdd()
        {
            InitializeComponent();
        }

        #region Page Selection

        private void btnNext1_Click(object sender, EventArgs e)
        {
            tab.SelectTab(page2TarafBilgileri);
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            tab.SelectTab(page3Diger);
        }


        private void btnNext4_Click(object sender, EventArgs e)
        {
            tab.SelectTab(page5DigerBorclar);
        }

        #endregion

        Model.EmlakEntities db = new Model.EmlakEntities();

        private void FrmContract_Load(object sender, EventArgs e)
        {
            var realties = db.Realty.ToList();

            cmbRealty.DataSource = realties;
            cmbRealty.DisplayMember = "Definition";
            cmbRealty.ValueMember = "RealtyId";

            var cities = db.City.ToList();
            cmbCity.DataSource = cities;
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityId";

            var realtyType = db.RealtyType.ToList();
            cmbRealtyType.DataSource = realtyType;
            cmbRealtyType.DisplayMember = "RealtyTypeName";
            cmbRealtyType.ValueMember = "RealtyTypeId";

            cmbPaymentDay.SelectedIndex = 0;

            Model.Realty selectedRealty = (Model.Realty)cmbRealty.SelectedItem;

            if (selectedRealty != null)
            {
                txtNeighborhood.Text = selectedRealty.Neighborhood;
                txtStreet.Text = selectedRealty.Street;
                txtApartment.Text = selectedRealty.Apartment;

                cmbCity.Text = selectedRealty.City;
                cmbTown.Text = selectedRealty.Town;
                cmbRealtyType.Text = selectedRealty.RealtyType.RealtyTypeName;
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cityId = (cmbCity.SelectedItem as Model.City).CityId;

            var towns = db.Town.Where(q => q.CityId == cityId).ToList();

            cmbTown.DataSource = towns;
            cmbTown.DisplayMember = "TownName";
            cmbTown.ValueMember = "TownId";
        }

        private void cmbRealty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Realty selectedRealty = (Model.Realty)cmbRealty.SelectedItem;

            txtNeighborhood.Text = selectedRealty.Neighborhood;
            txtStreet.Text = selectedRealty.Street;
            txtApartment.Text = selectedRealty.Apartment;
            txtRealtyDefinition.Text = selectedRealty.Definition;


            cmbCity.Text = selectedRealty.City;
            cmbTown.Text = selectedRealty.Town;
            cmbRealtyType.Text = selectedRealty.RealtyType.RealtyTypeName;
        }

        #region Tarih Seçim ve Kira Ücret Güncelleme

        private void dtStartingDate_ValueChanged(object sender, EventArgs e)
        {
            int tenancyInMonth = DateHelper.GetMonthDifference(dtStartingDate.Value, dtEndingDate.Value);
            txtTenancy.Text = tenancyInMonth + " Ay";

            if (txtRentMoneyInMonth.Text.IsNotNull() && txtRentMoneyInMonth.Text.IsDecimal())
            {
                decimal rentMoneyTotal = decimal.Parse(txtRentMoneyInMonth.Text) * tenancyInMonth;
                txtRentMoneyTotal.Text = rentMoneyTotal.ToString("c");
            }
        }

        private void txtRentMoneyInMonth_TextChanged(object sender, EventArgs e)
        {
            if (txtRentMoneyInMonth.Text.IsNotNull() && txtRentMoneyInMonth.Text.IsDecimal())
            {
                int tenancyInMonth = DateHelper.GetMonthDifference(dtStartingDate.Value, dtEndingDate.Value);
                decimal rentMoneyTotal = decimal.Parse(txtRentMoneyInMonth.Text) * tenancyInMonth;
                txtRentMoneyTotal.Text = rentMoneyTotal.ToString("c");
                txtTenancy.Text = tenancyInMonth + " Ay";
            }
        }


        #endregion


        #region Taraf Ekle








        private void delSelectedPerson_Click(object sender, EventArgs e)
        {
            if (dgParties.SelectedRows.Count > 0)
            {
                dgParties.Rows.Remove(dgParties.SelectedRows[0]);
            }
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Contract contract = new Model.Contract();

            ContractValidator validator = new ContractValidator();

            contract.FileNumber = int.Parse(txtFileNumber.Text);
            contract.StartingDate = dtStartingDate.Value;
            contract.EndingDate = dtEndingDate.Value;
            contract.Tenancy = txtTenancy.Text;
            contract.Neighborhood = txtNeighborhood.Text;
            contract.Street = txtStreet.Text;
            contract.Apartment = txtApartment.Text;
            contract.City = cmbCity.Text;
            contract.Town = cmbTown.Text;
            contract.RealtyDefinition = txtRealtyDefinition.Text;
            contract.RealtyType = cmbRealtyType.Text;
            contract.RentMoneyInMonth = String.Format("{0:c}", txtRentMoneyInMonth.Text);
            contract.RentMoneyTotal = String.Format("{0:c}", txtRentMoneyTotal.Text);
            contract.PaymentType = txtPaymentType.Text;
            contract.PaymentDay = cmbPaymentDay.Text;

            contract.CurrentSituationOfRealEstate = txtRealEstateSituation.Text;
            contract.AimOfRent = txtAimOfRent.Text;
            contract.InventoryList = txtInventories.Text;

            contract.LandlordCitizenshipId = txtLanlordCitizenshipId.Text;
            contract.LandlordFullName = txtLanlordFullName.Text;
            contract.LandlordPhone = txtLanlordPhone.Text;
            contract.LandlordAddress = txtlandlordAddress.Text;
            contract.LandlordBankAccountName = txtLanlordBankAccountName.Text;
            contract.LandlordBankAccountNumber = txtLanlordBankAccountNo.Text;
            contract.LandlordIBAN = txtLanlordIBAN.Text;

            contract.ContractSpecialConditions = txtSpecialConditions.Text;
            contract.Explanation = txtExplanation.Text;
            contract.IsActive = true;

            // Tarafları Ekle
            for (int i = 0; i < dgParties.Rows.Count; i++)
            {
                int personId = int.Parse(dgParties.Rows[i].Cells[0].Value.ToString());
                string personType = dgParties.Rows[i].Cells[2].Value.ToString();

                contract.ContractParties.Add(new Model.ContractParties()
                {
                    PersonId = personId,
                    PersonType = personType
                });
            }

            // Kiraları Ekle
            for (int i = 0; i < dgRentals.Rows.Count; i++)
            {
                string definition = dgRentals.Rows[i].Cells[0].Value.ToString();
                decimal amount = dgRentals.Rows[i].Cells[1].Value.ToString().IsDecimal() ? decimal.Parse(dgRentals.Rows[i].Cells[1].Value.ToString()) : 0;
                DateTime duedate = DateTime.Parse(dgRentals.Rows[i].Cells[2].Value.ToString());

                contract.Debt.Add(new Model.Debt
                {
                    ContractId = contract.ContractId,
                    Definition = definition,
                    Amount = amount,
                    DueDate = duedate,
                    IsCommission = false
                });
            }

            // Borçları Ekle
            for (int i = 0; i < dgDebts.Rows.Count; i++)
            {
                string definition = dgDebts.Rows[i].Cells[0].Value.ToString();
                decimal amount = dgDebts.Rows[i].Cells[1].Value.ToString().IsDecimal() ? decimal.Parse(dgDebts.Rows[i].Cells[1].Value.ToString()) : 0;
                DateTime duedate = DateTime.Parse(dgDebts.Rows[i].Cells[2].Value.ToString());

                contract.Debt.Add(new Model.Debt
                {
                    ContractId = contract.ContractId,
                    Definition = definition,
                    Amount = amount,
                    DueDate = duedate,
                    IsCommission = true
                });
            }



            ValidationResult results = validator.Validate(contract);

            IList<ValidationFailure> failures = results.Errors;


            if (!results.IsValid)
            {
                foreach (var item in failures)
                {
                    MessageBox.Show(item.ErrorMessage);
                    break;
                }
                return;
            }


            // Sözleşmeyi Kaydet
            db.Contract.Add(contract);
            int num = db.SaveChanges();
            if (num > 0)
            {
                FrmContractList frmContractList = (FrmContractList)Application.OpenForms["FrmContractList"];
                if (frmContractList != null)
                {
                    frmContractList.LoadContracts();
                }
                FrmUpcomingList frmUpcomingRentals = (FrmUpcomingList)Application.OpenForms["FrmUpcomingRentals"];
                if (frmUpcomingRentals != null)
                {
                    frmUpcomingRentals.LoadUpcomings();
                }
                FrmMain frmMain = (FrmMain)Application.OpenForms["FrmMain"];
                if (frmMain != null)
                {
                    frmMain.LoadUpcomings();
                }
                MessageHelper.SozlesmeKaydedildi();


                if (MessageBox.Show("Sözleşme dosyası oluşturulsun mu?", System.Windows.Forms.Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    FrmContractWriter frmContractWriter = new FrmContractWriter(contract.ContractId);
                    frmContractWriter.ShowDialog();
                }
            }
            else
            {
                MessageHelper.BeklenmedikHata();
            }
        }


        public void LoadRentals(int contractId)
        {
            Model.Contract selectedContract = db.Contract.Where(q => q.ContractId == contractId).FirstOrDefault();

            var selected = db.Debt.Where(q => q.ContractId == selectedContract.ContractId && q.IsCommission == false).Select(q => new
            {
                q.DebtId,
                q.Definition,
                q.Amount,
                q.DueDate,
                q.PaymentDate,
                q.IsPaidByTenant,
                q.IsPaidToLandlord,
                q.PaymentType,
                q.Explanation
            }).ToList();


            dgRentals.DataSource = selected;


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
        }

        #region Kira Ekle

        private void btnNext3_Click(object sender, EventArgs e)
        {
            if (dgRentals.Rows.Count <= 0)
            {
                DateTime dueDate = new DateTime(dtStartingDate.Value.Year, dtStartingDate.Value.Month, int.Parse(cmbPaymentDay.Text));
                int tenancyInMonth = DateHelper.GetMonthDifference(dtStartingDate.Value, dtEndingDate.Value);
                decimal rentMoneyInMonth = txtRentMoneyInMonth.Text.IsDecimal() ? decimal.Parse(txtRentMoneyInMonth.Text) : 0;

                if (dtStartingDate.Value.Day > int.Parse(cmbPaymentDay.Text))
                {
                    dueDate = dueDate.AddMonths(1);
                }

                for (int i = 1; i <= tenancyInMonth; i++)
                {
                    dgRentals.Rows.Add("Kira " + i, rentMoneyInMonth, dueDate.ToShortDateString());
                    dueDate = dueDate.AddMonths(1);
                }
            }
            tab.SelectTab(page4Kiralar);
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            FrmDebtAdd frmDebtAdd = new FrmDebtAdd();
            frmDebtAdd.ShowDialog();

            if (frmDebtAdd.Definition.IsNotNull() && frmDebtAdd.Amount.IsNotNull())
            {
                dgRentals.Rows.Add(frmDebtAdd.Definition, frmDebtAdd.Amount, frmDebtAdd.DueDate.ToShortDateString());
            }
        }

        private void btnDelSelectedRental_Click(object sender, EventArgs e)
        {
            if (MessageHelper.SecilenSatirlariSil() == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dgRentals.SelectedRows)
                {
                    dgRentals.Rows.RemoveAt(item.Index);
                }
            }
        }

        #endregion

        #region Borç Ekle

        private void btnAddDebt_Click(object sender, EventArgs e)
        {
            FrmDebtAdd frmDebtAdd = new FrmDebtAdd();
            frmDebtAdd.ShowDialog();

            if (frmDebtAdd.Definition.IsNotNull() && frmDebtAdd.Amount.IsNotNull())
            {
                dgDebts.Rows.Add(frmDebtAdd.Definition, frmDebtAdd.Amount, frmDebtAdd.DueDate.ToShortDateString());
            }

        }

        private void btnDelSelectedDebt_Click(object sender, EventArgs e)
        {
            if (MessageHelper.SecilenSatirlariSil() == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dgDebts.SelectedRows)
                {
                    dgDebts.Rows.RemoveAt(item.Index);
                }
            }
        }

        #endregion

        private void FindAndReplace(Microsoft.Office.Interop.Word.Application WordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object nmatchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = WdFindWrap.wdFindContinue;
            object replaceAll = WdReplace.wdReplaceAll;
            WordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord, ref matchWildCards, ref matchSoundsLike,
            ref nmatchAllWordForms, ref forward,
            ref wrap, ref format, ref replaceWithText,
            ref replaceAll, ref matchKashida,
            ref matchDiacritics, ref matchAlefHamza,
            ref matchControl);
        }

        private void btnAddContractParty_Click(object sender, EventArgs e)
        {
            FrmContractPartyAdd frmContractParty = new FrmContractPartyAdd();
            frmContractParty.ShowDialog();


            int personId = frmContractParty.PersonId;
            string personFullInfo = frmContractParty.PersonFullName;
            string personType = frmContractParty.PersonType;


            for (int i = 0; i < dgParties.Rows.Count; i++)
            {
                int tempPersonId = int.Parse(dgParties.Rows[i].Cells[0].Value.ToString());
                if (personId == tempPersonId)
                {
                    MessageHelper.TarafZatenEkli();
                    return;
                }
            }

            if (personId != -1 && personFullInfo.IsNotNull() && personType.IsNotNull())
            {
                dgParties.Rows.Add(personId, personFullInfo, personType);
            }
        }
    }
}