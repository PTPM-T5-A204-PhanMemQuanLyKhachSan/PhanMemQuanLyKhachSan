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
    public partial class ChiTietDatPhong : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler FormClosedEvent;
        public Phong p = new Phong();
        BLL_DAL_Phong phongs = new BLL_DAL_Phong();
        BLL_DAL_DichVu dichvus = new BLL_DAL_DichVu();
        BLL_DAL_KhachHang khs = new BLL_DAL_KhachHang();
        BLL_DAL_ChiTietDichVu ctdvs = new BLL_DAL_ChiTietDichVu();
        BLL_DAL_DatPhong datphongs = new BLL_DAL_DatPhong();
        public ChiTietDatPhong()
        {
            InitializeComponent();
        }

        private void ChiTietDatPhong_Load(object sender, EventArgs e)
        {
            txtTenPhong.Text = p.TenPhong;
            txtGiaPhong.Text = p.GiaPhong.ToString();

            cbxDichVu.DataSource = dichvus.loadDichVu();
            cbxDichVu.DisplayMember = "TenDV";
            cbxDichVu.ValueMember = "MaDV";

            cbxKH.DataSource = khs.LoadKhachHang("");
            cbxKH.DisplayMember = "HoTenKH";
            cbxKH.ValueMember = "MaKH";
            cbxKH.SelectedIndex = -1;

            


            if(p.TrangThai == "Đã đặt")
            {
                btnDatPhong.Enabled = false;
            }
            if(p.TrangThai == "Đã thuê")
            {
                btnNhanPhong.Visible = false;
                btnDatPhong.Text = "Lưu";
                btnDatPhong.Enabled = true;

                DatPhong dp = datphongs.layPhieuDatPhong(1);
                dgvDichVu.DataSource = ctdvs.layDichVuTheoId(1);
                dateCheckIn.Value = dp.CheckIn.Value;
                dateCheckOut.Value = dp.CheckOut.Value;
            }

            

            txtReadOnly(false);
        }

        public void txtReadOnly(bool e)
        {
            txtCCCD.ReadOnly = !e;
            txtDiaChi.ReadOnly = !e;
            txtHoTenKH.ReadOnly = !e;
            txtPhone.ReadOnly = !e;

            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtHoTenKH.Clear();
            txtPhone.Clear();

        }

        private void btnTaoKH_Click(object sender, EventArgs e)
        {
            txtReadOnly(true);
            cbxKH.Text = "";
            btnTaoKH.Enabled = false;
            txtHoTenKH.Focus();
        }

        private void cbxKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTaoKH.Enabled = true;
            txtReadOnly(false);

            if(cbxKH.SelectedValue != null)
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

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if(btnDatPhong.Text == "Lưu")
            {

            }
            else
            {
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
            p.TrangThai = "Đã thuê";
            phongs.suaPhong(p);
            this.Close();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            
        }
    }
}