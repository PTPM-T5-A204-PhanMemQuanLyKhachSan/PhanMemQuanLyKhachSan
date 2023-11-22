using BLL_DAL;
using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.Design.MaskSettingsForm.DesignInfo.MaskManagerInfo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GUI_Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public int manv;
        public string tendn;
        BLL_DAL_QL_NguoiDungNhomNguoiDung qlndnnds = new BLL_DAL_QL_NguoiDungNhomNguoiDung();
        BLL_DAL_QL_PhanQuyen qlpqs = new BLL_DAL_QL_PhanQuyen();
        public GUI_Main()
        {
            InitializeComponent();
            
            GUI_QLDatPhong gui = new GUI_QLDatPhong();
            fluentDesignFormContainer1.Controls.Add(gui);
        }

        private void GUI_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.GUI_DangNhap.Show();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            GUI_QLPhong gui = new GUI_QLPhong();
            fluentDesignFormContainer1.Controls.Add(gui);
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            GUI_QLNhanVien gui = new GUI_QLNhanVien();
            fluentDesignFormContainer1.Controls.Add(gui);
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            GUI_QLKhachHang gui = new GUI_QLKhachHang();
            fluentDesignFormContainer1.Controls.Add(gui);
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            GUI_QLDichVu gui = new GUI_QLDichVu();
            fluentDesignFormContainer1.Controls.Add(gui);
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            GUI_ThanhToan gui = new GUI_ThanhToan();
            gui.manv = manv;
            fluentDesignFormContainer1.Controls.Add(gui);
        }

        private void GUI_Main_Load(object sender, EventArgs e)
        {
            List<int> nhomND = qlndnnds.GetMaNhomNguoiDung(tendn);
            foreach (int n in nhomND)
            {
                List<QL_PhanQuyen> dsQuyen = qlpqs.GetMaManHinh(n);
                foreach (QL_PhanQuyen q in dsQuyen)
                {
                    FindMenuPhanQuyen(this.accordionControl1.Elements, q.MaManHinh, (bool)q.CoQuyen);
                }
            }
        }

        private void FindMenuPhanQuyen(AccordionControlElementCollection elements, int maManHinh, bool coQuyen)
        {
            foreach (AccordionControlElement e in elements)
            {
                if (e.Style == ElementStyle.Group)
                {
                    FindMenuPhanQuyen(e.Elements, maManHinh, coQuyen);
                    e.Enabled = CheckAllMenuChildVisible(e.Elements);
                    e.Visible = e.Enabled;
                }
                else if (int.Parse(e.Tag.ToString()) == maManHinh)
                {
                    e.Enabled = coQuyen;
                    e.Visible = coQuyen;
                }
            }
        }

        private bool CheckAllMenuChildVisible(AccordionControlElementCollection elements)
        {
            foreach (AccordionControlElement e in elements)
            {
                if (e.Style == ElementStyle.Item && e.Enabled)
                {
                    return true;
                }
            }
            return false;
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            GUI_QLDatPhong gui = new GUI_QLDatPhong();
            fluentDesignFormContainer1.Controls.Add(gui);
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            GUI_ThongKe gui = new GUI_ThongKe();
            fluentDesignFormContainer1.Controls.Add(gui);
        }
    }
}
