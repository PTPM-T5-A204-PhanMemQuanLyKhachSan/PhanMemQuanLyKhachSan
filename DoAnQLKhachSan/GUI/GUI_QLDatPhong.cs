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
using System.Security.Cryptography.X509Certificates;

namespace GUI
{
    public partial class GUI_QLDatPhong : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_DAL_Phong phongs = new BLL_DAL_Phong();
        BLL_DAL_LoaiPhong loaiphongs = new BLL_DAL_LoaiPhong();
        public CayQuyetDinh cqd;
        public GUI_QLDatPhong()
        {
            InitializeComponent();
            loadDanhSachPhong(phongs.LoadPhong(""));
        }

        

        private void OnChiTietDatPhongClosed(object sender, EventArgs e)
        {
            loadDanhSachPhong(phongs.LoadPhong(""));
        }
        
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if(txtSDT.TextLength > 0)
            {
                loadDanhSachPhong(phongs.layPhongTheoSDTKH(txtSDT.Text));
            }
            else
            {
                loadDanhSachPhong(phongs.LoadPhong(""));
            }
        }


        public void loadDanhSachPhong(List<Phong> dsP)
        {
            pnDSPhong.Controls.Clear();
            int x = 10;
            int y = 20;
            int count = 0;
            List<LoaiPhong> dslp = loaiphongs.LoadLoaiPhong();
            foreach (var item in dslp)
            {
                Label lb = new Label();
                lb.Text = item.TenLoai.ToString();
                lb.Location = new Point(x, y);
                lb.Font = new Font("Tahoma", 10, FontStyle.Bold);
                lb.AutoSize = true;
                pnDSPhong.Controls.Add(lb);
                List<Phong> dsp = dsP;
                y += 30;
                foreach (var p in dsp)
                {
                    if (p.MaLoai == item.MaLoai)
                    {
                        if (count > 10)
                        {
                            y += 75;
                            count = 0;
                            x = 10;
                        }
                        GUI_Phong gUI_Phong = new GUI_Phong();
                        gUI_Phong.p = p;
                        gUI_Phong.Location = new Point(x, y);
                        gUI_Phong.ChiTietDatPhongClosed += OnChiTietDatPhongClosed;
                        pnDSPhong.Controls.Add(gUI_Phong);
                        x += 110;
                        count++;
                    }


                }
                if (count != 0)
                {
                    x = 10;
                    y += 80;
                }
                count = 0;
            }
            groupBox1.Controls.Add(pnDSPhong);
        }


        private void btnTrong_Click(object sender, EventArgs e)
        {
            loadDanhSachPhong(phongs.layPhongTheoTrangThai("Trống"));
        }

        private void btnDaDat_Click(object sender, EventArgs e)
        {
            loadDanhSachPhong(phongs.layPhongTheoTrangThai("Đã đặt"));
        }

        private void btnDangThue_Click(object sender, EventArgs e)
        {
            loadDanhSachPhong(phongs.layPhongTheoTrangThai("Đã thuê"));
        }

        private void btnGoiY_Click(object sender, EventArgs e)
        {
            DuLieuAI dl = new DuLieuAI();
            dl.PhongCach = cboPhongCach.Text;
            dl.BanCong = cboBanCong.Text;
            dl.Tang = cboTang.Text;
            dl.SPA = cboSPA.Text;

            loadDanhSachPhong(phongs.layPhongTheoLoai(int.Parse(cqd.GoiY(dl))));
        }
    }
}
