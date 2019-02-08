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
    public partial class FrmLoginSetting : BaseForm
    {
        public FrmLoginSetting()
        {
            InitializeComponent();
        }

        Model.EmlakEntities db = new Model.EmlakEntities();
        string oldpass = "";

        private void FrmLoginSetting_Load(object sender, EventArgs e)
        {
            var user = db.User.Where(q => q.Id == 1).FirstOrDefault();

            txtUsername.Text = user.Username;
            oldpass = user.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = db.User.Where(q => q.Id == 1).FirstOrDefault();

            user.Username = txtUsername.Text;

            if (txtNewPassword.Text.Trim().Length > 0)
            {
                user.Password = txtNewPassword.Text;
            }


            if (oldpass == txtOldPassword.Text)
            {
                int num = db.SaveChanges();
                if (num >= 1)
                {
                    MessageHelper.KayitGuncellendi();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Eski şifreniz hatalı!");
            }
        }

    }
}
