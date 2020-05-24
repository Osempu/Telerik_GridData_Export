namespace Telerik_GridData_Export
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.exportExcelMenu = new Telerik.WinControls.UI.CommandBarButton();
            this.exportPdfMenu = new Telerik.WinControls.UI.CommandBarButton();
            this.exportHtmlMenu = new Telerik.WinControls.UI.CommandBarButton();
            this.exportCsvMenu = new Telerik.WinControls.UI.CommandBarButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.adventureWorks2017DataSet = new Telerik_GridData_Export.AdventureWorks2017DataSet();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesPersonTableAdapter = new Telerik_GridData_Export.AdventureWorks2017DataSetTableAdapters.SalesPersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(800, 30);
            this.radCommandBar1.TabIndex = 0;
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Name = "commandBarRowElement1";
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.exportExcelMenu,
            this.exportPdfMenu,
            this.exportHtmlMenu,
            this.exportCsvMenu});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // exportExcelMenu
            // 
            this.exportExcelMenu.DisplayName = "commandBarButton1";
            this.exportExcelMenu.DrawText = true;
            this.exportExcelMenu.Image = null;
            this.exportExcelMenu.Name = "exportExcelMenu";
            this.exportExcelMenu.Text = "Export Excel";
            this.exportExcelMenu.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // exportPdfMenu
            // 
            this.exportPdfMenu.DisplayName = "commandBarButton2";
            this.exportPdfMenu.DrawText = true;
            this.exportPdfMenu.Image = null;
            this.exportPdfMenu.Name = "exportPdfMenu";
            this.exportPdfMenu.Text = "Export PDf";
            this.exportPdfMenu.Click += new System.EventHandler(this.ExportPDFClick);
            // 
            // exportHtmlMenu
            // 
            this.exportHtmlMenu.DisplayName = "commandBarButton3";
            this.exportHtmlMenu.DrawText = true;
            this.exportHtmlMenu.Image = null;
            this.exportHtmlMenu.Name = "exportHtmlMenu";
            this.exportHtmlMenu.Text = "Export HTML";
            this.exportHtmlMenu.Click += new System.EventHandler(this.ExportHTMLClick);
            // 
            // exportCsvMenu
            // 
            this.exportCsvMenu.DisplayName = "commandBarButton4";
            this.exportCsvMenu.DrawText = true;
            this.exportCsvMenu.Image = null;
            this.exportCsvMenu.Name = "exportCsvMenu";
            this.exportCsvMenu.Text = "Export CSV";
            this.exportCsvMenu.Click += new System.EventHandler(this.ExportCSVClick);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 30);
            this.radGridView1.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "BusinessEntityID";
            gridViewDecimalColumn1.HeaderText = "BusinessEntityID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.MinWidth = 6;
            gridViewDecimalColumn1.Name = "BusinessEntityID";
            gridViewDecimalColumn1.Width = 129;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "TerritoryID";
            gridViewDecimalColumn2.HeaderText = "TerritoryID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.MinWidth = 6;
            gridViewDecimalColumn2.Name = "TerritoryID";
            gridViewDecimalColumn2.Width = 88;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "SalesQuota";
            gridViewDecimalColumn3.HeaderText = "SalesQuota";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.MinWidth = 6;
            gridViewDecimalColumn3.Name = "SalesQuota";
            gridViewDecimalColumn3.Width = 129;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Bonus";
            gridViewDecimalColumn4.HeaderText = "Bonus";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.MinWidth = 6;
            gridViewDecimalColumn4.Name = "Bonus";
            gridViewDecimalColumn4.Width = 129;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "CommissionPct";
            gridViewDecimalColumn5.HeaderText = "CommissionPct";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.MinWidth = 6;
            gridViewDecimalColumn5.Name = "CommissionPct";
            gridViewDecimalColumn5.Width = 129;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "SalesYTD";
            gridViewDecimalColumn6.HeaderText = "SalesYTD";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.MinWidth = 6;
            gridViewDecimalColumn6.Name = "SalesYTD";
            gridViewDecimalColumn6.Width = 129;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "SalesLastYear";
            gridViewDecimalColumn7.HeaderText = "SalesLastYear";
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.MinWidth = 6;
            gridViewDecimalColumn7.Name = "SalesLastYear";
            gridViewDecimalColumn7.Width = 139;
            gridViewTextBoxColumn1.DataType = typeof(System.Guid);
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "rowguid";
            gridViewTextBoxColumn1.HeaderText = "rowguid";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.MinWidth = 6;
            gridViewTextBoxColumn1.Name = "rowguid";
            gridViewTextBoxColumn1.Width = 99;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "ModifiedDate";
            gridViewDateTimeColumn1.HeaderText = "ModifiedDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.MinWidth = 6;
            gridViewDateTimeColumn1.Name = "ModifiedDate";
            gridViewDateTimeColumn1.Width = 129;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewDecimalColumn7,
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.salesPersonBindingSource;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(800, 420);
            this.radGridView1.TabIndex = 1;
            // 
            // adventureWorks2017DataSet
            // 
            this.adventureWorks2017DataSet.DataSetName = "AdventureWorks2017DataSet";
            this.adventureWorks2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.adventureWorks2017DataSet;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            this.Text = "Telerik Data Export";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton exportExcelMenu;
        private Telerik.WinControls.UI.CommandBarButton exportPdfMenu;
        private Telerik.WinControls.UI.CommandBarButton exportHtmlMenu;
        private Telerik.WinControls.UI.CommandBarButton exportCsvMenu;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private AdventureWorks2017DataSet adventureWorks2017DataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private AdventureWorks2017DataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
    }
}

