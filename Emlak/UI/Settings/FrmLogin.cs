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
    public partial class FrmLogin : BaseForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        Model.EmlakEntities db = new Model.EmlakEntities();
        int count = 3;

        public bool IsLoggedin { get; set; } = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int login = db.User.Where(q => q.Username == txtUsername.Text && q.Password == txtPassword.Text).Count();
            if (login <= 0)
            {
                --count;
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
            else
            {
                this.IsLoggedin = true;

                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Save();

                Close();
            }

            if (count <= 0)
            {
                MessageBox.Show("3 kez giriş denemesi yaptınız!Program kapatılacak.");
                Application.Exit();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.IsLoggedin = false;
        }

    }
}
