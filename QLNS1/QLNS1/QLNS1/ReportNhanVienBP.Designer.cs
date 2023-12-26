using QLNS1.DataSetTableAdapters;

namespace QLNS1
{
    partial class ReportNhanVienBP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoc = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbTenBP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.boPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new QLNS1.DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMaBP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boPhanTableAdapter = new QLNS1.DataSetTableAdapters.BOPHANTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cbbTenBP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbMaBP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 613);
            this.panel1.TabIndex = 0;
            // 
            // btnIn
            // 
            this.btnIn.BorderRadius = 10;
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIn.DisabledState.Parent = this.btnIn;
            this.btnIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.HoverState.Parent = this.btnIn;
            this.btnIn.Location = new System.Drawing.Point(1016, 145);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.ShadowDecoration.Parent = this.btnIn;
            this.btnIn.Size = new System.Drawing.Size(109, 55);
            this.btnIn.TabIndex = 105;
            this.btnIn.Text = "In Báo Cáo";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BorderRadius = 10;
            this.btnLoc.CheckedState.Parent = this.btnLoc;
            this.btnLoc.CustomImages.Parent = this.btnLoc;
            this.btnLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoc.DisabledState.Parent = this.btnLoc;
            this.btnLoc.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.Black;
            this.btnLoc.HoverState.Parent = this.btnLoc;
            this.btnLoc.Location = new System.Drawing.Point(850, 145);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.ShadowDecoration.Parent = this.btnLoc;
            this.btnLoc.Size = new System.Drawing.Size(109, 55);
            this.btnLoc.TabIndex = 104;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 270);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 191);
            this.dataGridView1.TabIndex = 103;
            // 
            // cbbTenBP
            // 
            this.cbbTenBP.BackColor = System.Drawing.Color.Transparent;
            this.cbbTenBP.DataSource = this.boPhanBindingSource;
            this.cbbTenBP.DisplayMember = "TenBP";
            this.cbbTenBP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenBP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTenBP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTenBP.FocusedState.Parent = this.cbbTenBP;
            this.cbbTenBP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbbTenBP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(60)))), ((int)(((byte)(119)))));
            this.cbbTenBP.HoverState.Parent = this.cbbTenBP;
            this.cbbTenBP.ItemHeight = 30;
            this.cbbTenBP.ItemsAppearance.Parent = this.cbbTenBP;
            this.cbbTenBP.Location = new System.Drawing.Point(413, 178);
            this.cbbTenBP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTenBP.Name = "cbbTenBP";
            this.cbbTenBP.ShadowDecoration.Parent = this.cbbTenBP;
            this.cbbTenBP.Size = new System.Drawing.Size(205, 36);
            this.cbbTenBP.TabIndex = 102;
            // 
            // boPhanBindingSource
            // 
            this.boPhanBindingSource.DataMember = "BoPhan";
            this.boPhanBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 101;
            this.label4.Text = "Tên Bộ Phận";
            // 
            // cbbMaBP
            // 
            this.cbbMaBP.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaBP.DataSource = this.boPhanBindingSource;
            this.cbbMaBP.DisplayMember = "MaBP";
            this.cbbMaBP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaBP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMaBP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMaBP.FocusedState.Parent = this.cbbMaBP;
            this.cbbMaBP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaBP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(60)))), ((int)(((byte)(119)))));
            this.cbbMaBP.HoverState.Parent = this.cbbMaBP;
            this.cbbMaBP.ItemHeight = 30;
            this.cbbMaBP.ItemsAppearance.Parent = this.cbbMaBP;
            this.cbbMaBP.Location = new System.Drawing.Point(413, 112);
            this.cbbMaBP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMaBP.Name = "cbbMaBP";
            this.cbbMaBP.ShadowDecoration.Parent = this.cbbMaBP;
            this.cbbMaBP.Size = new System.Drawing.Size(205, 36);
            this.cbbMaBP.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 99;
            this.label2.Text = "Mã Bộ Phận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(552, 42);
            this.label6.TabIndex = 73;
            this.label6.Text = "Danh Sách Nhân Viên Theo Bộ Phận";
            // 
            // boPhanTableAdapter
            // 
            this.boPhanTableAdapter.ClearBeforeFill = true;
            // 
            // ReportNhanVienBP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1387, 613);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportNhanVienBP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportNhanVienBPP";
            this.Load += new System.EventHandler(this.ReportNhanVienBPP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTenBP;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMaBP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private Guna.UI2.WinForms.Guna2Button btnLoc;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource boPhanBindingSource;
        private DataSetTableAdapters.BOPHANTableAdapter boPhanTableAdapter;
    }
}