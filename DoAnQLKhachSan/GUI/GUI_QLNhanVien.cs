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
using BLL_DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace GUI
{
    public partial class GUI_QLNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_DAL_NhanVien nhanviens = new BLL_DAL_NhanVien();
        bool isSua = false;
        bool isThem = false;
        string sourcePath = null;
        bool changeImg = false;
        public GUI_QLNhanVien()
        {
            InitializeComponent();
        }

        public void loadDGVNhanVien()
        {
            dGVNhanVien.DataSource = nhanviens.loadDataNhanVien("");
            dGVNhanVien.Columns["Hinh"].Visible = false;
        }

        public void refesh()
        {
            txtHoTen.Clear();
            txtLuong.Clear();
            txtChucVu.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtCCCD.Clear();
            btnFile.Enabled = true;
            dTPNgaySinh.Value = DateTime.Now;
            cboGioiTinh.SelectedIndex = -1;
            cboTinhTrang.SelectedIndex = -1;
            dTPNgayVaoLam.Value = DateTime.Now;
            pictureBox1.Image = null;
        }

        public void txtReadOnly(bool e)
        {
            txtHoTen.ReadOnly = e;
            txtLuong.ReadOnly = e;
            txtChucVu.ReadOnly = e;
            txtDienThoai.ReadOnly = e;
            txtDiaChi.ReadOnly = e;
            txtCCCD.ReadOnly = e;
        }
        public void btnEnable(bool e)
        {
            btnFile.Enabled = e;
            dTPNgaySinh.Enabled = e;
            cboGioiTinh.Enabled = e;
            cboTinhTrang.Enabled = e;
            dTPNgayVaoLam.Enabled = e;
        }

        private void GUI_QLNhanVien_Load(object sender, EventArgs e)
        {
            loadDGVNhanVien();
            btnEnable(false);
            txtReadOnly(true);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void dGVNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isSua = false;
                isThem = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnEnable(false);
                txtReadOnly(true);

                txtHoTen.Text = dGVNhanVien.Rows[e.RowIndex].Cells["HoTenNV"].Value.ToString();
                txtLuong.Text = dGVNhanVien.Rows[e.RowIndex].Cells["Luong"].Value.ToString();
                cboGioiTinh.Text = dGVNhanVien.Rows[e.RowIndex].Cells["Phai"].Value.ToString();
                txtChucVu.Text = dGVNhanVien.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();
                txtDiaChi.Text = dGVNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                cboTinhTrang.Text = dGVNhanVien.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
                txtDienThoai.Text = dGVNhanVien.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
                txtCCCD.Text = dGVNhanVien.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
                dTPNgaySinh.Value = (DateTime)dGVNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value;
                dTPNgayVaoLam.Value = (DateTime)dGVNhanVien.Rows[e.RowIndex].Cells["NgayVaoLam"].Value;
                pictureBox1.Image = Image.FromFile("..//..//Resources//" + dGVNhanVien.Rows[e.RowIndex].Cells["Hinh"].Value.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isSua)
            {
                if (dGVNhanVien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NhanVien nv = new NhanVien();
                nv.MaNV = (int)dGVNhanVien.CurrentRow.Cells["MaNV"].Value;
                nv.HoTenNV = txtHoTen.Text;
                nv.Phai = cboGioiTinh.Text;
                nv.ChucVu = txtChucVu.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.TinhTrang = cboTinhTrang.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.CCCD = txtCCCD.Text;
                nv.Luong = Int32.Parse(txtLuong.Text);
                nv.NgaySinh = dTPNgaySinh.Value;
                nv.NgayVaoLam = dTPNgayVaoLam.Value;
                
                if (changeImg)
                {
                    nv.Hinh = lblHinh.Text;
                    File.Copy(sourcePath, Path.Combine("..//..//Resources", lblHinh.Text));
                }
                if (nhanviens.updateNhanVien(nv))
                {
                    loadDGVNhanVien();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSua = false;
                changeImg = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnEnable(false);
                txtReadOnly(true);
            }
            if (isThem)
            {
                if (txtHoTen.Text==string.Empty || txtChucVu.Text==string.Empty || txtLuong.Text == string.Empty || txtDienThoai.Text == string.Empty || txtCCCD.Text== string.Empty || txtDiaChi.Text==string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                if (!changeImg)
                {
                    MessageBox.Show("Vui lòng chọn ảnh nhân viên!");
                    return;
                }
                
                NhanVien nv = new NhanVien();
                //nv.MaNV = (int)dGVNhanVien.CurrentRow.Cells["MaNV"].Value;
                nv.HoTenNV = txtHoTen.Text;
                nv.Phai = cboGioiTinh.Text;
                nv.ChucVu = txtChucVu.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.TinhTrang = cboTinhTrang.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.CCCD = txtCCCD.Text;
                nv.Luong = Int32.Parse(txtLuong.Text);
                nv.NgaySinh = dTPNgaySinh.Value;
                nv.NgayVaoLam = dTPNgayVaoLam.Value;
                nv.Hinh = lblHinh.Text;
                File.Copy(sourcePath, Path.Combine("..//..//Resources", lblHinh.Text));
                if (nhanviens.themNhanVien(nv))
                {
                    loadDGVNhanVien();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isThem = false;
                changeImg = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnEnable(false);
                txtReadOnly(true);
            }

        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            int maxlenght = 10;
            if (txtDienThoai.Text.Length > maxlenght)
            {
                txtDienThoai.Text = txtDienThoai.Text.Substring(0, maxlenght);
                txtDienThoai.SelectionStart = maxlenght;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            isThem = true;
            btnEnable(true);
            txtReadOnly(false);
            refesh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            isSua = true;
            btnEnable(true);
            txtReadOnly(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dGVNhanVien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nhanviens.xoaNhanVien(Int32.Parse(dGVNhanVien.CurrentRow.Cells["MaNV"].Value.ToString())))
                {
                    loadDGVNhanVien();
                    MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dGVNhanVien.DataSource = nhanviens.loadDataNhanVien(txtTimKiem.Text);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sourcePath = openFileDialog1.FileName;
                    string fileName = Path.GetFileName(openFileDialog1.FileName);
                    lblHinh.Text = fileName;
                    pictureBox1.Image = Image.FromFile(sourcePath);
                    changeImg = true;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi tải file!", "Thông báo");
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
    }
}
