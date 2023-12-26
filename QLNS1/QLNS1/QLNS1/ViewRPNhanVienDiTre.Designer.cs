using QLNS1.DataSetTableAdapters;

namespace QLNS1
{
    partial class ViewRPNhanVienDiTre
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
            this.ChamCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChamCongTableAdapter = new QLNS1.DataSetTableAdapters.CHAMCONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamCongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNhanVienDiTre";
            reportDataSource1.Value = this.ChamCongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLNS1.RPNhanVienDiTre.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChamCongBindingSource
            // 
            this.ChamCongBindingSource.DataMember = "ChamCong";
            this.ChamCongBindingSource.DataSource = this.DataSet;
            // 
            // ChamCongTableAdapter
            // 
            this.ChamCongTableAdapter.ClearBeforeFill = true;
            // 
            // ViewRPNhanVienDiTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ViewRPNhanVienDiTre";
            this.Text = "ViewRPNhanVienDiTre";
            this.Load += new System.EventHandler(this.ViewRPNhanVienDiTre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamCongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ChamCongBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.CHAMCONGTableAdapter ChamCongTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}