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
    public partial class FrmPersonAdd : BaseForm
    {
        public FrmPersonAdd(int pid = -1)
        {
            InitializeComponent();
            this.PersonId = pid;
        }

        public int PersonId { get; set; }

        Model.EmlakEntities db = new Model.EmlakEntities();



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void FrmPersonAdd_Load(object sender, EventArgs e)
        {
            if (this.PersonId != -1)
            {
                Model.Person person = db.Person.Where(q => q.PersonId == this.PersonId).Single();

                if (person == null)
                {
                    Helper.MessageHelper.KayitBulunamadi();
                    return;
                }

                txtCitizenshipId.Text = person.CitizenshipId;
                txtFullName.Text = person.FullName;
                txtExplanation.Text = person.Explanation;
                txtPhone1.Text = person.Phone1;
                txtPhone2.Text = person.Phone2;

                btnSave.Text = "Güncelle";
            }
            else
            {
                btnSave.Text = "Ekle";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (this.PersonId != -1)
                {
                    // PersonId varsa güncelleme yapılacak
                    Model.Person person = db.Person.Where(q => q.PersonId == this.PersonId).Single();

                    if (person == null)
                    {
                        Helper.MessageHelper.KayitBulunamadi();
                        return;
                    }

                    person.CitizenshipId = txtCitizenshipId.Text;
                    person.FullName = txtFullName.Text;
                    person.Explanation = txtExplanation.Text;
                    person.Phone1 = txtPhone1.Text;
                    person.Phone2 = txtPhone2.Text;

                    if (db.Entry(person).State == System.Data.Entity.EntityState.Unchanged)
                    {
                        return;
                    }

                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        FrmPersonList frmPersonList = (FrmPersonList)Application.OpenForms["FrmPersonList"];
                        if (frmPersonList != null)
                        {
                            frmPersonList.LoadAllPerson();
                        }
                        MessageHelper.KayitGuncellendi();
                    }
                }
                else
                {
                    // PersonId yoksa ekleme yapılacak

                    Model.Person person = new Model.Person();
                    person.CitizenshipId = txtCitizenshipId.Text;
                    person.FullName = txtFullName.Text;
                    person.Explanation = txtExplanation.Text;
                    person.Phone1 = txtPhone1.Text;
                    person.Phone2 = txtPhone2.Text;


                    db.Person.Add(person);

                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        FrmPersonList frmPersonList = (FrmPersonList)Application.OpenForms["FrmPersonList"];
                        if (frmPersonList != null)
                        {
                            frmPersonList.LoadAllPerson();
                        }
                        MessageHelper.KayitEklendi();
                    }
                    else
                    {
                        Helper.MessageHelper.BeklenmedikHata();
                    }
                }
            Close();
            //}
            //catch (Exception ex)
            //{
            //    LogHelper.WriteLog("FrmPersonAdd -> " + ex.Message);
            //}
            //finally
            //{
            //    Close();
            //}
        }
    }
}
