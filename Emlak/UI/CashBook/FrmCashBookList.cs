using Emlak.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Emlak.UI.CashBook
{
    public partial class FrmCashBookList : BaseForm
    {
        public FrmCashBookList()
        {
            InitializeComponent();
        }

        Model.EmlakEntities db = new Model.EmlakEntities();

        public void LoadFilter()
        {
            var filter = db.CashBook.Select(q =>
            new
            {
                q.TransactionId,
                q.DebtId,
                q.TransactionType,
                q.TransactionDate,
                q.Definition,
                Giris = q.TransactionType == "Giriş" ? q.Amount : 0,
                Cikis = q.TransactionType == "Çıkış" ? q.Amount : 0,
            });

            if (dtTransactionTimeStart.Checked)
            {
                filter = filter.Where(q => q.TransactionDate >= DbFunctions.TruncateTime(dtTransactionTimeStart.Value));
            }
            if (dtTransactionTimeEnd.Checked)
            {
                filter = filter.Where(q => q.TransactionDate <= DbFunctions.TruncateTime(dtTransactionTimeEnd.Value));
            }
            if (cmbTransactionType.SelectedIndex > 0)
            {
                filter = filter.Where(q => q.TransactionType == cmbTransactionType.SelectedItem.ToString());
            }
            if (txtDefinition.Text.Trim().Length > 0)
            {
                filter = filter.Where(q => q.Definition.Contains(txtDefinition.Text));
            }

            var cashBookRecord = filter.OrderByDescending(q => q.TransactionId).ToList();

            dgTransactionList.DataSource = cashBookRecord;

            // datagrid başlıklarını ayarla
            dgTransactionList.Columns[0].HeaderText = "Transaction Id";
            dgTransactionList.Columns[1].HeaderText = "Debt Id";
            dgTransactionList.Columns[2].HeaderText = "İşlem Tipi";
            dgTransactionList.Columns[3].HeaderText = "İşlem Tarihi";
            dgTransactionList.Columns[4].HeaderText = "Tanım";
            dgTransactionList.Columns[5].HeaderText = "Giriş";
            dgTransactionList.Columns[6].HeaderText = "Çıkış";


            dgTransactionList.Columns[0].Visible = dgTransactionList.Columns[1].Visible = dgTransactionList.Columns[2].Visible = false;



            decimal incomesTotalAmount = cashBookRecord.Sum(q => q.Giris);
            decimal expensesTotalAmount = cashBookRecord.Sum(q => q.Cikis);
            decimal difference = incomesTotalAmount - expensesTotalAmount;

            lblTotalRecord.Text = String.Format("Kayıt sayısı: {0}  |  Giriş Toplam: {1:c}  |  Çıkış Toplam: {2:c}  |  Fark Toplam: {3:c}", filter.Count(), incomesTotalAmount, expensesTotalAmount, difference);
        }

        public void LoadLastDays(int lastBeforeDay = 0)
        {
            DateTime today = lastBeforeDay == 0 ? DateTime.Now : DateTime.Today.AddDays(-lastBeforeDay);

            var cashBookRecord = db.CashBook.Select(q => new
            {
                q.TransactionId,
                q.DebtId,
                q.TransactionType,
                q.TransactionDate,
                q.Definition,
                Giris = q.TransactionType == "Giriş" ? q.Amount : 0,
                Cikis = q.TransactionType == "Çıkış" ? q.Amount : 0,
            })
            .Where(q => DbFunctions.TruncateTime(q.TransactionDate) >= DbFunctions.TruncateTime(today))
            .OrderByDescending(q => q.TransactionId)
            .ToList();

            dgTransactionList.DataSource = cashBookRecord;

            // datagrid başlıklarını ayarla
            dgTransactionList.Columns[0].HeaderText = "Transaction Id";
            dgTransactionList.Columns[1].HeaderText = "Debt Id";
            dgTransactionList.Columns[2].HeaderText = "İşlem Tipi";
            dgTransactionList.Columns[3].HeaderText = "İşlem Tarihi";
            dgTransactionList.Columns[4].HeaderText = "Tanım";
            dgTransactionList.Columns[5].HeaderText = "Giriş";
            dgTransactionList.Columns[6].HeaderText = "Çıkış";


            dgTransactionList.Columns[0].Visible = dgTransactionList.Columns[1].Visible = dgTransactionList.Columns[2].Visible = false;


            decimal incomesTotalAmount = cashBookRecord.Sum(q => q.Giris);
            decimal expensesTotalAmount = cashBookRecord.Sum(q => q.Cikis);
            decimal difference = incomesTotalAmount - expensesTotalAmount;

            lblTotalRecord.Text = String.Format("Kayıt sayısı: {0}  |  Giriş Toplam: {1:c}  |  Çıkış Toplam: {2:c}  |  Kalan Toplam: {3:c}", cashBookRecord.Count(), incomesTotalAmount, expensesTotalAmount, difference);
        }

        private void FrmCashBookList_Load(object sender, EventArgs e)
        {
            dgTransactionList.DoubleBuffered(true);
            cmbTransactionType.SelectedIndex = 0;
            LoadLastDays(0);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            LoadLastDays(0);
        }

        private void btnLastWeek_Click(object sender, EventArgs e)
        {
            LoadLastDays(7);
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            LoadLastDays(DateHelper.TotalNumberOfDaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
        }

        private void dgTransactionList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgTransactionList.Rows.Count; i++)
            {
                if (dgTransactionList.Rows[i].Cells["TransactionType"].Value.ToString() == "Çıkış")
                {
                    dgTransactionList.Rows[i].Cells["Cikis"].Style.BackColor = Color.OrangeRed;
                }
                else if (dgTransactionList.Rows[i].Cells["TransactionType"].Value.ToString() == "Giriş")
                {
                    dgTransactionList.Rows[i].Cells["Giris"].Style.BackColor = Color.YellowGreen;
                }
            }
        }

        private void yeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmCashBookAdd>(-1);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgTransactionList.SelectedRows.Count > 0)
            {
                int transactionId = int.Parse(dgTransactionList.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmCashBookAdd>(transactionId);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgTransactionList.SelectedRows.Count > 0)
            {
                int transactionId = int.Parse(dgTransactionList.SelectedRows[0].Cells[0].Value.ToString());

                if (MessageHelper.KayitSil() == DialogResult.Yes)
                {
                    db.CashBook.Remove(db.CashBook.Where(q => q.TransactionId == transactionId).Single());
                    int num = db.SaveChanges();

                    if (num > 0)
                    {
                        LoadLastDays();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtTransactionTimeStart.Value = DateTime.Today;
            dtTransactionTimeEnd.Value = DateTime.Today;

            dtTransactionTimeStart.Checked = dtTransactionTimeEnd.Checked = false;

            cmbTransactionType.SelectedIndex = 0;

            txtDefinition.Text = "";

            lblTotalRecord.Text = "...";

            dgTransactionList.DataSource = null;
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgTransactionList, "Kasa.xlsx");
            excelHelper.ShowDialog();
        }

        private void dgTransactionList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgTransactionList.SelectedRows.Count > 0)
            {
                int transactionId = int.Parse(dgTransactionList.SelectedRows[0].Cells[0].Value.ToString());
                FormHelper.ShowDialog<FrmCashBookAdd>(transactionId);
            }
        }

        private void dtTransactionTimeStart_ValueChanged(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void cmbTransactionType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadFilter();
            }
        }
    }
}