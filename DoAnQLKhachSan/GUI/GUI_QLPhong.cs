using BLL_DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_QLPhong : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_DAL_Phong phongs = new BLL_DAL_Phong();
        bool isSua = false;
        bool isThem = false;
        public GUI_QLPhong()
        {
            InitializeComponent();
        }

        private void GUI_QLPhong_Load(object sender, EventArgs e)
        {
            loadDGVPhong();
            txtEnable(false);
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
        }

        public void loadDGVPhong()
        {
            dataGridView1.DataSource = phongs.LoadPhong("");
        }

        public void txtEnable(bool e)
        {
            txtTenPhong.ReadOnly = txtGiaPhong.ReadOnly = !e;
            cboLoaiPhong.Enabled = cboTrangThai.Enabled = e;
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

        public void refesh()
        {
            txtTenPhong.Text = txtGiaPhong.Text = "";
            cboLoaiPhong.SelectedIndex = cboTrangThai.SelectedIndex = 0;
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
            dataGridView1.DataSource = phongs.LoadPhong(txtTimKiem.Text);
        }

        private void txtGiaPhong_KeyPress(object sender, KeyPressEventArgs e)
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
                if (phongs.xoaPhong(Int32.Parse(dataGridView1.CurrentRow.Cells["MaPhong"].Value.ToString())))
                {
                    loadDGVPhong();
                    refesh();
                    MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Không xóa được phòng vì phòng đã từng được đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenPhong.Text == string.Empty || txtGiaPhong.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isThem)
            {
                Phong phong = new Phong();
                phong.TenPhong = txtTenPhong.Text;
                phong.GiaPhong = int.Parse(txtGiaPhong.Text);
                phong.LoaiPhong = cboLoaiPhong.Text;
                phong.TrangThai = cboTrangThai.Text;

                if (phongs.themPhong(phong))
                {
                    loadDGVPhong();
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
                Phong phong = new Phong();
                phong.MaPhong = (int)dataGridView1.CurrentRow.Cells["MaPhong"].Value;
                phong.TenPhong = txtTenPhong.Text;
                phong.GiaPhong = int.Parse(txtGiaPhong.Text);
                phong.LoaiPhong = cboLoaiPhong.Text;
                phong.TrangThai = cboTrangThai.Text;

                if (phongs.suaPhong(phong))
                {
                    loadDGVPhong();
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

                txtTenPhong.Text = dataGridView1.CurrentRow.Cells["TenPhong"].Value.ToString();
                txtGiaPhong.Text = dataGridView1.CurrentRow.Cells["GiaPhong"].Value.ToString();
                cboLoaiPhong.SelectedIndex = cboLoaiPhong.FindStringExact(dataGridView1.CurrentRow.Cells["LoaiPhong"].Value.ToString());
                cboTrangThai.SelectedIndex = cboTrangThai.FindStringExact(dataGridView1.CurrentRow.Cells["TrangThai"].Value.ToString());
            }
        }
    }
}
