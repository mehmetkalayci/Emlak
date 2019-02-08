using Emlak.Helper;
using Emlak.Properties;
using Microsoft.Office.Interop.Word;
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

namespace Emlak.UI.Contract
{
    public partial class FrmContractWriter : BaseForm
    {
        public FrmContractWriter(int contractId)
        {
            InitializeComponent();
            this.contractId = contractId;
        }

        Model.EmlakEntities db = new Model.EmlakEntities();

        private int contractId;
        
        private void ReplaceBookmarkText(Microsoft.Office.Interop.Word.Document doc, string bookmarkName, string text)
        {
            if (doc.Bookmarks.Exists(bookmarkName))
            {
                Object name = bookmarkName;
                Microsoft.Office.Interop.Word.Range range = doc.Bookmarks.get_Item(ref name).Range;

                range.Text = text;
                object newRange = range;
                doc.Bookmarks.Add(bookmarkName, ref newRange);
            }
        }

        private void ExportToWord(int cid, string filename)
        {
            try
            {
                var contract = db.Contract.Where(q => q.ContractId == cid).FirstOrDefault();

                File.WriteAllBytes(filename, Resources.contract);

                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();

                Document document = app.Documents.Open(filename);
                app.Visible = false;
                document.Activate();

                ReplaceBookmarkText(document, "apartment", contract.Apartment.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "neighborhood", contract.Neighborhood.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "street", contract.Street.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "realtytype", contract.RealtyType.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "landlordfullname", contract.LandlordFullName.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "landlordcitizenshipid", contract.LandlordCitizenshipId.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "landlordaddress", contract.LandlordAddress.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "rentalmoneyinmonth", contract.RentMoneyInMonth.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "rentalmoneyinyear", contract.RentMoneyTotal.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "paymenttype", contract.PaymentType.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "tenancy", contract.Tenancy.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "startingdate", contract.StartingDate.ToShortDateString());
                ReplaceBookmarkText(document, "currentsituation", contract.CurrentSituationOfRealEstate.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "aimofrent", contract.AimOfRent.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "specialconditions", contract.ContractSpecialConditions.CapitalizeFirstLetter());
                ReplaceBookmarkText(document, "inventorylist", contract.InventoryList.CapitalizeFirstLetter());


                Table myTable = document.Tables[1];

                var kontrat = db.Contract.Where(q => q.ContractId == contract.ContractId).FirstOrDefault();

                var tenants = kontrat.ContractParties.Where(q => q.PersonType == "Kiracı").ToList();

                if (tenants.Count >= 1)
                {
                    myTable.Cell(8, 2).Range.Text = tenants[0].Person.FullName;
                    myTable.Cell(9, 2).Range.Text = tenants[0].Person.CitizenshipId;
                }
                if (tenants.Count >= 2)
                {
                    myTable.Cell(8, 3).Range.Text = tenants[1].Person.FullName;
                    myTable.Cell(9, 3).Range.Text = tenants[1].Person.CitizenshipId;
                }
                if (tenants.Count >= 3)
                {
                    myTable.Cell(10, 2).Range.Text = tenants[2].Person.FullName;
                    myTable.Cell(11, 2).Range.Text = tenants[2].Person.CitizenshipId;
                }
                if (tenants.Count >= 3)
                {
                    myTable.Cell(10, 3).Range.Text = tenants[3].Person.FullName;
                    myTable.Cell(11, 3).Range.Text = tenants[3].Person.CitizenshipId;
                }

                document.Save();
                app.Quit();
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void FrmContractWriter_Shown(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.FileName = "Sözleşme.doc";
                saveDialog.Filter = "Word dosyaları (*.doc)|*.doc|Tüm dosyalar (*.*)|*.*";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToWord(this.contractId, saveDialog.FileName);
                    this.Close();
                }
            }
        }
    }
}
