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

namespace Emlak.UI.Person
{
    public partial class FrmPersonList : BaseForm
    {
        public FrmPersonList()
        {
            InitializeComponent();
        }

        Model.EmlakEntities db = new Model.EmlakEntities();

        #region Filtrele

        public void LoadFilter()
        {
            var people = db.Person.Select(q => new { q.PersonId, q.FullName, q.CitizenshipId, q.Phone1, q.Phone2, q.Explanation });

            if (txtFilterCitizenshipId.Text.Trim().Length > 0)
            {
                people = people.Where(q => q.CitizenshipId.StartsWith(txtFilterCitizenshipId.Text));
            }
            if (txtFilterFullName.Text.Trim().Length > 0)
            {
                people = people.Where(q => q.FullName.StartsWith(txtFilterFullName.Text));
            }


            dgPersonList.DataSource = people.OrderByDescending(q => q.PersonId).ToList(); ;

            // datagrid başlıklarını ayarla
            dgPersonList.Columns[0].HeaderText = "Id";
            dgPersonList.Columns[1].HeaderText = "Ad Soyad";
            dgPersonList.Columns[2].HeaderText = "TC Kimlik No";
            dgPersonList.Columns[3].HeaderText = "Telefon 1";
            dgPersonList.Columns[4].HeaderText = "Telefon 2";
            dgPersonList.Columns[5].HeaderText = "Açıklama";


            dgPersonList.Columns[0].Visible = false;

            lblTotalRecord.Text = "Kayıt sayısı: " + people.Count();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadFilter();
        }

        public void LoadAllPerson()
        {
            var people = db.Person.Select(q => new { q.PersonId, q.FullName, q.CitizenshipId, q.Phone1, q.Phone2, q.Explanation }).OrderByDescending(q => q.PersonId).ToList();
            dgPersonList.DataSource = people;


            // datagrid başlıklarını ayarla
            dgPersonList.Columns[0].HeaderText = "Id";
            dgPersonList.Columns[1].HeaderText = "Ad Soyad";
            dgPersonList.Columns[2].HeaderText = "TC Kimlik No";
            dgPersonList.Columns[3].HeaderText = "Telefon 1";
            dgPersonList.Columns[4].HeaderText = "Telefon 2";
            dgPersonList.Columns[5].HeaderText = "Açıklama";

            dgPersonList.Columns[0].Visible = false;

            lblTotalRecord.Text = "Kayıt sayısı: " + people.Count();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadAllPerson();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilterCitizenshipId.Text = txtFilterFullName.Text;
            dgPersonList.DataSource = null;
            lblTotalRecord.Text = "...";
        }

        #endregion


        private void FrmPersonList_Load(object sender, EventArgs e)
        {
            dgPersonList.DoubleBuffered(true);
            LoadAllPerson();
        }

        private void yeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmPersonAdd>(-1);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgPersonList.SelectedRows.Count > 0)
            {
                int personId = int.Parse(dgPersonList.SelectedRows[0].Cells[0].Value.ToString());

                FormHelper.ShowDialog<FrmPersonAdd>(personId);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgPersonList.SelectedRows.Count > 0)
            {
                int personId = int.Parse(dgPersonList.SelectedRows[0].Cells[0].Value.ToString());

                if (MessageHelper.KayitSil() == DialogResult.Yes)
                {
                    db.Person.Remove(db.Person.Where(q => q.PersonId == personId).Single());
                    int num = db.SaveChanges();

                    if (num > 0)
                    {
                        LoadAllPerson();
                        MessageHelper.KayitSilindi();
                    }
                    else
                    {
                        MessageHelper.BeklenmedikHata();
                    }
                }
            }
            else
            {
                MessageHelper.GridSatirSecmediniz();
            }
        }
        
        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper excelHelper = new ExcelHelper(dgPersonList, "Kiracı Liste.xlsx");
            excelHelper.ShowDialog();
        }


        private void dgPersonList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPersonList.SelectedRows.Count > 0)
            {
                int personId = int.Parse(dgPersonList.SelectedRows[0].Cells[0].Value.ToString());
            
                if (personId != -1)
                {
                    FormHelper.ShowDialog<FrmPersonDetail>(personId);
                }
            }
        }
        
        private void KeyDownFilter(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                LoadFilter();
            }
        }
    }
}
