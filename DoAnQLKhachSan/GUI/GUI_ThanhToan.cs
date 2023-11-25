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
    public partial class GUI_ThanhToan : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_DAL_KhachHang khs = new BLL_DAL_KhachHang();
        BLL_DAL_DatPhong dps = new BLL_DAL_DatPhong();
        BLL_DAL_ChiTietDichVu ctdvs = new BLL_DAL_ChiTietDichVu();
        BLL_DAL_Phong phongs = new BLL_DAL_Phong();
        BLL_DAL_HoaDon hoadons = new BLL_DAL_HoaDon();
        BLL_DAL_NhanVien nvs = new BLL_DAL_NhanVien();
        public int manv;
        public GUI_ThanhToan()
        {
            InitializeComponent();
        }

        private void GUI_ThanhToan_Load(object sender, EventArgs e)
        {
            loadDGVKH();
            txtNhanVien.Text = nvs.getTenNV(manv);
            txtNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void loadDGVKH()
        {
            List<Object> l = khs.loadDSKhachHangCoHD();
            dgvKH.DataSource = l;
            if (l.Count() > 0)
            {
                dgvKH.Columns["MaKH"].Visible = false;
            }
            else
            {
                dgvDP.DataSource = null;
                dgvCTDV.DataSource = null;
            }
        }

        private void dgvKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKH.CurrentRow != null)
            {
                int id = (int)dgvKH.CurrentRow.Cells["MaKH"].Value;
                loadDGVDP(id);
                int tong = 0;
                int tienphong = 0;
                foreach (DataGridViewRow row in dgvDP.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        tong += int.Parse(row.Cells["TongTien"].Value.ToString());
                        tienphong += dps.layTienPhong((int)row.Cells["MaDP"].Value);
                    }
                }
                txtTongTien.Text = tong.ToString();
                txtTienPhong.Text = tienphong.ToString();
                txtTienDichVu.Text = (tong - tienphong).ToString();
            }
        }

        private void loadDGVDP(int id)
        {
            List<Object> l = dps.layDPTheoKH(id);
            dgvDP.DataSource = l;
            if (l.Count() > 0)
            {
                dgvDP.Columns["MaDP"].Visible = false;
                dgvDP.Columns["MaPhong"].Visible = false;
            }
            else
            {
                dgvCTDV.DataSource = null;
            }
        }

        private void loadDGVCTDV(int id)
        {
            List<Object> l = ctdvs.layDichVuTheoId(id);
            dgvCTDV.DataSource = l;
            if (l.Count() > 0)
            {
                dgvCTDV.Columns["MaDV"].Visible = false;
            }
        }

        private void dgvDP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDP.CurrentRow != null)
            {
                int id = (int)dgvDP.CurrentRow.Cells["MaDP"].Value;
                loadDGVCTDV(id);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hd = new HoaDon();
                hd.NgayThanhToan = DateTime.Now;
                hd.MaNV = manv;
                hd.TongTien = int.Parse(txtTongTien.Text);
                hoadons.themHoaDon(hd);
                foreach (DataGridViewRow row in dgvDP.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DatPhong dp = dps.layDPTheoKey(int.Parse(row.Cells["MaDP"].Value.ToString()));
                        dp.TrangThai = "Đã thanh toán";
                        dp.MaHD = hd.MaHD;
                        dps.capNhatDatPhong(dp);
                        Phong p = phongs.layPhongTheoKey(int.Parse(row.Cells["MaPhong"].Value.ToString()));
                        p.TrangThai = "Trống";
                        phongs.suaPhong(p);
                    }
                }
                loadDGVKH();
                if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thanh toán thành công", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExcelExport ex = new ExcelExport();
                    string s;
                    List<Object> list = ctdvs.layDSInHD(hd.MaHD);
                    if (list == null || (list != null && list.Count == 0))
                    {
                        s = "HoaDon1";
                    }
                    else
                    {
                        s = "HoaDon2";
                    }
                    ex.ExportHoaDon(dps.layDSInHD(hd.MaHD), list, hd, ref s, true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thanh toán thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
