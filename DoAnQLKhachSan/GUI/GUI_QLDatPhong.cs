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
            int x = 10;
            int y = 20;
            int count = 0;
            List<LoaiPhong> dslp = loaiphongs.LoadLoaiPhong();
            foreach(var item in dslp)
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
                    
                    GUI_Phong gUI_Phong = new GUI_Phong();
                    gUI_Phong.p = p;
                    gUI_Phong.Location = new Point(x, y);
                    pnDSPhong.Controls.Add(gUI_Phong);
                    x += 110;
                }
                x = 10;
                y += 100;
            }
            groupBox1.Controls.Add(pnDSPhong);
        }
    }
}
