
namespace QLNS1
{
    partial class RpBoPhan
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaBP = new System.Windows.Forms.ComboBox();
            this.boPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBoPhanToPhongBang = new QLNS1.DataSetBoPhanToPhongBang();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTenBP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.nhanVienTableAdapter = new QLNS1.DataSetBoPhanToPhongBangTableAdapters.NhanVienTableAdapter();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnIn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boPhanTableAdapter = new QLNS1.DataSetBoPhanToPhongBangTableAdapters.BoPhanTableAdapter();
            this.btnLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBoPhanToPhongBang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã BP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbbMaBP
            // 
            this.cbbMaBP.DataSource = this.boPhanBindingSource;
            this.cbbMaBP.DisplayMember = "MaBP";
            this.cbbMaBP.FormattingEnabled = true;
            this.cbbMaBP.Location = new System.Drawing.Point(183, 25);
            this.cbbMaBP.Name = "cbbMaBP";
            this.cbbMaBP.Size = new System.Drawing.Size(121, 24);
            this.cbbMaBP.TabIndex = 3;
            // 
            // boPhanBindingSource
            // 
            this.boPhanBindingSource.DataMember = "BoPhan";
            this.boPhanBindingSource.DataSource = this.dataSetBoPhanToPhongBang;
            // 
            // dataSetBoPhanToPhongBang
            // 
            this.dataSetBoPhanToPhongBang.DataSetName = "DataSetBoPhanToPhongBang";
            this.dataSetBoPhanToPhongBang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên BP";
            // 
            // cbbTenBP
            // 
            this.cbbTenBP.DataSource = this.boPhanBindingSource;
            this.cbbTenBP.DisplayMember = "TenBP";
            this.cbbTenBP.FormattingEnabled = true;
            this.cbbTenBP.Location = new System.Drawing.Point(183, 83);
            this.cbbTenBP.Name = "cbbTenBP";
            this.cbbTenBP.Size = new System.Drawing.Size(121, 24);
            this.cbbTenBP.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã NV";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(515, 29);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(121, 24);
            this.cbbMaNV.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên NV";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(515, 80);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(121, 24);
            this.cbbTenNV.TabIndex = 9;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dataSetBoPhanToPhongBang;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Đến Ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Từ Ngày";
            // 
            // dateNgayKetThuc
            // 
            this.dateNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayKetThuc.Location = new System.Drawing.Point(515, 135);
            this.dateNgayKetThuc.Name = "dateNgayKetThuc";
            this.dateNgayKetThuc.Size = new System.Drawing.Size(115, 22);
            this.dateNgayKetThuc.TabIndex = 21;
            // 
            // dateNgayBatDau
            // 
            this.dateNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayBatDau.Location = new System.Drawing.Point(183, 133);
            this.dateNgayBatDau.Name = "dateNgayBatDau";
            this.dateNgayBatDau.Size = new System.Drawing.Size(115, 22);
            this.dateNgayBatDau.TabIndex = 19;
            this.dateNgayBatDau.ValueChanged += new System.EventHandler(this.dateNgayBatDau_ValueChanged);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(762, 105);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(145, 50);
            this.btnIn.TabIndex = 24;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.MaBP,
            this.TenNV,
            this.TenBP,
            this.NgayCham});
            this.dataGridView1.Location = new System.Drawing.Point(104, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 266);
            this.dataGridView1.TabIndex = 25;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // MaBP
            // 
            this.MaBP.DataPropertyName = "MaBP";
            this.MaBP.HeaderText = "Mã Bộ Phận";
            this.MaBP.MinimumWidth = 6;
            this.MaBP.Name = "MaBP";
            this.MaBP.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 125;
            // 
            // TenBP
            // 
            this.TenBP.DataPropertyName = "TenBP";
            this.TenBP.HeaderText = "Tên Bộ Phận";
            this.TenBP.MinimumWidth = 6;
            this.TenBP.Name = "TenBP";
            this.TenBP.Width = 125;
            // 
            // NgayCham
            // 
            this.NgayCham.DataPropertyName = "NgayCham";
            this.NgayCham.HeaderText = "Ngày Chấm Công";
            this.NgayCham.MinimumWidth = 6;
            this.NgayCham.Name = "NgayCham";
            this.NgayCham.Width = 125;
            // 
            // boPhanTableAdapter
            // 
            this.boPhanTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(762, 25);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(145, 50);
            this.btnLoc.TabIndex = 26;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // RpBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 583);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateNgayKetThuc);
            this.Controls.Add(this.dateNgayBatDau);
            this.Controls.Add(this.cbbTenNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbTenBP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbMaBP);
            this.Controls.Add(this.label2);
            this.Name = "RpBoPhan";
            this.Text = "RpBoPhan";
            this.Load += new System.EventHandler(this.RpBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBoPhanToPhongBang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaBP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTenBP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private DataSetBoPhanToPhongBangTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DataSetBoPhanToPhongBang dataSetBoPhanToPhongBang;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dateNgayBatDau;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource boPhanBindingSource;
        private DataSetBoPhanToPhongBangTableAdapters.BoPhanTableAdapter boPhanTableAdapter;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCham;
    }
}