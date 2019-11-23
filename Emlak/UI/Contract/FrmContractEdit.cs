using Emlak.Helper;
using Emlak.Properties;
using Emlak.UI.CashBook;
using Emlak.UI.Rental;
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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Emlak.UI.Contract
{
    public partial class FrmContractEdit : BaseForm
    {
        public FrmContractEdit(int contractId = -1)
        {
            InitializeComponent();
            this.ContractId = contractId;
        }

        public int ContractId { get; set; }

        Model.EmlakEntities db = new Model.EmlakEntities();


        #region Load Contract Information

        private void LoadContractParties()
        {
            Model.Contract selectedContract = db.Contract.Where(q => q.ContractId == this.ContractId).FirstOrDefault();

            var selected = db.ContractParties.Where(q => q.ContractId == selectedContract.ContractId).Select(q => new
            {
                q.PersonId,
                q.ContractId,
                q.PersonType,
                q.Person.CitizenshipId,
                q.Person.FullName
            }).ToList();

            dgParties.DataSource = selected;

            // datagrid başlıklarını ayarla
            dgParties.Columns[0].HeaderText = "Person Id";
            dgParties.Columns[1].HeaderText = "Contract Id";
            dgParties.Columns[2].HeaderText = "Taraf Tipi";
            dgParties.Columns[3].HeaderText = "TC Kimlik No";
            dgParties.Columns[4].HeaderText = "Ad Soyad";


            dgParties.Columns[0].Visible = false;
            dgParties.Columns[1].Visible = false;
        }

        public void LoadRentals()
        {
            Model.Contract selectedContract = db.Contract.Where(q => q.ContractId == this.ContractId).FirstOrDefault();

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

        public void LoadDebts()
        {
            Model.Contract selectedContract = db.Contract.Where(q => q.ContractId == this.ContractId).FirstOrDefault();

            var selected = db.Debt.Where(q => q.ContractId == selectedContract.ContractId && q.IsCommission == true).Select(q => new
            {
                q.DebtId,
                q.Definition,
                q.Amount,
                q.DueDate,
                q.PaymentDate,
                q.IsPaidByTenant,
                q.PaymentType,
                q.Explanation
            }).ToList();


            dgDebts.DataSource = selected;


            // datagrid başlıklarını ayarla
            dgDebts.Columns[0].HeaderText = "Taksit Id";
            dgDebts.Columns[1].HeaderText = "Tanım";
            dgDebts.Columns[2].HeaderText = "Ücret";
            dgDebts.Columns[3].HeaderText = "Ödeme Bitiş Tarihi";
            dgDebts.Columns[4].HeaderText = "Ödeme Tarihi";
            dgDebts.Columns[5].HeaderText = "Kiracı Ödedi Mi?";
            dgDebts.Columns[6].HeaderText = "Ödeme Tipi";
            dgDebts.Columns[7].HeaderText = "Açıklama";

            dgDebts.Columns[0].Visible = false;
        }

        private void FrmContractEdit_Load(object sender, EventArgs e)
        {
            if (this.ContractId == -1)
            {
                return;
            }

            cmbPaymentDay.SelectedIndex = 0;

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



            Model.Contract selectedContract = db.Contract.Where(q => q.ContractId == this.ContractId).FirstOrDefault();

            txtFileNumber.Text = selectedContract.FileNumber.ToString();
            dtStartingDate.Value = selectedContract.StartingDate;
            dtEndingDate.Value = selectedContract.EndingDate;
            txtTenancy.Text = selectedContract.Tenancy;
            txtNeighborhood.Text = selectedContract.Neighborhood;
            txtStreet.Text = selectedContract.Street;
            txtApartment.Text = selectedContract.Apartment;
            cmbCity.Text = selectedContract.City;
            cmbTown.Text = selectedContract.Town;
            txtRealtyDefinition.Text = selectedContract.RealtyDefinition;
            cmbRealtyType.SelectedItem = selectedContract.RealtyType;
            txtRentMoneyInMonth.Text = selectedContract.RentMoneyInMonth;
            txtRentMoneyTotal.Text = selectedContract.RentMoneyTotal;
            txtPaymentType.Text = selectedContract.PaymentType;
            cmbPaymentDay.SelectedItem = selectedContract.PaymentDay;

            txtRealEstateSituation.Text = selectedContract.CurrentSituationOfRealEstate;
            txtAimOfRent.Text = selectedContract.AimOfRent;
            txtInventories.Text = selectedContract.InventoryList;


            txtLanlordCitizenshipId.Text = selectedContract.LandlordCitizenshipId;
            txtLanlordFullName.Text = selectedContract.LandlordFullName;
            txtLanlordPhone.Text = selectedContract.LandlordPhone;
            txtlandlordAddress.Text = selectedContract.LandlordAddress;
            txtLanlordBankAccountName.Text = selectedContract.LandlordBankAccountName;
            txtLanlordBankAccountNo.Text = selectedContract.LandlordBankAccountNumber;
            txtLanlordIBAN.Text = selectedContract.LandlordIBAN;

            txtSpecialConditions.Text = selectedContract.ContractSpecialConditions;
            txtExplanation.Text = selectedContract.Explanation;

            //if (selectedContract.EndingDate <= DateTime.Now.AddMonths(1) || selectedContract.CancellationDate <= DateTime.Now)
            if (selectedContract.EndingDate != selectedContract.CancellationDate && selectedContract.CancellationDate <= DateTime.Now)
            {
                lblReason.Text =  selectedContract.CancellationDate.ToShortDateString() + " tarihinde iptal edildi!";
            }
            else if (selectedContract.EndingDate <= DateTime.Now.AddMonths(1))
            {
                lblReason.Text =  selectedContract.CancellationDate.ToShortDateString() + " tarihinde bitti!";
            }

            LoadContractParties();
            LoadRentals();
            LoadDebts();
        }

        #endregion

        #region Add & Delete Contract Party

        private void btnDeleteParty_Click(object sender, EventArgs e)
        {
            if (dgParties.SelectedRows.Count > 0)
            {
                int personId = int.Parse(dgParties.SelectedRows[0].Cells[0].Value.ToString());
                int contractId = int.Parse(dgParties.SelectedRows[0].Cells[1].Value.ToString());

                if (MessageHelper.KayitSil() == DialogResult.Yes)
                {
                    db.ContractParties.Remove(db.ContractParties.Where(q => q.PersonId == personId && q.ContractId == contractId).FirstOrDefault());
                    int num = db.SaveChanges();

                    if (num > 0)
                    {
                        FrmContractList frmContractList = (FrmContractList)Application.OpenForms["FrmContractList"];
                        if (frmContractList != null)
                        {
                            frmContractList.LoadContracts();
                        }
                        LoadContractParties();
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
                MessageHelper.GridSatirSecmediniz();
            }
        }

        private void btnAddContractParty_Click(object sender, EventArgs e)
        {

            FrmContractPartyAdd frmContractParty = new FrmContractPartyAdd();
            frmContractParty.ShowDialog();

            int personId = frmContractParty.PersonId;
            string personType = frmContractParty.PersonType;

            if (personId == -1 || personType == null)
            {
                return;
            }

            for (int i = 0; i < dgParties.Rows.Count; i++)
            {
                int tempPersonId = int.Parse(dgParties.Rows[i].Cells[0].Value.ToString());
                if (tempPersonId == personId)
                {
                    MessageHelper.TarafZatenEkli();
                    return;
                }
            }


            db.ContractParties.Add(new Model.ContractParties()
            {
                ContractId = this.ContractId,
                PersonId = personId,
                PersonType = personType
            });

            int result = db.SaveChanges();
            if (result > 0)
            {
                FrmContractList frmContractList = (FrmContractList)Application.OpenForms["FrmContractList"];
                if (frmContractList != null)
                {
                    frmContractList.LoadContracts();
                }

                LoadContractParties();
                MessageHelper.KayitGuncellendi();
            }
            else
            {
                MessageHelper.BeklenmedikHata();
            }

        }

        #endregion

        #region Add Delete Update Rental

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            FrmDebtAdd frmDebtAdd = new FrmDebtAdd();
            frmDebtAdd.ShowDialog();

            string definition = frmDebtAdd.Definition;
            decimal amount = frmDebtAdd.Amount.IsDecimal() ? decimal.Parse(frmDebtAdd.Amount) : 0;
            DateTime dueDate = frmDebtAdd.DueDate;

            if (definition.IsNotNull())
            {
                Model.Contract selectedContract = db.Contract.Where(q => q.ContractId == this.ContractId).FirstOrDefault();


                selectedContract.Debt.Add(new Model.Debt
                {
                    ContractId = this.ContractId,
                    Definition = definition,
                    Amount = amount,
                    DueDate = dueDate,
                    IsCommission = false
                });



                int result = db.SaveChanges();
                if (result > 0)
                {
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
                    LoadRentals();
                    MessageHelper.KayitGuncellendi();
                }
                else
                {
                    MessageHelper.BeklenmedikHata();
                }
            }

        }

        private void btnDelSelectedRental_Click(object sender, EventArgs e)
        {
            if (dgRentals.SelectedRows.Count > 0)
            {
                int debtId = int.Parse(dgRentals.SelectedRows[0].Cells[0].Value.ToString());

                if (MessageHelper.KayitSil() == DialogResult.Yes)
                {
                    db.Debt.Remove(db.Debt.Where(q => q.DebtId == debtId).FirstOrDefault());
                    int num = db.SaveChanges();

                    if (num > 0)
                    {
                        FrmMain frmMain = (FrmMain)Application.OpenForms["FrmMain"];
                        if (frmMain != null)
                        {
                            frmMain.LoadUpcomings();
                        }
                        LoadRentals();
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
                MessageHelper.GridSatirSecmediniz();
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

        #endregion

        #region Add Delete Update Debt

        private void btnAddDebt_Click(object sender, EventArgs e)
        {
            FrmDebtAdd frmDebtAdd = new FrmDebtAdd();
            frmDebtAdd.ShowDialog();

            string definition = frmDebtAdd.Definition;
            decimal amount = frmDebtAdd.Amount.IsDecimal() ? decimal.Parse(frmDebtAdd.Amount) : 0;
            DateTime dueDate = frmDebtAdd.DueDate;

            if (definition.IsNotNull())
            {
                Model.Contract selectedContract = db.Contract.Where(q => q.ContractId == this.ContractId).FirstOrDefault();

                selectedContract.Debt.Add(new Model.Debt
                {
                    ContractId = this.ContractId,
                    Definition = definition,
                    Amount = amount,
                    DueDate = dueDate,
                    IsCommission = true
                });



                int result = db.SaveChanges();
                if (result > 0)
                {
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

                    FrmCashBookList frmCashBookList = (FrmCashBookList)Application.OpenForms["FrmCashBookList"];
                    if (frmCashBookList != null)
                    {
                        frmCashBookList.LoadLastDays();
                    }
                    LoadDebts();
                    MessageHelper.KayitGuncellendi();
                }
                else
                {
                    MessageHelper.BeklenmedikHata();
                }
            }
        }

        private void btnDelSelectedDebt_Click(object sender, EventArgs e)
        {
            if (dgDebts.SelectedRows.Count > 0)
            {
                int debtId = int.Parse(dgDebts.SelectedRows[0].Cells[0].Value.ToString());

                if (MessageHelper.KayitSil() == DialogResult.Yes)
                {
                    db.Debt.Remove(db.Debt.Where(q => q.DebtId == debtId).FirstOrDefault());
                    int num = db.SaveChanges();

                    if (num > 0)
                    {
                        FrmMain frmMain = (FrmMain)Application.OpenForms["FrmMain"];
                        if (frmMain != null)
                        {
                            frmMain.LoadUpcomings();
                        }
                        FrmCashBookList frmCashBookList = (FrmCashBookList)Application.OpenForms["FrmCashBookList"];
                        if (frmCashBookList != null)
                        {
                            frmCashBookList.LoadLastDays();
                        }
                        LoadDebts();
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
                MessageHelper.GridSatirSecmediniz();
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

        #endregion



        private void btnSave_Click(object sender, EventArgs e)
        {
            // Contract varsa güncelleme yapılacak
            Model.Contract contract = db.Contract.Where(q => q.ContractId == this.ContractId).Single();

            if (contract == null)
            {
                MessageHelper.KayitBulunamadi();
                return;
            }


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
            contract.PaymentDay = cmbPaymentDay.SelectedItem.ToString();

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

            if (db.Entry(contract).State == System.Data.Entity.EntityState.Unchanged)
            {
                return;
            }

            // Sözleşmeyi Kaydet
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
                MessageHelper.SozlesmeGuncellendi();
            }
            else
            {
                MessageHelper.BeklenmedikHata();
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
                else if (bool.Parse(dgRentals.Rows[i].Cells["IsPaidByTenant"].Value.ToString()) == false && bool.Parse(dgRentals.Rows[i].Cells["IsPaidToLandlord"].Value.ToString()) == false)
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
                else if (bool.Parse(dgDebts.Rows[i].Cells["IsPaidByTenant"].Value.ToString()) == false)
                {
                    // hiç ödenmemiş ve ödeme günü geçmiş ise kırmızı
                    dgDebts.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(244, 67, 54);
                }
            }
        }



        private void btnNext1_Click(object sender, EventArgs e)
        {
            tab.SelectTab(page2TarafBilgileri);
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            tab.SelectTab(page3Diger);
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            tab.SelectTab(page4Kiralar);
        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
            tab.SelectTab(page5DigerBorclar);
        }

        private void cmbCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int cityId = (cmbCity.SelectedItem as Model.City).CityId;

            var towns = db.Town.Where(q => q.CityId == cityId).ToList();

            cmbTown.DataSource = towns;
            cmbTown.DisplayMember = "TownName";
            cmbTown.ValueMember = "TownId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Contract contract = db.Contract.Where(q => q.ContractId == this.ContractId).Single();

            if (MessageBox.Show("Sözleşme dosyası oluşturulsun mu?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                FrmContractWriter frmContractWriter = new FrmContractWriter(contract.ContractId);
                frmContractWriter.ShowDialog();
            }
        }

        private void ReplaceBookmarkText(Microsoft.Office.Interop.Word.Document doc, string bookmarkName, string text)
        {
            if (doc.Bookmarks.Exists(bookmarkName))
            {
                Object name = bookmarkName;
                Microsoft.Office.Interop.Word.Range range = doc.Bookmarks.get_Item(ref name).Range;

                range.Text = text;
                object newRange = range;
                doc.Bookmarks.Add(bookmarkName, ref newRange);
            }
        }

        private void cmbRealty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Realty selectedRealty = (Model.Realty)cmbRealty.SelectedItem;

            txtNeighborhood.Text = selectedRealty.Neighborhood;
            txtStreet.Text = selectedRealty.Street;
            txtApartment.Text = selectedRealty.Apartment;

            cmbCity.Text = selectedRealty.City;
            cmbTown.Text = selectedRealty.Town;
            cmbRealtyType.Text = selectedRealty.RealtyType.RealtyTypeName;
        }

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

    }
}
