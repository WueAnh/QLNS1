using QLNS1.DataSetTableAdapters;

namespace QLNS1
{
    partial class LuongNhanVien
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
            this.btncapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.cbTennhanvien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new QLNS1.DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVitri = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLuongCb = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbmanv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nhanVienTableAdapter = new QLNS1.DataSetTableAdapters.NHANVIENTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.btncapnhat);
            this.panel1.Controls.Add(this.cbTennhanvien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbVitri);
            this.panel1.Controls.Add(this.txtLuongCb);
            this.panel1.Controls.Add(this.cbmanv);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 613);
            this.panel1.TabIndex = 0;
            // 
            // btncapnhat
            // 
            this.btncapnhat.BorderRadius = 10;
            this.btncapnhat.CheckedState.Parent = this.btncapnhat;
            this.btncapnhat.CustomImages.Parent = this.btncapnhat;
            this.btncapnhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncapnhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncapnhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncapnhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncapnhat.DisabledState.Parent = this.btncapnhat;
            this.btncapnhat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncapnhat.ForeColor = System.Drawing.Color.Black;
            this.btncapnhat.HoverState.Parent = this.btncapnhat;
            this.btncapnhat.Location = new System.Drawing.Point(631, 422);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.ShadowDecoration.Parent = this.btncapnhat;
            this.btncapnhat.Size = new System.Drawing.Size(272, 55);
            this.btncapnhat.TabIndex = 88;
            this.btncapnhat.Text = "Cập Nhật";
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // cbTennhanvien
            // 
            this.cbTennhanvien.BackColor = System.Drawing.Color.Transparent;
            this.cbTennhanvien.DataSource = this.nhanVienBindingSource;
            this.cbTennhanvien.DisplayMember = "TenNV";
            this.cbTennhanvien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTennhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTennhanvien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTennhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTennhanvien.FocusedState.Parent = this.cbTennhanvien;
            this.cbTennhanvien.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTennhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(60)))), ((int)(((byte)(119)))));
            this.cbTennhanvien.HoverState.Parent = this.cbTennhanvien;
            this.cbTennhanvien.ItemHeight = 30;
            this.cbTennhanvien.ItemsAppearance.Parent = this.cbTennhanvien;
            this.cbTennhanvien.Location = new System.Drawing.Point(439, 177);
            this.cbTennhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.cbTennhanvien.Name = "cbTennhanvien";
            this.cbTennhanvien.ShadowDecoration.Parent = this.cbTennhanvien;
            this.cbTennhanvien.Size = new System.Drawing.Size(311, 36);
            this.cbTennhanvien.TabIndex = 86;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(800, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 76;
            this.label4.Text = "Vị Trí";
            // 
            // cbVitri
            // 
            this.cbVitri.BackColor = System.Drawing.Color.Transparent;
            this.cbVitri.DataSource = this.nhanVienBindingSource;
            this.cbVitri.DisplayMember = "ChucVu";
            this.cbVitri.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVitri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVitri.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVitri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVitri.FocusedState.Parent = this.cbVitri;
            this.cbVitri.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVitri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(60)))), ((int)(((byte)(119)))));
            this.cbVitri.HoverState.Parent = this.cbVitri;
            this.cbVitri.ItemHeight = 30;
            this.cbVitri.ItemsAppearance.Parent = this.cbVitri;
            this.cbVitri.Location = new System.Drawing.Point(952, 103);
            this.cbVitri.Margin = new System.Windows.Forms.Padding(4);
            this.cbVitri.Name = "cbVitri";
            this.cbVitri.ShadowDecoration.Parent = this.cbVitri;
            this.cbVitri.Size = new System.Drawing.Size(311, 36);
            this.cbVitri.TabIndex = 85;
            // 
            // txtLuongCb
            // 
            this.txtLuongCb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuongCb.DefaultText = "";
            this.txtLuongCb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLuongCb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLuongCb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLuongCb.DisabledState.Parent = this.txtLuongCb;
            this.txtLuongCb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLuongCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLuongCb.FocusedState.Parent = this.txtLuongCb;
            this.txtLuongCb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(60)))), ((int)(((byte)(119)))));
            this.txtLuongCb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLuongCb.HoverState.Parent = this.txtLuongCb;
            this.txtLuongCb.Location = new System.Drawing.Point(952, 186);
            this.txtLuongCb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLuongCb.Name = "txtLuongCb";
            this.txtLuongCb.PasswordChar = '\0';
            this.txtLuongCb.PlaceholderText = "";
            this.txtLuongCb.SelectedText = "";
            this.txtLuongCb.ShadowDecoration.Parent = this.txtLuongCb;
            this.txtLuongCb.Size = new System.Drawing.Size(309, 36);
            this.txtLuongCb.TabIndex = 84;
            // 
            // cbmanv
            // 
            this.cbmanv.BackColor = System.Drawing.Color.Transparent;
            this.cbmanv.DataSource = this.nhanVienBindingSource;
            this.cbmanv.DisplayMember = "MaNV";
            this.cbmanv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmanv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmanv.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmanv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmanv.FocusedState.Parent = this.cbmanv;
            this.cbmanv.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmanv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(60)))), ((int)(((byte)(119)))));
            this.cbmanv.HoverState.Parent = this.cbmanv;
            this.cbmanv.ItemHeight = 30;
            this.cbmanv.ItemsAppearance.Parent = this.cbmanv;
            this.cbmanv.Location = new System.Drawing.Point(439, 103);
            this.cbmanv.Margin = new System.Windows.Forms.Padding(4);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.ShadowDecoration.Parent = this.cbmanv;
            this.cbmanv.Size = new System.Drawing.Size(311, 36);
            this.cbmanv.TabIndex = 82;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLuong,
            this.MANV,
            this.TenNv,
            this.ChucVu,
            this.LuongCB});
            this.dataGridView1.Location = new System.Drawing.Point(245, 252);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 150);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maLuong
            // 
            this.maLuong.DataPropertyName = "MaLuong";
            this.maLuong.HeaderText = "Mã Lương";
            this.maLuong.MinimumWidth = 6;
            this.maLuong.Name = "maLuong";
            this.maLuong.Width = 125;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MaNV";
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.Width = 125;
            // 
            // TenNv
            // 
            this.TenNv.DataPropertyName = "TenNV";
            this.TenNv.HeaderText = "Tên Nhân Viên";
            this.TenNv.MinimumWidth = 6;
            this.TenNv.Name = "TenNv";
            this.TenNv.Width = 125;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 125;
            // 
            // LuongCB
            // 
            this.LuongCB.DataPropertyName = "LuongCB";
            this.LuongCB.HeaderText = "Lương Cơ Bản";
            this.LuongCB.MinimumWidth = 6;
            this.LuongCB.Name = "LuongCB";
            this.LuongCB.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 73;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 72;
            this.label1.Text = "Lương Cơ Bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(571, 47);
            this.label6.TabIndex = 71;
            this.label6.Text = "Danh Sách Bảng Lương Nhân Viên";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // LuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1415, 613);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LuongNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LuongNhanVien";
            this.Load += new System.EventHandler(this.LuongNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCB;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbmanv;
        private Guna.UI2.WinForms.Guna2TextBox txtLuongCb;
        private Guna.UI2.WinForms.Guna2ComboBox cbTennhanvien;
        private Guna.UI2.WinForms.Guna2ComboBox cbVitri;
        private Guna.UI2.WinForms.Guna2Button btncapnhat;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DataSetTableAdapters.NHANVIENTableAdapter nhanVienTableAdapter;
    }
}