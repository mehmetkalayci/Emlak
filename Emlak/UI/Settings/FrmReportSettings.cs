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

namespace Emlak.UI.Settings
{
    public partial class FrmReportSettings : BaseForm
    {
        public FrmReportSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CompanyName = txtCompanyName.Text;
            Properties.Settings.Default.CompanyPhone = txtCompanyPhone.Text;
            Properties.Settings.Default.CompanyAddress = txtCompanyAddress.Text;

            Properties.Settings.Default.Save();
            MessageHelper.AyarlarKaydedildi();
            Close();
        }

    }
}
