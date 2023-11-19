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
        public Phong p = new Phong();
        BLL_DAL_Phong phongs = new BLL_DAL_Phong();
        BLL_DAL_DichVu dichvus = new BLL_DAL_DichVu();
        BLL_DAL_KhachHang khs = new BLL_DAL_KhachHang();
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

            txtReadOnly(false);
        }

        public void txtReadOnly(bool e)
        {
            txtCCCD.ReadOnly = !e;
            txtEmail.ReadOnly = !e;
            txtHoTenKH.ReadOnly = !e;
            txtPhone.ReadOnly = !e;

            txtCCCD.Clear();
            txtEmail.Clear();
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
                    txtEmail.Text = kh.Email;
                    txtHoTenKH.Text = kh.HoTenKH;
                    txtPhone.Text = kh.Phone;
                }
            }
            

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            p.TrangThai = "Có khách";
            phongs.suaPhong(p);
            this.Close();
        }

        private void ChiTietDatPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}