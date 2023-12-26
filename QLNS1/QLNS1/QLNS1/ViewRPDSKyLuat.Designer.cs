using QLNS1.DataSetTableAdapters;

namespace QLNS1
{
    partial class ViewRPDSKyLuat
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DSKyLuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new QLNS1.DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSKyLuatTableAdapter = new QLNS1.DataSetTableAdapters.DSKYLUATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSKyLuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DSKyLuatBindingSource
            // 
            this.DSKyLuatBindingSource.DataMember = "DSKyLuat";
            this.DSKyLuatBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSetDSKyLuat";
            reportDataSource3.Value = this.DSKyLuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS1.RPDSKyLuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1152, 669);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSKyLuatTableAdapter
            // 
            this.DSKyLuatTableAdapter.ClearBeforeFill = true;
            // 
            // ViewRPDSKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 669);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ViewRPDSKyLuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewRPDSKyLuat";
            this.Load += new System.EventHandler(this.ViewRPDSKiLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSKyLuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DSKyLuatBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.DSKYLUATTableAdapter DSKyLuatTableAdapter;
    }
}