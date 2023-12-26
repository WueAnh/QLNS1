using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLNS1
{
    public partial class QLChamCong : Form
    {
        BUS_QLChamCong busQlChamCong = new BUS_QLChamCong();
        public QLChamCong()
        {
            InitializeComponent();
        }
    
        private void dateNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busQlChamCong.GetFindTenNV(cbMaNV.Text, cbTenNV.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text);
        }

        private void dateNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busQlChamCong.GetFindTenNV(cbMaNV.Text, cbTenNV.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text);
        }

        private void QLChamCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBoPhanToPhongBang.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSetBoPhanToPhongBang.NhanVien);

        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busQlChamCong.GetFindTenNV(cbMaNV.Text, cbTenNV.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text);
        }

        private void cbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busQlChamCong.GetFindTenNV(cbMaNV.Text, cbTenNV.Text, dateNgayBatDau.Text, dateNgayKetThuc.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
