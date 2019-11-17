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
    public partial class FrmSelectBackground : BaseForm
    {
        public FrmSelectBackground()
        {
            InitializeComponent();
        }


        List<String> pics = new List<string>();

        private void SelectBg(object sender, EventArgs e)
        {
            int index = flowLayoutPanel1.Controls.IndexOf(sender as Control);
            string path = pics[index];

            if (index >= 0 && File.Exists(path))
            {

                Properties.Settings.Default.Background = path;
                Properties.Settings.Default.NoBackground = chkNoImage.Checked = false;
                Properties.Settings.Default.Save();


                Application.OpenForms["FrmMain"].BackgroundImage= BackgroundImage = flowLayoutPanel1.BackgroundImage = Image.FromFile(path);
            
            }
        }


        private void FrmSelectBackground_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.NoBackground && System.IO.File.Exists(Properties.Settings.Default.Background))
            {
                Application.OpenForms["FrmMain"].BackgroundImage = BackgroundImage =flowLayoutPanel1.BackgroundImage = Image.FromFile(Properties.Settings.Default.Background);
            }



            if (System.IO.Directory.Exists(Application.StartupPath + "\\Arkaplan"))
            {
                pics = System.IO.Directory.GetFiles(Application.StartupPath + "\\Arkaplan", "*.jpg").ToList();
            }

            if (pics.Count <= 0)
            {
                MessageBox.Show("Arkaplan klasöründe resim bulunamadı!");
                return;
            }

            foreach (var item in pics)
            {
                PictureBox pic = new PictureBox()
                {
                    Width = 80,
                    Height = 80,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Image = Image.FromFile(item)
                };
                pic.Click += SelectBg;
                flowLayoutPanel1.Controls.Add(pic);
            }
        }

        private void chkNoImage_CheckedChanged(object sender, EventArgs e)
        {
            Application.OpenForms["FrmMain"].BackgroundImage = BackgroundImage = flowLayoutPanel1.BackgroundImage = null;
            Properties.Settings.Default.NoBackground = chkNoImage.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
