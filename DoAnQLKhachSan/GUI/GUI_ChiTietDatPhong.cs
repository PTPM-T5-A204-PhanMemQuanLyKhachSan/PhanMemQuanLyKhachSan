using BLL_DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
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
    public partial class GUI_ChiTietDatPhong : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler FormClosedEvent;
        public Phong p = new Phong();
        BLL_DAL_Phong phongs = new BLL_DAL_Phong();
        BLL_DAL_DichVu dichvus = new BLL_DAL_DichVu();
        BLL_DAL_KhachHang khs = new BLL_DAL_KhachHang();
        BLL_DAL_ChiTietDichVu ctdvs = new BLL_DAL_ChiTietDichVu();
        BLL_DAL_DatPhong datphongs = new BLL_DAL_DatPhong();
        BLL_DAL_HoaDon hoadons = new BLL_DAL_HoaDon();
        DatPhong dp;
        KhachHang kh;
        public GUI_ChiTietDatPhong()
        {
            InitializeComponent();
        }

        private void ChiTietDatPhong_Load(object sender, EventArgs e)
        {
            txtTenPhong.Text = p.TenPhong;
            txtGiaPhong.Text = txtTamTinh.Text = p.GiaPhong.ToString();

            cbxDichVu.DataSource = dichvus.loadDichVu();
            cbxDichVu.DisplayMember = "TenDV";
            cbxDichVu.ValueMember = "MaDV";

            cbxKH.DataSource = khs.LoadKhachHang("");
            cbxKH.DisplayMember = "HoTenKH";
            cbxKH.ValueMember = "MaKH";
            cbxKH.SelectedIndex = -1;

            if (p.TrangThai == "Trống")
            {
                dateCheckIn.MinDate = dateCheckOut.MinDate = DateTime.Today;
                dp = datphongs.layDPTheoTrangThai("Rỗng");
                if (dp == null)
                {
                    dp = new DatPhong();
                    dp.TrangThai = "Rỗng";
                    datphongs.themDatPhong(dp);
                    dp = datphongs.layDPTheoTrangThai("Rỗng");
                }
            }
            else
            {
                dp = datphongs.layPhieuDatPhongTheoPhong(p.MaPhong);
                dateCheckIn.Value = dp.CheckIn.Value;
                dateCheckOut.Value = dp.CheckOut.Value;
                txtTamTinh.Text = dp.TongTien.ToString();

                kh = khs.layKHTheoId((int)dp.MaKH);
                txtHoTenKH.Text = kh.HoTenKH;
                txtCCCD.Text = kh.CCCD;
                txtDiaChi.Text = kh.DiaChi;
                txtPhone.Text = kh.DienThoai;

                loadDGVDichVu();
            }

            if (p.TrangThai == "Đã đặt")
            {
                cbxKH.Enabled = false;
                btnTaoKH.Enabled = false;
                btnDatPhong.Enabled = false;
            }

            if (p.TrangThai == "Đã thuê")
            {
                cbxKH.Enabled = false;
                btnTaoKH.Enabled = false;
                btnNhanPhong.Visible = false;
                btnDatPhong.Text = "Lưu";
                btnDatPhong.Enabled = true;
            }
            txtReadOnly(false);
        }

        public void txtReadOnly(bool e)
        {
            txtCCCD.ReadOnly = !e;
            txtDiaChi.ReadOnly = !e;
            txtHoTenKH.ReadOnly = !e;
            txtPhone.ReadOnly = !e;
        }

        private void btnTaoKH_Click(object sender, EventArgs e)
        {
            txtReadOnly(true);
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtHoTenKH.Clear();
            txtPhone.Clear();
            cbxKH.Text = "";
            btnTaoKH.Enabled = false;
            txtHoTenKH.Focus();
        }

        private void cbxKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTaoKH.Enabled = true;
            txtReadOnly(false);

            if (cbxKH.SelectedValue != null)
            {
                if (cbxKH.SelectedValue.ToString().All(char.IsDigit))
                {
                    KhachHang kh = khs.layKHTheoId((int)cbxKH.SelectedValue);

                    txtCCCD.Text = kh.CCCD;
                    txtDiaChi.Text = kh.DiaChi;
                    txtHoTenKH.Text = kh.HoTenKH;
                    txtPhone.Text = kh.DienThoai;
                }
            }
        }

        public void XuLyDatPhong()
        {
            if (cbxKH.SelectedValue != null)
            {
                kh = khs.layKHTheoId((int)cbxKH.SelectedValue);
            }
            else
            {
                kh = new KhachHang();
                kh.HoTenKH = txtHoTenKH.Text;
                kh.CCCD = txtCCCD.Text;
                kh.DienThoai = txtPhone.Text;
                kh.DiaChi = txtDiaChi.Text;
                khs.themKhachHang(kh);
            }

            HoaDon hd = new HoaDon();
            hoadons.themHoaDon(hd);

            dp.CheckIn = dateCheckIn.Value; dp.CheckOut = dateCheckOut.Value;
            dp.TongTien = int.Parse(txtTamTinh.Text);
            dp.MaKH = kh.MaKH;
            dp.MaPhong = p.MaPhong;
            dp.MaHD = hd.MaHD;
            dp.TrangThai = "Chưa thanh toán";
            datphongs.capNhatDatPhong(dp);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            
            if (btnDatPhong.Text == "Lưu")
            {
                dp.CheckIn = dateCheckIn.Value; dp.CheckOut = dateCheckOut.Value;
                dp.TongTien = int.Parse(txtTamTinh.Text);
                dp.TrangThai = "Chưa thanh toán";
                datphongs.capNhatDatPhong(dp);
                this.Close();
            }
            else
            {
                XuLyDatPhong();

                p.TrangThai = "Đã đặt";
                phongs.suaPhong(p);
                this.Close();
            }

        }

        private void ChiTietDatPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            XuLyDatPhong();

            p.TrangThai = "Đã thuê";
            phongs.suaPhong(p);
            this.Close();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            
            if (txtSoLg.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.Parse(txtSoLg.Text) < 1)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChiTietDichVu ctdv = ctdvs.layCTDVByKey(dp.MaDP, (int)cbxDichVu.SelectedValue);
            if (ctdv == null)
            {
                ctdv = new ChiTietDichVu();
                ctdv.MaDP = dp.MaDP;
                ctdv.MaDV = (int)cbxDichVu.SelectedValue;
                ctdv.SoLuong = int.Parse(txtSoLg.Text);
                ctdvs.themCTDV(ctdv);
            }
            else
            {
                ctdv.SoLuong += int.Parse(txtSoLg.Text);
                ctdvs.suaCTDV(ctdv);
            }
            loadDGVDichVu();
        }

        private void loadDGVDichVu()
        {
            List<Object> l = ctdvs.layDichVuTheoId(dp.MaDP);
            dgvDichVu.DataSource = l;
            if (l.Count() > 0)
                dgvDichVu.Columns["MaDV"].Visible = false;
            loadTamTinh();
        }

        private void dateCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dateCheckOut.MinDate = dateCheckIn.Value;
            loadTamTinh();
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ctdvs.xoaCTDV(dp.MaDP, (int)dgvDichVu.CurrentRow.Cells["MaDV"].Value);

            loadDGVDichVu();
        }

        private void txtSoLg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GUI_ChiTietDatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dp.TrangThai=="Rỗng")
            {
                ctdvs.xoaAllCTDV(dp.MaDP);
            }
        }

        public void loadTamTinh()
        {
            int soNgay = (dateCheckOut.Value - dateCheckIn.Value).Days + 1;
            int tamtinh = soNgay * int.Parse(txtGiaPhong.Text);
            foreach (DataGridViewRow row in dgvDichVu.Rows)
            {
                if (!row.IsNewRow)
                {
                    tamtinh += int.Parse(row.Cells["SoLuong"].Value.ToString()) * int.Parse(row.Cells["GiaDV"].Value.ToString());
                }
            }
            txtTamTinh.Text = tamtinh.ToString();
        }

        private void dateCheckOut_ValueChanged(object sender, EventArgs e)
        {
            loadTamTinh();
        }
    }
}