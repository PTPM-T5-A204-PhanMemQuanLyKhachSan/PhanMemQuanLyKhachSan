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
    public partial class GUI_QLTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_DAL_QL_NguoiDung qlnds = new BLL_DAL_QL_NguoiDung();
        BLL_DAL_NhanVien nvs = new BLL_DAL_NhanVien();
        BLL_BAL_QL_NhomNguoiDung qlnnds = new BLL_BAL_QL_NhomNguoiDung();
        bool isThem = false, isSua = false;
        public GUI_QLTaiKhoan()
        {
            InitializeComponent();
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

                txtTenDangNhap.Text = dataGridView1.CurrentRow.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dataGridView1.CurrentRow.Cells["MatKhau"].Value.ToString();
                chkHoatDong.Checked = (bool)dataGridView1.CurrentRow.Cells["HoatDong"].Value;
                cboTenNV.SelectedValue = dataGridView1.CurrentRow.Cells["MaNV"].Value;
                cboNhomQuyen.SelectedValue = dataGridView1.CurrentRow.Cells["MaNhomNguoiDung"].Value;
            }
        }

        private void txtEnable(bool v)
        {
            txtTenDangNhap.ReadOnly = txtMatKhau.ReadOnly = !v;
            chkHoatDong.Enabled = cboTenNV.Enabled = cboNhomQuyen.Enabled = v;
        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            loadDGV("");
            loadCbo();
        }

        private void loadCbo()
        {
            cboTenNV.DataSource = nvs.loadDataNhanVien("");
            cboTenNV.ValueMember = "MaNV";
            cboTenNV.DisplayMember = "HoTenNV";

            cboNhomQuyen.DataSource = qlnnds.loadNhomQuyen();
            cboNhomQuyen.ValueMember = "MaNhomNguoiDung";
            cboNhomQuyen.DisplayMember = "TenNhom";
        }

        private void loadDGV(string s)
        {
            List<Object> l = qlnds.loadDS(s);

            if (l.Count > 0)
            {
                dataGridView1.Columns.Clear();
                DataGridViewCheckBoxColumn hoatDongColumn = new DataGridViewCheckBoxColumn();
                hoatDongColumn.DataPropertyName = "HoatDong";
                hoatDongColumn.HeaderText = "HoatDong";
                hoatDongColumn.Name = "HoatDong";
                dataGridView1.Columns.Add(hoatDongColumn);

                dataGridView1.DataSource = l;

                dataGridView1.Columns["MatKhau"].Visible = false;
                dataGridView1.Columns["MaNV"].Visible = false;
                dataGridView1.Columns["MaNhomNguoiDung"].Visible = false;
                dataGridView1.Columns["HoatDong"].DisplayIndex = dataGridView1.Columns.Count - 1;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            loadDGV(txtTimKiem.Text);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            isSua = true;
            txtEnable(true);
            txtTenDangNhap.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (qlnds.xoaTK(dataGridView1.CurrentRow.Cells["TenDangNhap"].Value.ToString()))
                {
                    loadDGV("");
                    refesh();
                    MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == string.Empty || txtMatKhau.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isThem)
            {
                QL_NguoiDung tk = new QL_NguoiDung();
                tk.TenDangNhap = txtTenDangNhap.Text;
                tk.MatKhau = txtMatKhau.Text;
                tk.HoatDong = (bool)chkHoatDong.Checked;
                tk.MaNV = (int)cboTenNV.SelectedValue;
                tk.MaNhomNguoiDung = (int)cboNhomQuyen.SelectedValue;

                if (!qlnds.ktMaNV((int)tk.MaNV))
                {
                    MessageBox.Show("Nhân viên này đã có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (qlnds.themTK(tk))
                {
                    loadDGV("");
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
                    MessageBox.Show("Vui lòng chọn tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                QL_NguoiDung tk = new QL_NguoiDung();
                tk.TenDangNhap = txtTenDangNhap.Text;
                tk.MatKhau = txtMatKhau.Text;
                tk.HoatDong = (bool)chkHoatDong.Checked;
                tk.MaNV = (int)cboTenNV.SelectedValue;
                tk.MaNhomNguoiDung = (int)cboNhomQuyen.SelectedValue;

                if (qlnds.suaTK(tk))
                {
                    loadDGV("");
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

        private void refesh()
        {
            txtTenDangNhap.Text = txtMatKhau.Text = "";
            chkHoatDong.Checked = false;
            cboTenNV.SelectedIndex = cboNhomQuyen.SelectedIndex = 0;
        }
    }
}
