using Emlak.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.UI.CashBook
{
    public partial class FrmCashBookAdd : BaseForm
    {
        public FrmCashBookAdd(int transactionId = -1)
        {
            InitializeComponent();
            this.TransactionId = transactionId;
        }

        public int TransactionId { get; set; }

        Model.EmlakEntities db = new Model.EmlakEntities();

        private void FrmCashBookAdd_Load(object sender, EventArgs e)
        {
            if (this.TransactionId != -1)
            {
                // güncelleme işlemi
                Model.CashBook transaction = db.CashBook.Where(q => q.TransactionId == this.TransactionId).FirstOrDefault();
                dtTransactionTime.Value = transaction.TransactionDate;
                cmbTransactionType.SelectedItem = transaction.TransactionType;
                txtPrice.Text = transaction.Amount.ToString();
                txtDefinition.Text = transaction.Definition;

                btnAdd.Text = "Güncelle";
            }
            else
            {
                btnAdd.Text = "Kaydet";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TransactionId != -1)
                {
                    // TransactionId varsa güncelleme yapılacak
                    Model.CashBook transaction = db.CashBook.Where(q => q.TransactionId == this.TransactionId).Single();

                    if (transaction == null)
                    {
                        MessageHelper.KayitBulunamadi();
                        return;
                    }

                    transaction.TransactionDate = dtTransactionTime.Value;
                    transaction.TransactionType = cmbTransactionType.SelectedItem.ToString();
                    transaction.Amount = decimal.Parse(txtPrice.Text);
                    transaction.Definition = txtDefinition.Text;


                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        MessageHelper.KayitGuncellendi();

                        FrmCashBookList frmCashBookList = (FrmCashBookList)Application.OpenForms["FrmCashBookList"];
                        if (frmCashBookList != null)
                        {
                            frmCashBookList.LoadLastDays(0);
                        }
                        Close();
                    }
                }
                else
                {
                    // TransactionId yoksa ekleme yapılacak

                    if (cmbTransactionType.SelectedItem == null)
                    {
                        MessageHelper.IslemTipiSecin();
                        return;
                    }
                    if (!txtPrice.Text.IsNotNull())
                    {
                        MessageBox.Show("İşlem tutarı girin.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!txtDefinition.Text.IsNotNull())
                    {
                        MessageBox.Show("İşlem adı girin.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Model.CashBook transaction = new Model.CashBook();
                    transaction.TransactionDate = dtTransactionTime.Value;
                    transaction.TransactionType = cmbTransactionType.Text;
                    transaction.Amount = decimal.Parse(txtPrice.Text);
                    transaction.Definition = txtDefinition.Text;

                    db.CashBook.Add(transaction);

                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        MessageHelper.KayitEklendi();

                        FrmCashBookList frmCashBookList = (FrmCashBookList)Application.OpenForms["FrmCashBookList"];
                        if (frmCashBookList != null)
                        {
                            frmCashBookList.LoadLastDays();
                        }
                        Close();
                    }
                    else
                    {
                        MessageHelper.BeklenmedikHata();
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("FrmCashBookAdd -> " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
