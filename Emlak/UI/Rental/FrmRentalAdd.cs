using Emlak.Helper;
using Emlak.Model;
using Emlak.UI.CashBook;
using Emlak.UI.Contract;
using Emlak.UI.Invoice;
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

namespace Emlak.UI.Rental
{
    public partial class FrmRentalAdd : BaseForm
    {
        public FrmRentalAdd(int debtId = -1)
        {
            InitializeComponent();
            this.DebtId = debtId;
        }

        public int DebtId { get; set; }

        private Model.EmlakEntities db = new Model.EmlakEntities();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRentalAdd_Load(object sender, EventArgs e)
        {
            cmbPaymentType.SelectedIndex = 0;

            if (this.DebtId != -1)
            {
                var rental = db.Debt.Where(q => q.DebtId == this.DebtId).FirstOrDefault();
                var rentalDetail = db.sp_getDebtDetails(this.DebtId).FirstOrDefault();

                txtTenantFullname.Text = rentalDetail.Kiracilar;
                txtRealtyDefinition.Text = rentalDetail.RealtyDefinition;
                txtDebtDefinition.Text = rentalDetail.Definition;
                txtLandlordFullname.Text = rentalDetail.LandlordFullName;

                txtDebtDefinition.Text = rental.Definition;
                txtAmount.Text = rental.Amount.ToString();
                dtDueDate.Value = rental.DueDate;
                dtPaymentDate.Checked = rental.IsPaidByTenant;
                if (rental.PaymentDate.IsNotNull())
                {
                    dtPaymentDate.Value = DateTime.Parse(rental.PaymentDate);
                }
                cmbPaymentType.Text = rental.PaymentType;
                txtExplanation.Text = rental.Explanation;
                dtPaymentDate.Checked = rental.IsPaidByTenant;
                dtPaymentDateToLandlord.Checked = rental.IsPaidToLandlord;
                if (rental.IsCommission)
                {
                    label7.Enabled = false;
                    dtPaymentDateToLandlord.Enabled = false;
                }


                if (rental.PaymentDateToLandlord.IsNotNull())
                {
                    dtPaymentDateToLandlord.Value = DateTime.Parse(rental.PaymentDateToLandlord);
                }
                else
                {
                    dtPaymentDateToLandlord.Checked = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Debt rental = db.Debt.Where(q => q.DebtId == this.DebtId).FirstOrDefault();

                rental.Definition = txtDebtDefinition.Text;
                rental.Amount = txtAmount.Text.IsDecimal() ? decimal.Parse(txtAmount.Text) : 0;
                rental.DueDate = dtDueDate.Value;

                if (dtPaymentDate.Checked)
                {
                    rental.PaymentDate = dtPaymentDate.Value.ToShortDateString();
                }
                else
                {
                    rental.PaymentDate = "";
                }

                if (dtPaymentDateToLandlord.Checked)
                {
                    rental.PaymentDateToLandlord = dtPaymentDateToLandlord.Value.ToShortDateString();
                }
                else
                {
                    rental.PaymentDateToLandlord = "";
                }


                if (cmbPaymentType.SelectedItem != null)
                {
                    rental.PaymentType = cmbPaymentType.SelectedItem.ToString();
                }

                rental.Explanation = txtExplanation.Text;
                rental.IsPaidByTenant = dtPaymentDate.Checked;
                rental.IsPaidToLandlord = dtPaymentDateToLandlord.Checked;

                if (db.Entry(rental).State == System.Data.Entity.EntityState.Unchanged)
                {
                    return;
                }

                // Borcu Kaydet
                int num = db.SaveChanges();
                if (num > 0)
                {
                    FrmUpcomingList frmUpcoming = (FrmUpcomingList)Application.OpenForms["FrmUpcomingList"];
                    if (frmUpcoming != null)
                    {
                        frmUpcoming.LoadUpcomings();
                    }
                    FrmMonthlyReportList frmMonthlyReportList = (FrmMonthlyReportList)Application.OpenForms["FrmMonthlyReportList"];
                    if (frmMonthlyReportList != null)
                    {
                        frmMonthlyReportList.LoadMonthlyReport();
                    }
                    FrmYearlyReportList frmYearlyReportList = (FrmYearlyReportList)Application.OpenForms["FrmYearlyReportList"];
                    if (frmYearlyReportList != null)
                    {
                        frmYearlyReportList.LoadYearlyReport();
                    }
                    Person.FrmPersonDetail frmPersonDetail = (Person.FrmPersonDetail)Application.OpenForms["FrmPersonDetail"];
                    if (frmPersonDetail != null)
                    {
                        frmPersonDetail.LoadDebtInformation();
                        frmPersonDetail.LoadRentalInformation();
                    }
                    FrmMain frmMain = (FrmMain)Application.OpenForms["FrmMain"];
                    if (frmMain != null)
                    {
                        frmMain.LoadUpcomings();
                    }
                    FrmContractEdit frmContractEdit = (FrmContractEdit)Application.OpenForms["FrmContractEdit"];
                    if (frmContractEdit != null)
                    {
                        frmContractEdit.LoadRentals();
                        frmContractEdit.LoadDebts();
                    }
                    FrmCashBookList frmCashBookList = (FrmCashBookList)Application.OpenForms["FrmCashBookList"];
                    if (frmCashBookList != null)
                    {
                        frmCashBookList.LoadLastDays();
                    }
                    FrmDebtsToLandlord frmDebtsToLandlord = (FrmDebtsToLandlord)Application.OpenForms["FrmDebtsToLandlord"];
                    if (frmDebtsToLandlord != null)
                    {
                        frmDebtsToLandlord.LoadDebts();
                    }

                    Properties.Settings.Default.InvoiceId++;
                    Properties.Settings.Default.Save();

                    MessageHelper.KiraKaydedildi();

                    if (dtPaymentDate.Checked == true && MessageHelper.YazdirilsinMi() == DialogResult.Yes)
                    {
                        List<Debt> debts = rental.Contract.Debt.ToList(); ;
                        string paid = rental.Amount.ToString("c");

                        List<ContractParties> parties = rental.Contract.ContractParties.ToList();

                        FrmInvoicePrepare frmInvoiceShow = new FrmInvoicePrepare("", paid, debts, parties, string.Format("{0} {1} {2}", rental.Contract.Neighborhood, rental.Contract.Street, rental.Contract.Apartment));
                        frmInvoiceShow.ShowDialog();
                    }

                    if (rental.IsCommission && dtPaymentDate.Checked == true && MessageHelper.KasayaIslensinMi() == DialogResult.Yes)
                    {
                        db.CashBook.Add(new Model.CashBook()
                        {
                            Definition = rental.Definition,
                            Amount = rental.Amount,
                            TransactionDate = DateTime.Now,
                            TransactionType = "Giriş",
                            Debt = rental
                        });


                        if (db.SaveChanges() > 0)
                        {
                            FrmCashBookList frmCashBookList2 = (FrmCashBookList)Application.OpenForms["FrmCashBookList"];
                            if (frmCashBookList2 != null)
                            {
                                frmCashBookList2.LoadLastDays();
                            }
                            MessageHelper.KasayaIslendi();
                        }
                        else
                        {
                            MessageHelper.BeklenmedikHata();
                        }
                    }
                }
                else
                {
                    MessageHelper.BeklenmedikHata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogHelper.WriteLog(ex);
            }
            finally
            {
                Close();
            }
        }

        private void dtPaymentDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtPaymentDate.Checked)
            {
                cmbPaymentType.Enabled = true;
            }
            else
            {
                cmbPaymentType.SelectedIndex = 0;
                cmbPaymentType.Enabled = false;
            }
        }
    }
}
