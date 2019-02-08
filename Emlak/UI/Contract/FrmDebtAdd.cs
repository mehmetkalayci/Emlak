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

namespace Emlak.UI.Contract
{
    public partial class FrmDebtAdd : BaseForm
    {
        public FrmDebtAdd()
        {
            InitializeComponent();
        }

        public string Definition { get; set; } = "";

        public string Amount { get; set; } = "";

        public DateTime DueDate { get; set; } = DateTime.Today;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnAddd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Definition = txtDefinition.Text;
                this.Amount = txtAmount.Text;
                this.DueDate = dtDueDate.Value;
                Close();
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
            }
        }
    }
}
