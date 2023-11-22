using BLL_DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_QLKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_DAL_KhachHang khachHangs = new BLL_DAL_KhachHang();
        bool isSua = false;
        bool isThem = false;
        public GUI_QLKhachHang()
        {
            InitializeComponent();
        }

        private void GUI_QLKhachHang_Load(object sender, EventArgs e)
        {
            loadDGVKhachHang();
            txtEnable(false);
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
        }

        public void txtEnable(bool e)
        {
            txtHoTenKH.ReadOnly = txtCCCD.ReadOnly = txtDiaChi.ReadOnly = txtSDT.ReadOnly = !e;
        }

        public void loadDGVKhachHang()
        {
            dataGridView1.DataSource = khachHangs.LoadKhachHang("");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            isThem = true;
            txtEnable(true);
            refesh();
        }

        private void refesh()
        {
            txtHoTenKH.Text = txtCCCD.Text = txtDiaChi.Text = txtSDT.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            isSua = true;
            txtEnable(true);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khachHangs.LoadKhachHang(txtTimKiem.Text);
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (khachHangs.xoaKhachHang(Int32.Parse(dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString())))
                {
                    loadDGVKhachHang();
                    refesh();
                    MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Không xóa được khách hàng vì khách hàng đã từng đặt phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTenKH.Text == string.Empty || txtCCCD.Text == string.Empty || txtDiaChi.Text == string.Empty || txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isThem)
            {
                KhachHang kh = new KhachHang();
                kh.HoTenKH = txtHoTenKH.Text;
                kh.CCCD = txtCCCD.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.DienThoai = txtSDT.Text;

                if (khachHangs.themKhachHang(kh))
                {
                    loadDGVKhachHang();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isThem = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                txtEnable(false);
            }
            if (isSua)
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                KhachHang kh = new KhachHang();
                kh.MaKH = (int)dataGridView1.CurrentRow.Cells["MaKH"].Value;
                kh.HoTenKH = txtHoTenKH.Text;
                kh.CCCD = txtCCCD.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.DienThoai = txtSDT.Text;

                if (khachHangs.suaKhachHang(kh))
                {
                    loadDGVKhachHang();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSua = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                txtEnable(false);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isSua = false;
                isThem = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                txtEnable(false);

                txtHoTenKH.Text = dataGridView1.CurrentRow.Cells["HoTenKH"].Value.ToString();
                txtCCCD.Text = dataGridView1.CurrentRow.Cells["CCCD"].Value.ToString();
                txtDiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dataGridView1.CurrentRow.Cells["DienThoai"].Value.ToString();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            int maxlenght = 10;
            if (txtSDT.Text.Length > maxlenght)
            {
                txtSDT.Text = txtSDT.Text.Substring(0, maxlenght);
                txtSDT.SelectionStart = maxlenght;
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            int maxlenght = 12;
            if (txtCCCD.Text.Length > maxlenght)
            {
                txtCCCD.Text = txtCCCD.Text.Substring(0, maxlenght);
                txtCCCD.SelectionStart = maxlenght;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
