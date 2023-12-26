using QLNS1.DataSetTableAdapters;

namespace QLNS1
{
    partial class ViewRPChamCongBP
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
            this.ChamCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new QLNS1.DataSet();
            this.BoPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BoPhanTableAdapter = new QLNS1.DataSetTableAdapters.BOPHANTableAdapter();
            this.ChamCongTableAdapter = new QLNS1.DataSetTableAdapters.CHAMCONGTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ChamCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoPhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChamCongBindingSource
            // 
            this.ChamCongBindingSource.DataMember = "ChamCong";
            this.ChamCongBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BoPhanBindingSource
            // 
            this.BoPhanBindingSource.DataMember = "BoPhan";
            this.BoPhanBindingSource.DataSource = this.DataSet;
            // 
            // BoPhanTableAdapter
            // 
            this.BoPhanTableAdapter.ClearBeforeFill = true;
            // 
            // ChamCongTableAdapter
            // 
            this.ChamCongTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetChamCongBP";
            reportDataSource1.Value = this.ChamCongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS1.RPChamCongBP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1008, 496);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // ViewRPChamCongBP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 496);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ViewRPChamCongBP";
            this.Text = "ViewRPChamCongBP";
            this.Load += new System.EventHandler(this.ViewRPChamCongBP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChamCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoPhanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource BoPhanBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.BOPHANTableAdapter BoPhanTableAdapter;
        private System.Windows.Forms.BindingSource ChamCongBindingSource;
        private DataSetTableAdapters.CHAMCONGTableAdapter ChamCongTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}