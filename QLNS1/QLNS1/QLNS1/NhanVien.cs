using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using DTO;
using System.Text.RegularExpressions;

namespace QLNS1
{
    public partial class NhanVien : Form
    {
        private DTO_Accounts loginAccount;
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        BUS_Luong busLuong = new BUS_Luong();
        public NhanVien(DTO_Accounts acc)
        {
            this.LoginAccount = acc;
            InitializeComponent();
        }
        public DTO_Accounts LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        private void NhanVienn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.dataSet.PHONGBAN);
            // TODO: This line of code loads data into the 'dataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.dataSet.ACCOUNT);
            // TODO: This line of code loads data into the 'dataSet.Account' table. You can move, or remove it, as needed.
            this.boPhanTableAdapter.Fill(this.dataSet.BOPHAN);
            dataGridView1.DataSource = busNhanVien.GetAllNhanVien();
            cbhientrang.SelectedIndex = 0;
            cbgioitinh.SelectedIndex = 0;
        }
        public void SetTextbox(string a)
        {
            cbTaiKhoan.Text = a;
        }
        bool CheckDuLieuHopLe()
        {
            ////////////-- Xử lý kiểm tra điều kiện phải nhập đủ thông tin của Nhân Viên
            if (txtmanv.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập mã Nhân Viên", "Thông báo !!");
                txtmanv.Focus();// Đưa con trỏ chuột vào chỗ nhập mã nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập mã
            }
            if (txttennv.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập tên Nhân Viên", "Thông báo !!");
                txttennv.Focus();// Đưa con trỏ chuột vào chỗ nhập tên nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập tên
            }
            if (cbgioitinh.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập giới tính", "Thông báo !!");
                cbgioitinh.Focus();// Đưa con trỏ chuột vào chỗ nhập giới tính nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập giới tính
            }
            if (dtngaysinh.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập ngày sinh nhân viên", "Thông báo !!");
                dtngaysinh.Focus();// Đưa con trỏ chuột vào chỗ nhập ngày sinh nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập ngày sinh
            }
            if (txtsdt.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập sdt Nhân Viên", "Thông báo !!");
                txtsdt.Focus();// Đưa con trỏ chuột vào chỗ nhập sdt nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập sdt
            }
            if (txtdiachi.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập địa chỉ Nhân Viên", "Thông báo !!");
                txtdiachi.Focus();// Đưa con trỏ chuột vào chỗ nhập địa chỉ nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập địa chỉ
            }
            if (txtcmnd.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập cmnd Nhân Viên", "Thông báo !!");
                txtcmnd.Focus();// Đưa con trỏ chuột vào chỗ nhập cmnd nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập cmnd
            }
            if (txtchucvu.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập chức vụ Nhân Viên", "Thông báo !!");
                txtchucvu.Focus();// Đưa con trỏ chuột vào chỗ nhập chức vụ nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập chức vụ
            }
            if (cbhientrang.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập tình trạng Nhân Viên", "Thông báo !!");
                cbhientrang.Focus();// Đưa con trỏ chuột vào chỗ nhập tình trạng nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập tình trạng
            }
            if (dtngayvaolam.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập ngày vào làm Nhân Viên", "Thông báo !!");
                dtngayvaolam.Focus();// Đưa con trỏ chuột vào chỗ nhập ngày vào làm nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập ngày vào làm
            }
            if (cbTaiKhoan.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập user name Nhân Viên", "Thông báo !!");
                cbTaiKhoan.Focus();// Đưa con trỏ chuột vào chỗ nhập mã nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập mã
            }
            if (cbmaphongban.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập mã phòng ban Nhân Viên", "Thông báo !!");
                cbmaphongban.Focus();// Đưa con trỏ chuột vào chỗ nhập mã phòng ban nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập mã
            }
            if (cbmabophan.Text == "")// chưa nhập dữ liệu
            {
                MessageBox.Show("Chưa nhập mã bộ phận Nhân Viên", "Thông báo !!");
                cbmabophan.Focus();// Đưa con trỏ chuột vào chỗ nhập mã nhân viên
                return false;//Không thực hiện các lệnh sau return nếu chưa nhập mã
            }


            // xử lý sdt và cmnd nếu ko phải số 

            if (!IsNumber(txtsdt.Text))
            {
                MessageBox.Show("số điện thoại không Phải là số, vui lòng nhập lại!", "Thông báo !!");
                txtsdt.Clear();
                return false;
            }
            // xử lý sdt và cmnd nếu ko phải số
            if (!IsNumber(txtcmnd.Text))
            {
                MessageBox.Show("chứng minh nhân dân không Phải là số, vui lòng nhập lại!", "Thông báo !!");
                txtcmnd.Clear();
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (CheckDuLieuHopLe())
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtmanv.Text, txttennv.Text, cbgioitinh.Text, dtngaysinh.Value.ToString("MM/dd/yyyy"), txtquequan.Text, txtsdt.Text, txtdiachi.Text, txtcmnd.Text, txtemail.Text, txttrinhdohcvan.Text, txtchuyennganh.Text, txtchucvu.Text, cbhientrang.Text, dtngayvaolam.Value.ToString("MM/dd/yyyy"), cbTaiKhoan.Text, cbmaphongban.Text, cbmabophan.Text);
                if (busNhanVien.CheckMaNV(txtmanv.Text))
                {
                    MessageBox.Show($"Mã nhân viên {txtmanv.Text} đã tồn tại", "Thông báo !!");

                }
                else
                {
                    if (busNhanVien.CheckMaNVByUserName(cbTaiKhoan.Text))
                    {
                        MessageBox.Show($"Tài khoản {cbTaiKhoan.Text} đã tồn tại thông tin nhân viên", "Thông báo !!");
                        return;
                    }
                    if (busNhanVien.InsertNhanVien(nv) && busLuong.InsertLuong(txttennv.Text, txtmanv.Text, txtchucvu.Text))
                    {
                        MessageBox.Show($"Thêm nhân viên {txttennv.Text} thành công", "Thông báo !!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Nhân Viên thất bại", "Thông báo !!");
                    }
                    dataGridView1.DataSource = busNhanVien.GetAllNhanVien();

                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (CheckDuLieuHopLe())
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtmanv.Text, txttennv.Text, cbgioitinh.Text, dtngaysinh.Value.ToString("MM/dd/yyyy"), txtquequan.Text, txtsdt.Text, txtdiachi.Text, txtcmnd.Text, txtemail.Text, txttrinhdohcvan.Text, txtchuyennganh.Text, txtchucvu.Text, cbhientrang.Text, dtngayvaolam.Value.ToString("MM/dd/yyyy"), cbTaiKhoan.Text, cbmaphongban.Text, cbmabophan.Text);
                if (!busNhanVien.CheckMaNV(txtmanv.Text))

                {
                    MessageBox.Show($"Mã nhân viên {txtmanv.Text} không tồn tại", "Thông báo !!");
                }
                else
                {
                    if (busNhanVien.UpdateNhanVien(nv))
                    {
                        MessageBox.Show($"Sửa Nhân Viên {txttennv.Text} Thành Công", "Thông báo !!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa Nhân Viên Thất Bại", "Thông báo !!");
                    }
                    dataGridView1.DataSource = busNhanVien.GetAllNhanVien();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maNV = txtmanv.Text;
            string tenNV = txttennv.Text;
            if (!busNhanVien.CheckMaNV(maNV))
            {
                MessageBox.Show($"Mã nhân viên {maNV} không tồn tại để có thể xóa", "Thông báo !!");
            }
            else
            {
                if (busNhanVien.DeleteNhanVien(maNV))
                {
                    MessageBox.Show($"Xóa Nhân Viên {tenNV} Thành Công", "Thông báo !!");
                }
                else
                {
                    MessageBox.Show("Xóa Nhân Viên Thất Bại", "Thông báo !!");
                }
                dataGridView1.DataSource = busNhanVien.GetAllNhanVien();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            txtmanv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttennv.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbgioitinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtngaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtquequan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtcmnd.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txttrinhdohcvan.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtchuyennganh.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtchucvu.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            cbhientrang.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            dtngayvaolam.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            cbTaiKhoan.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            cbmaphongban.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            cbmabophan.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dataGridView1_CellContentClick(sender, e);
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[0-9]\d*\.?[0]*$");
            return regex.IsMatch(pText);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Thông báo !!", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
