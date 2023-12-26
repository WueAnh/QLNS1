using QLNS1.DataSetTableAdapters;

namespace QLNS1
{
    partial class ViewRPDSThaiSan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet = new QLNS1.DataSet();
            this.DSThaiSanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSThaiSanTableAdapter = new QLNS1.DataSetTableAdapters.DSTHAISANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSThaiSanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 18;
            reportDataSource1.Name = "DataSetDSThaiSan";
            reportDataSource1.Value = this.DSThaiSanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS1.RPDSThaiSan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1144, 672);
            this.reportViewer1.TabIndex = 3;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DSThaiSanBindingSource
            // 
            this.DSThaiSanBindingSource.DataMember = "DSThaiSan";
            this.DSThaiSanBindingSource.DataSource = this.DataSet;
            // 
            // DSThaiSanTableAdapter
            // 
            this.DSThaiSanTableAdapter.ClearBeforeFill = true;
            // 
            // ViewRPDSThaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 672);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ViewRPDSThaiSan";
            this.Text = "ViewRPDSThaiSan";
            this.Load += new System.EventHandler(this.ViewRPDSThaiSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSThaiSanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DSThaiSanBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.DSTHAISANTableAdapter DSThaiSanTableAdapter;
    }
}