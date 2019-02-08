using Emlak.UI;
using Emlak.UI.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("tr-TR");
            cultureInfo.NumberFormat.CurrencySymbol = "₺";

            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;

            


            //FrmLicenseChecker frmLicenseChecker = new FrmLicenseChecker();
            //Application.Run(frmLicenseChecker);

            FrmLogin frmLogin = new FrmLogin();
            Application.Run(frmLogin);


            if (frmLogin.IsLoggedin)
            {
                Application.Run(new FrmMain());
            }
            
        }
    }
}
