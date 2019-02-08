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
    public partial class FrmInvoiceShow : BaseForm
    {
        public FrmInvoiceShow()
        {
            InitializeComponent();
        }

        public ReportParameter[] Parameters { get; set; }


        private void FrmInvoiceShow_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(this.Parameters);
            this.reportViewer1.RefreshReport();
        }
        
    }
}
