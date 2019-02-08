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
    public partial class FrmRealtyAdd : BaseForm
    {
        public FrmRealtyAdd(int realtyId = -1)
        {
            InitializeComponent();
            this.RealtyId = realtyId;
        }

        public int RealtyId { get; set; }

        Model.EmlakEntities db = new Model.EmlakEntities();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRealtyAdd_Load(object sender, EventArgs e)
        {
            var cities = db.City.ToList();
            cmbCity.DataSource = cities;
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityId";

            var realtyType = db.RealtyType.ToList();
            cmbRealtyType.DataSource = realtyType;
            cmbRealtyType.DisplayMember = "RealtyTypeName";
            cmbRealtyType.ValueMember = "RealtyTypeId";

            cmbCity.Text = "Konya";
            cmbTown.Text = "Selçuklu";


            if (this.RealtyId != -1)
            {
                Model.Realty selectedRealty = db.Realty.Where(q => q.RealtyId == this.RealtyId).SingleOrDefault();

                txtDefinition.Text = selectedRealty.Definition;
                cmbRealtyType.Text = selectedRealty.RealtyType.RealtyTypeName;
                cmbCity.Text = selectedRealty.City;
                cmbTown.Text = selectedRealty.Town;
                txtNeighborhood.Text = selectedRealty.Neighborhood;
                txtStreet.Text = selectedRealty.Street;
                txtApartment.Text = selectedRealty.Apartment;
                txtExplanation.Text = selectedRealty.Explanation;

                btnSave.Text = "Güncelle";
            }
            else
            {
                btnSave.Text = "Ekle";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.RealtyId != -1)
                {
                    // Güncelleme İşlemi
                    Model.Realty selectedRealty = db.Realty.Where(q => q.RealtyId == this.RealtyId).FirstOrDefault();
                    selectedRealty.Definition = txtDefinition.Text;
                    selectedRealty.RealtyTypeId = (cmbRealtyType.SelectedItem as Model.RealtyType).RealtyTypeId;
                    selectedRealty.City = (cmbCity.SelectedItem as Model.City).CityName;
                    selectedRealty.Town = (cmbTown.SelectedItem as Model.Town).TownName;
                    selectedRealty.Neighborhood = txtNeighborhood.Text;
                    selectedRealty.Street = txtStreet.Text;
                    selectedRealty.Apartment = txtApartment.Text;
                    selectedRealty.Explanation = txtExplanation.Text;

                    if (db.Entry(selectedRealty).State == System.Data.Entity.EntityState.Unchanged)
                    {
                        return;
                    }

                    int num = db.SaveChanges();
                    if (num > 0)
                    {
                        MessageHelper.KayitGuncellendi();

                        FrmRealtyList frmRealtyList = (FrmRealtyList)Application.OpenForms["FrmRealtyList"];
                        if (frmRealtyList != null)
                        {
                            frmRealtyList.LoadAllRealties();
                        }
                    }
                    else
                    {
                        MessageHelper.BeklenmedikHata();
                    }
                }
                else
                {
                    // Ekleme İşlemi
                    Model.Realty realty = new Model.Realty();
                    realty.Definition = txtDefinition.Text;
                    realty.RealtyTypeId = (cmbRealtyType.SelectedItem as Model.RealtyType).RealtyTypeId;
                    realty.City = (cmbCity.SelectedItem as Model.City).CityName;
                    realty.Town = (cmbTown.SelectedItem as Model.Town).TownName;
                    realty.Neighborhood = txtNeighborhood.Text;
                    realty.Street = txtStreet.Text;
                    realty.Apartment = txtApartment.Text;
                    realty.Explanation = txtExplanation.Text;

                    db.Realty.Add(realty);
                    int num = db.SaveChanges();
                    if (num > 0)
                    {
                        MessageHelper.KayitEklendi();
                        FrmRealtyList frmRealtyList = (FrmRealtyList)Application.OpenForms["FrmRealtyList"];
                        if (frmRealtyList != null)
                        {
                            frmRealtyList.LoadAllRealties();
                        }
                    }
                    else
                    {
                        MessageHelper.BeklenmedikHata();
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("FrmRealtyAdd-> " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cityId = (cmbCity.SelectedItem as Model.City).CityId;

            var towns = db.Town.Where(q => q.CityId == cityId).ToList();

            cmbTown.DataSource = towns;
            cmbTown.DisplayMember = "TownName";
            cmbTown.ValueMember = "TownId";
        }
    }
}
