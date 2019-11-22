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

namespace Backup
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserBackup.ShowDialog() == DialogResult.OK)
                {
                    // Pick the data source dir
                    string sourceDataPath = Application.StartupPath + "\\Data";

                    // Make target dir
                    string targetBackupPath = folderBrowserBackup.SelectedPath + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    Directory.CreateDirectory(targetBackupPath);

                    // Find db files
                    string[] files = System.IO.Directory.GetFiles(sourceDataPath);

                    // Copy src files to target
                    foreach (string file in files)
                    {
                        string targetFilePath = System.IO.Path.Combine(targetBackupPath, Path.GetFileName(file));
                        System.IO.File.Copy(file, targetFilePath, true);

                        richTextBox1.Text += string.Format("{0} --> {1} kopyalandı...\n", file, targetFilePath);
                    }
                    richTextBox1.Text += "Yedekleme işlemi tamamlandı!\n";
                    MessageBox.Show("Yedekleme işlemi tamamlandı!", "Yedekle/Geri Yükle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string targetDataPath = Application.StartupPath + "\\Data\\";


                if (folderBrowserRestore.ShowDialog() == DialogResult.OK)
                {
                    string sourceDataPath = folderBrowserRestore.SelectedPath;

                    string[] files = System.IO.Directory.GetFiles(sourceDataPath);

                    foreach (var file in files)
                    {
                        string ext = Path.GetExtension(file);

                        if (ext == ".mdf" || ext == ".ldf")
                        {
                            string target = targetDataPath + Path.GetFileName(file);
                            File.Copy(file, target,true);
                            richTextBox1.Text += string.Format("{0} --> {1} kopyalandı...\n", file, target);
                        }
                    }
                    richTextBox1.Text += "Geri yükleme işlemi tamamlandı!\n";
                    MessageBox.Show("Geri yükleme işlemi tamamlandı!", "Yedekle/Geri Yükle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
