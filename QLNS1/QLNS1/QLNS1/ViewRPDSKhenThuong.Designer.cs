using QLNS1.DataSetTableAdapters;

namespace QLNS1
{
    partial class ViewRPDSKhenThuong
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
            this.DSKhenThuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSKhenThuongTableAdapter = new QLNS1.DataSetTableAdapters.DSKHENTHUONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSKhenThuongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDSKhenThuong";
            reportDataSource1.Value = this.DSKhenThuongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS1.RPDSKhenThuong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DSKhenThuongBindingSource
            // 
            this.DSKhenThuongBindingSource.DataMember = "DSKhenThuong";
            this.DSKhenThuongBindingSource.DataSource = this.DataSet;
            // 
            // DSKhenThuongTableAdapter
            // 
            this.DSKhenThuongTableAdapter.ClearBeforeFill = true;
            // 
            // ReportDSKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportDSKhenThuong";
            this.Text = "ReportDSKhenThuong";
            this.Load += new System.EventHandler(this.ReportDSKhenThuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSKhenThuongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DSKhenThuongBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.DSKHENTHUONGTableAdapter DSKhenThuongTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}