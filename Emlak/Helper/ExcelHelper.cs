using Emlak.UI;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.Helper
{
    public class ExcelHelper : BaseForm
    {
        private PictureBox pictureBox1;

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Emlak.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ExcelHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(209, 141);
            this.Controls.Add(this.pictureBox1);
            this.IsCloseable = false;
            this.MinimizeBox = false;
            this.Name = "ExcelHelper";
            this.Text = "Excel\'e Aktar";
            this.Shown += new System.EventHandler(this.ExcelHelper_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private DataGridView dg;
        private string filename;

        public ExcelHelper(DataGridView dg, string filename)
        {
            InitializeComponent();


            this.dg = dg;
            this.filename = filename;
        }


        private void ExportToExcel(string path)
        {
            try
            {
                _Application excel = new Microsoft.Office.Interop.Excel.Application();
                _Workbook workbook = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                _Worksheet worksheet = (Worksheet)excel.ActiveSheet;
                
                excel.Visible = false;

                // datagridview copy
                Clipboard.Clear();

                dg.MultiSelect = true;
                dg.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                dg.RowHeadersVisible = false;
                dg.SelectAll();

                DataObject dataObject = dg.GetClipboardContent();
                if (dataObject != null)
                    Clipboard.SetDataObject(dataObject);

                dg.RowHeadersVisible = true;
                dg.MultiSelect = false;
                ///////////////


                Range CR = (Range)worksheet.Cells[1, 1];
                CR.Select();

                worksheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                worksheet.Columns.AutoFit();
                Microsoft.Office.Interop.Excel.Range currentCell = worksheet.Rows[1];
                currentCell.EntireRow.Font.Bold = true;


                worksheet.SaveAs(path);
                excel.Quit();
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(ex);
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        
        private void ExcelHelper_Shown(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = filename;
                saveFileDialog.Filter = "Excel dosyaları |*.xls;*.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(saveFileDialog.FileName);
                    this.Close();

                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
