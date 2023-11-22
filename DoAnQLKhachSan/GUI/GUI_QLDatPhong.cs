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
namespace GUI
{
    public partial class GUI_QLDatPhong : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_DAL_Phong phongs = new BLL_DAL_Phong();
        BLL_DAL_LoaiPhong loaiphongs = new BLL_DAL_LoaiPhong();
        public GUI_QLDatPhong()
        {
            InitializeComponent();
            loadDanhSachPhong();
        }

        public void loadDanhSachPhong()
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
                List<Phong> dsp = phongs.layPhongTheoLoai(item.MaLoai);
                y += 30;
                foreach (var p in dsp)
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
                x = 10;
                y += 80;
            }
            groupBox1.Controls.Add(pnDSPhong);
        }

        private void OnChiTietDatPhongClosed(object sender, EventArgs e)
        {
            loadDanhSachPhong();
        }




       
        
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if(txtSDT.TextLength > 0)
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
                    List<Phong> dsp = phongs.layPhongTheoSDTKH(txtSDT.Text);
                    y += 30;
                    foreach (var p in dsp)
                    {
                        if(p.MaLoai == item.MaLoai)
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
                    
                }
                groupBox1.Controls.Add(pnDSPhong);
            }
            else
            {
                loadDanhSachPhong();
            }
        }








        public void loadDSPhongTheoTrangThai(List<Phong> dsP)
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
            loadDSPhongTheoTrangThai(phongs.layPhongTheoTrangThai("Trống"));
        }

        private void btnDaDat_Click(object sender, EventArgs e)
        {
            loadDSPhongTheoTrangThai(phongs.layPhongTheoTrangThai("Đã đặt"));
        }

        private void btnDangThue_Click(object sender, EventArgs e)
        {
            loadDSPhongTheoTrangThai(phongs.layPhongTheoTrangThai("Đã thuê"));
        }
    }
}
