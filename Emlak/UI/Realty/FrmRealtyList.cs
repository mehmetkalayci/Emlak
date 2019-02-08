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

namespace Emlak.UI.Realty
{
    public partial class FrmRealtyList : BaseForm
    {
        public FrmRealtyList()
        {
            InitializeComponent();
        }

        Model.EmlakEntities db = new Model.EmlakEntities();


        public void LoadAllRealties()
        {
            var realties = db.Realty
                .Select(q => new
                {
                    q.RealtyId,
                    q.RealtyTypeId,
                    q.Definition,
                    q.RealtyType.RealtyTypeName,
                    q.Neighborhood,
                    q.Street,
                    q.Apartment,
                    q.City,
                    q.Town,
                    q.Explanation
                })
                .OrderByDescending(q => q.RealtyId)
                .ToList();

            dgRealtyList.DataSource = realties;

            // datagrid başlıklarını ayarla
            dgRealtyList.Columns[0].HeaderText = "Gayrimenkul Id";
            dgRealtyList.Columns[1].HeaderText = "Gayrimenkul Tip Id";
            dgRealtyList.Columns[2].HeaderText = "Tanım";
            dgRealtyList.Columns[3].HeaderText = "Emlak Tipi";
            dgRealtyList.Columns[4].HeaderText = "Mahalle";
            dgRealtyList.Columns[5].HeaderText = "Cadde/Sokak";
            dgRealtyList.Columns[6].HeaderText = "Daire";
            dgRealtyList.Columns[7].HeaderText = "İl";
            dgRealtyList.Columns[8].HeaderText = "İlçe";
            dgRealtyList.Columns[9].HeaderText = "Açıklama";

            dgRealtyList.Columns[0].Visible = false;
            dgRealtyList.Columns[1].Visible = false;

            lblTotalRecord.Text = "Bulunan kayıt sayısı: " + realties.Count();
        }

        private void Filter()
        {
            var realties = db.Realty
                .Select(q => new
                {
                    q.RealtyId,
                    q.RealtyTypeId,
                    q.Definition,
                    q.RealtyType.RealtyTypeName,
                    q.Neighborhood,
                    q.Street,
                    q.Apartment,
                    q.City,
                    q.Town,
                    q.Explanation
                });

            if (txtDefinition.Text.Trim().Length > 0)
            {
                realties = realties.Where(q => q.Definition.Contains(txtDefinition.Text));
            }
            if (cmbRealtyType.SelectedIndex > 0)
            {
                int realtyTypeId = (cmbRealtyType.SelectedItem as Model.RealtyType).RealtyTypeId;
                realties = realties.Where(q => q.RealtyTypeId == realtyTypeId);
            }
            if (cmbCity.SelectedIndex > 0)
            {
                string city = (cmbCity.SelectedItem as Model.City).CityName;
                realties = realties.Where(q => q.City == city);
            }
            if (cmbTown.SelectedIndex > 0)
            {
                string town = (cmbTown.SelectedItem as Model.Town).TownName;
                realties = realties.Where(q => q.Town == town);
            }
            if (txtNeighborhood.Text.Trim().Length > 0)
            {
                realties = realties.Where(q => q.Neighborhood.Contains(txtNeighborhood.Text));
            }
            if (txtStreet.Text.Trim().Length > 0)
            {
                realties = realties.Where(q => q.Street.Contains(txtStreet.Text));
            }
            if (txtExplanation.Text.Trim().Length > 0)
            {
                realties = realties.Where(q => q.Explanation.Contains(txtExplanation.Text));
            }

            dgRealtyList.DataSource = realties.OrderByDescending(q => q.RealtyId).ToList();

            // datagrid başlıklarını ayarla
            dgRealtyList.Columns[0].HeaderText = "Gayrimenkul Id";
            dgRealtyList.Columns[1].HeaderText = "Gayrimenkul Tip Id";
            dgRealtyList.Columns[2].HeaderText = "Tanım";
            dgRealtyList.Columns[3].HeaderText = "Emlak Tipi";
            dgRealtyList.Columns[4].HeaderText = "Mahalle";
            dgRealtyList.Columns[5].HeaderText = "Cadde/Sokak";
            dgRealtyList.Columns[6].HeaderText = "Daire";
            dgRealtyList.Columns[7].HeaderText = "İl";
            dgRealtyList.Columns[8].HeaderText = "İlçe";
            dgRealtyList.Columns[9].HeaderText = "Açıklama";

            dgRealtyList.Columns[0].Visible = false;
            dgRealtyList.Columns[1].Visible = false;

            lblTotalRecord.Text = "Bulunan kayıt sayısı: " + realties.Count();
        }

        private void FrmRealtyList_Load(object sender, EventArgs e)
        {
            dgRealtyList.DoubleBuffered(true);


            var cities = db.City.ToList();
            cities.Insert(0, new Model.City() { CityId = -1, CityName = "Seçim Yapın" });

            cmbCity.DataSource = cities;
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityId";

            var realtyTypes = db.RealtyType.ToList();
            realtyTypes.Insert(0, new Model.RealtyType() { RealtyTypeId = -1, RealtyTypeName = "Seçim Yapın" });

            cmbRealtyType.DataSource = realtyTypes;
            cmbRealtyType.DisplayMember = "RealtyTypeName";
            cmbRealtyType.ValueMember = "RealtyTypeId";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadAllRealties();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDefinition.Text = txtNeighborhood.Text = txtStreet.Text = txtExplanation.Text = "";
            cmbRealtyType.SelectedItem = null;
            cmbCity.SelectedItem = null;
            cmbTown.SelectedItem = null;

            dgRealtyList.DataSource = null;
            lblTotalRecord.Text = "...";
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int cityId = (cmbCity.SelectedItem as Model.City).CityId;

                var towns = db.Town.Where(q => q.CityId == cityId).ToList();
                towns.Insert(0, new Model.Town() { TownId = -1, TownName = "Seçim Yapın" });

                cmbTown.DataSource = towns;
                cmbTown.DisplayMember = "TownName";
                cmbTown.ValueMember = "TownId";
            }
            catch
            {

            }
        }

        private void yeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelper.ShowDialog<FrmRealtyAdd>(-1);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgRealtyList.SelectedRows.Count > 0)
            {
                int realtyId = int.Parse(dgRealtyList.SelectedRows[0].Cells[0].Value.ToString());

                if (realtyId != -1)
                {
                    FormHelper.ShowDialog<FrmRealtyAdd>(realtyId);
                }
            }
            else
            {
                MessageHelper.GridSatirSecmediniz();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgRealtyList.SelectedRows.Count > 0)
            {
                int realtyId = int.Parse(dgRealtyList.SelectedRows[0].Cells[0].Value.ToString());

                if (MessageHelper.KayitSil() == DialogResult.Yes)
                {
                    db.Realty.Remove(db.Realty.Where(q => q.RealtyId == realtyId).Single());
                    int num = db.SaveChanges();

                    if (num > 0)
                    {
                        LoadAllRealties();
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
            ExcelHelper excelHelper = new ExcelHelper(dgRealtyList, "Gayrimenkul Listesi.xlsx");
            excelHelper.ShowDialog();
        }

        private void dgRealtyList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRealtyList.SelectedRows.Count > 0)
            {
                int realtyId = int.Parse(dgRealtyList.SelectedRows[0].Cells[0].Value.ToString());

                if (realtyId != -1)
                {
                    FormHelper.ShowDialog<FrmRealtyAdd>(realtyId);
                }
            }
        }

        private void KeyDownFilter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filter();
            }
        }
    }
}