using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.UI.Export.ExcelML;
using Telerik.WinControls.UI;

namespace Telerik_GridData_Export
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2017DataSet.SalesPerson' table. You can move, or remove it, as needed.
            this.salesPersonTableAdapter.Fill(this.adventureWorks2017DataSet.SalesPerson);

        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = String.Format("{0} (*{1})|*{1}", "Excel Files", ".xls");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //Create instance of the exporter.
                ExportToExcelML exporter = new ExportToExcelML(this.radGridView1);

                exporter.FileExtension = "xls";
                exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
                exporter.ExportVisualSettings = true;
                exporter.SummariesExportOption = SummariesOption.DoNotExport;
                exporter.SheetMaxRows = ExcelMaxRows._1048576;
                exporter.SheetName = "Sheet";

                exporter.ExcelCellFormatting += new Telerik.WinControls.UI.Export.ExcelML.ExcelCellFormattingEventHandler(exporter_ExcelCellFormatting);
                exporter.ExcelTableCreated += new Telerik.WinControls.UI.Export.ExcelML.ExcelTableCreatedEventHandler(exporter_ExcelTableCreated);

                exporter.RunExport(sfd.FileName);
                MessageBox.Show("Export completed");
            }
        }

        private void ExportPDFClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = String.Format("{0} (*{1})|*{1}", "PDF FIles", ".pdf");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportToPDF exporter = new ExportToPDF(this.radGridView1);
                exporter.FileExtension = "pdf";
                exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
                exporter.ExportVisualSettings = true;
                exporter.PageTitle = "My Page Title";
                exporter.SummariesExportOption = SummariesOption.DoNotExport;
                exporter.FitToPageWidth = true;
                exporter.Scale = 1.2f;
                exporter.TableBorderThickness = 1;
                exporter.PdfExportSettings.PageHeight = 210;
                exporter.PdfExportSettings.PageWidth = 297;
                exporter.PdfExportSettings.Author = "Telerik";
                exporter.HTMLCellFormatting += new
                Telerik.WinControls.UI.Export.HTML.HTMLCellFormattingEventHandler
                (exporter_HTMLCellFormatting);
                exporter.RunExport(sfd.FileName);
                MessageBox.Show("Export completed");
            }
        }

        private void ExportHTMLClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = String.Format("{0} (*{1})|*{1}",
            "HTML Files",
            ".html");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportToHTML exporter = new ExportToHTML(this.radGridView1);
                exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
                exporter.ExportVisualSettings = true;
                exporter.SummariesExportOption = SummariesOption.DoNotExport;
                exporter.TableCaption = "My Table";
                exporter.HTMLTableCaptionFormatting += new
                Telerik.WinControls.UI.Export.HTML.HTMLTableCaptionFormattingEventHandler
                (exporter_HTMLTableCaptionFormatting);
                exporter.RunExport(sfd.FileName);
                MessageBox.Show("Export completed");
            }
        }

        private void ExportCSVClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = String.Format("{0} (*{1})|*{1}",
            "CSV Files",
            ".csv");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV exporter = new ExportToCSV(this.radGridView1);
                exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
                exporter.SummariesExportOption = SummariesOption.DoNotExport;
                exporter.CSVCellFormatting += new
                Telerik.WinControls.UI.Export.CSV.CSVCellFormattingEventHandler(exporter_CSVCellFormatting);
                exporter.CSVTableCreated += new
                Telerik.WinControls.UI.Export.CSV.CSVTableCreatedEventHandler(exporter_CSVTableCreated);
                exporter.RunExport(sfd.FileName);
                MessageBox.Show("Export completed");
            }
        }

        void exporter_ExcelTableCreated(object sender, Telerik.WinControls.UI.Export.ExcelML.ExcelTableCreatedEventArgs e)
        {
            string headerText = "Custom added header text.";
            SingleStyleElement style = ((ExportToExcelML)sender).AddCustomExcelRow(e.ExcelTableElement, 50, headerText);
            style.FontStyle.Bold = true;
            style.FontStyle.Size = 18;
            style.FontStyle.Color = Color.White;
            style.InteriorStyle.Color = Color.Red;
            style.InteriorStyle.Pattern = InteriorPatternType.Solid;
            style.AlignmentElement.HorizontalAlignment = HorizontalAlignmentType.Center;
            style.AlignmentElement.VerticalAlignment = VerticalAlignmentType.Center;
        }

        void exporter_ExcelCellFormatting(object sender, Telerik.WinControls.UI.Export.ExcelML.ExcelCellFormattingEventArgs e)
        {
            if (e.GridRowInfoType == typeof(GridViewTableHeaderRowInfo))
            {
                BorderStyles headerBorder = new BorderStyles();
                headerBorder.Color = Color.Black;
                headerBorder.Weight = 2;
                headerBorder.LineStyle = LineStyle.Continuous; headerBorder.PositionType = PositionType.Bottom;
                e.ExcelStyleElement.Borders.Add(headerBorder);
            }
            else if (e.GridColumnIndex == radGridView1.Columns["SalesLastYear"].Index)
            {
                int value = Convert.ToInt32(radGridView1.Rows[e.GridRowIndex].Cells
                [e.GridColumnIndex].Value);
                if (value > 1500000)
                {
                    e.ExcelStyleElement.InteriorStyle.Color = Color.Yellow;
                    e.ExcelStyleElement.AlignmentElement.WrapText = true;
                }
            }
        }

        void exporter_HTMLCellFormatting(object sender,
            Telerik.WinControls.UI.Export.HTML.HTMLCellFormattingEventArgs e)
        {
            if (e.GridRowIndex > -1
            && e.GridColumnIndex == radGridView1.Columns["SalesLastYear"].Index)
            {
                int value = Convert.ToInt32(radGridView1.Rows[e.GridRowIndex].Cells
                [e.GridColumnIndex].Value);
                if (value > 1500000)
                {
                    //cells with value over 1500000 will be yellow
                    e.HTMLCellElement.Styles.Add("background-color", ColorTranslator.ToHtml(Color.Yellow));
                }
            }
        }

        void exporter_HTMLTableCaptionFormatting(object sender,
        Telerik.WinControls.UI.Export.HTML.HTMLTableCaptionFormattingEventArgs e)
        {
            e.TableCaptionElement.Styles.Add("background-color", ColorTranslator.ToHtml(Color.Red));
            e.TableCaptionElement.Styles.Add("font-size", "200%");
            e.TableCaptionElement.Styles.Add("color", ColorTranslator.ToHtml(Color.Yellow));
            e.TableCaptionElement.Styles.Add("font-weight", "bold");
            e.CaptionText = "My Table Caption";
        }

        void exporter_CSVTableCreated(object sender,
        Telerik.WinControls.UI.Export.CSV.CSVTableCreatedEventArgs e)
        {
            ((ExportToCSV)sender).AddCustomCSVRow(e.CSVTableElement, "MY TABLE CAPTION");
        }
        void exporter_CSVCellFormatting(object sender,
        Telerik.WinControls.UI.Export.CSV.CSVCellFormattingEventArgs e)
        {
            if (e.GridColumnIndex == 8 && e.GridRowInfoType == typeof(GridViewDataRowInfo))
            {
                e.CSVCellElement.Value = "111111";
            }
        }
    }
}
