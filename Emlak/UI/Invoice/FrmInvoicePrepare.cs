using Emlak.Helper;
using Emlak.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.UI.Invoice
{
    public partial class FrmInvoicePrepare : BaseForm
    {

        public FrmInvoicePrepare()
        {
            InitializeComponent();
        }

        public FrmInvoicePrepare(string fullname, string paid, List<Debt> debts, List<ContractParties> parties, string apartment)
        {
            InitializeComponent();

            this.FullName = fullname;
            this.Paid = paid;
            this.Debts = debts;
            this.Apartment = apartment;
            this.Parties = parties;
        }

        public string FullName { get; set; }
        public string Paid { get; set; }
        public List<Debt> Debts { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Apartment { get; set; }

        public List<ContractParties> Parties { get; set; }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!txtInvoiceNumber.Text.IsNotNull())
            {
                MessageBox.Show("Fatura numarası alanı boş olamaz!");
                return;
            }
            if (!txtApartment.Text.IsNotNull())
            {
                MessageBox.Show("Daire alanı boş olamaz!");
                return;
            }
            if (!txtFullName.Text.IsNotNull())
            {
                MessageBox.Show("Ad soyad alanı boş olamaz!");
                return;
            }
            if (!txtPaid.Text.IsNotNull())
            {
                MessageBox.Show("Tahsilat alanı boş olamaz!");
                return;
            }
            if (!txtRemaining.Text.IsNotNull())
            {
                MessageBox.Show("Kalan borç alanı boş olamaz!");
                return;
            }
            if (txtDates.Text.Length <= 0)
            {
                MessageBox.Show("Tarih listesi alanı boş olamaz!");
                return;
            }
            if (txtAmounts.Text.Length <= 0)
            {
                MessageBox.Show("Kalan borçlar alanı boş olamaz!");
                return;
            }

            ReportParameter[] parameters = new ReportParameter[10];
            parameters[0] = new ReportParameter("paramInvoiceNumber", txtInvoiceNumber.Text, true);
            parameters[1] = new ReportParameter("paramFullName", txtFullName.Text, true);
            parameters[2] = new ReportParameter("paramPaid", txtPaid.Text, true);
            parameters[3] = new ReportParameter("paramRemainingAmount", txtRemaining.Text, true);
            parameters[4] = new ReportParameter("paramDates", txtDates.Text, true);
            parameters[5] = new ReportParameter("paramAmounts", txtAmounts.Text, true);
            parameters[6] = new ReportParameter("paramApartment", txtApartment.Text, true);

            parameters[7] = new ReportParameter("paramCompanyName", Properties.Settings.Default.CompanyName, true);
            parameters[8] = new ReportParameter("paramCompanyAddress", Properties.Settings.Default.CompanyAddress, true);
            parameters[9] = new ReportParameter("paramCompanyPhone", Properties.Settings.Default.CompanyPhone, true);


            Properties.Settings.Default.DefaultInvoiceType = cmbInvoince.SelectedItem.ToString();
            Properties.Settings.Default.Save();

            FrmInvoiceShow frmInvoiceShow = new FrmInvoiceShow();
            frmInvoiceShow.Parameters = parameters;
            frmInvoiceShow.Report = cmbInvoince.SelectedItem.ToString();
            frmInvoiceShow.ShowDialog();
        }

        private void FrmInvoiceShow_Load(object sender, EventArgs e)
        {
            string remaining = "";
            if (Debts != null)
            {
                // BURADA KOMİSYONLARI ÇEKECEZ Mİ?
                Debts = Debts.Where(q => q.IsPaidByTenant == false).OrderBy(q => q.DueDate).ToList();

                remaining = Debts.Sum(q => q.Amount).ToString("c");

                foreach (var item in this.Debts)
                {
                    txtDates.Text += item.DueDate.ToString("dd.MM.yyyy") + "\r\n";
                    txtAmounts.Text += item.Amount.ToString("c") + "\r\n";
                }

            }

            txtInvoiceNumber.Text = string.Format("{0:D8}", Properties.Settings.Default.InvoiceId);

            txtRemaining.Text = remaining;
            txtPaid.Text = this.Paid;
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtTime.Text = DateTime.Now.ToShortTimeString();
            txtFullName.Text = "";
            txtApartment.Text = this.Apartment;

            if (this.Parties != null)
            {
                foreach (var item in this.Parties)
                {
                    if (item.PersonType == "Kiracı")
                    {
                        txtFullName.Text += item.Person.FullName;
                        break;
                    }
                }
            }

            cmbInvoince.SelectedItem = Properties.Settings.Default.DefaultInvoiceType;
            //cmbInvoince.SelectedIndex = 0;


        }

    }
}
