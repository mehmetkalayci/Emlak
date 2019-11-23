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
    public partial class FrmContractCancelDateSelect : BaseForm
    {
        public FrmContractCancelDateSelect()
        {
            InitializeComponent();
        }

        public DateTime CancelDate { get; set; }

        public bool IsCancel { get; set; } = true;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsCancel = true;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.CancelDate = dtCancelDate.Value;
            this.IsCancel = false;
            Close();
        }
    }
}
