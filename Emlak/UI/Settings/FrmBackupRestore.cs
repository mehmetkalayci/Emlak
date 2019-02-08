using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.UI.Settings
{
    public partial class FrmBackupRestore : BaseForm
    {
        public FrmBackupRestore()
        {
            InitializeComponent();
        }

        Model.EmlakEntities db = new Model.EmlakEntities();

        Server server;

        private void FrmBackupRestore_Load(object sender, EventArgs e)
        {
            server = new Server(db.Database.Connection.DataSource);
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string backupPath = folderBrowserDialog1.SelectedPath;

            if (!Directory.Exists(backupPath))
            {
                txtLog.AppendText("Belirtilen klasör bulunamadı!");
            }
            else
            {
                Backup(backupPath);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string restorePath = folderBrowserDialog1.SelectedPath;

            if (!Directory.Exists(restorePath))
            {
                txtLog.AppendText("Belirtilen klasör bulunamadı!");
            }
            else
            {
                Restore(restorePath);
            }
        }

        
        public void Backup(string path)
        {
            try
            {
                var backupFileName = String.Format("{0}Emlak-{1}.bak", path, DateTime.Now.ToString("yyyyMMddHHMMss"));

                Backup bkpDBFull = new Backup();
                bkpDBFull.Action = BackupActionType.Database;
                bkpDBFull.Database = "Emlak";
                bkpDBFull.Devices.AddDevice(backupFileName, DeviceType.File);
                bkpDBFull.BackupSetName = "Emlak Backup";
                bkpDBFull.BackupSetDescription = "Emlak - Full Backup";

                //bkpDBFull.ExpirationDate = DateTime.Today.AddDays(0);
                
                bkpDBFull.PercentComplete += BkpDBFull_PercentComplete; ;
                bkpDBFull.Complete += BkpDBFull_Complete;

                bkpDBFull.SqlBackup(server);
                txtLog.AppendText("Yedekleme başlatıldı...!");

            }
            catch (SmoException ex)
            {
                txtLog.AppendText("HATA OLUŞTU!");
                txtLog.AppendText(ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                txtLog.AppendText("HATA OLUŞTU!");
                txtLog.AppendText(ex.Message);
            }
        }

        private void BkpDBFull_Complete(object sender, Microsoft.SqlServer.Management.Common.ServerMessageEventArgs e)
        {
            txtLog.AppendText(e.Error.Message);
        }

        private void BkpDBFull_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            txtLog.AppendText("\nYüzde " + e.Percent + " tamamlandı!\n");
        }

        public void Restore(string path)
        {
            try
            {
                txtLog.Text += "\nGeri yükleme başlatıldı...!\n";




                txtLog.Text += "\nGeri yükleme tamamlandı!\n";
            }
            catch (Exception ex)
            {
                txtLog.Text += "\nHATA OLUŞTU!\n" + ex.Message + "\n";
            }
        }
    }
}
