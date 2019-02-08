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

namespace Emlak.UI.Contract
{
    public partial class FrmContractPartyAdd : BaseForm
    {
        public FrmContractPartyAdd()
        {
            InitializeComponent();
        }

        public int PersonId { get; set; } = -1;

        public string PersonType { get; set; }

        public string PersonFullName { get; set; }


        Model.EmlakEntities db = new Model.EmlakEntities();



        private void FrmContractPartyAdd_Load(object sender, EventArgs e)
        {
            var people = db.Person.Select(q => new
            {
                q.PersonId,
                FullInfo = q.FullName + " - " + q.CitizenshipId
            }).ToList();

            cmbPerson.DataSource = people;
            cmbPerson.DisplayMember = "FullInfo";
            cmbPerson.ValueMember = "PersonId";
            cmbPersonType.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.PersonId = (cmbPerson.SelectedItem as dynamic).PersonId;
                this.PersonType = cmbPersonType.SelectedItem.ToString();

                this.PersonFullName = (cmbPerson.SelectedItem as dynamic).FullInfo;
                Close();
            }
            catch
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
