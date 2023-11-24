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
    public partial class GUI_ChuyenPhong : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler FormClosedEvent;
        public DatPhong dp;
        BLL_DAL_DatPhong dps = new BLL_DAL_DatPhong();
        BLL_DAL_Phong phongs = new BLL_DAL_Phong();
        BLL_DAL_ChiTietDichVu ctdvs = new BLL_DAL_ChiTietDichVu();
        GUI_Main objMain = (GUI_Main)Application.OpenForms["GUI_Main"];
        
        public GUI_ChuyenPhong()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            if(cboPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng muốn chuyển đến!", "Thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Phong phonghientai = phongs.layPhongTheoKey((int)dp.MaPhong);
            phonghientai.TrangThai = "Trống";
            phongs.suaPhong(phonghientai);

            Phong phongchuyenden = phongs.layPhongTheoKey((int)cboPhong.SelectedValue);
            phongchuyenden.TrangThai = dp.Phong.TrangThai;
            phongs.suaPhong(phongchuyenden);


            int soNgay = (dp.CheckOut.Value - dp.CheckIn.Value).Days + 1;
            int TongTien = (int)dp.TongTien - (soNgay*(int)phonghientai.GiaPhong);



            dp = dps.layDPTheoKey((int)dp.MaDP);
            dp.MaPhong = phongchuyenden.MaPhong;
            dp.TongTien = TongTien + (soNgay * phongchuyenden.GiaPhong);
            dps.capNhatDatPhong(dp);
            objMain.loadQLDatPhong();
            MessageBox.Show("Đã chuyển " + phonghientai.TenPhong + " đến " + phongchuyenden.TenPhong, "Thông báo");
            this.Close();
        }

        private void GUI_ChuyenPhong_Load(object sender, EventArgs e)
        {
            loadDSPhongTrong();
            lbPhongHT.Text = dp.Phong.TenPhong;
        }

        public void loadDSPhongTrong()
        {
            cboPhong.DataSource = phongs.layPhongTheoTrangThai("Trống");
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
        }

        private void GUI_ChuyenPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}