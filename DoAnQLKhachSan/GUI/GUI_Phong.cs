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
    public partial class GUI_Phong : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler ChiTietDatPhongClosed;
        public Phong p = new Phong();
        public GUI_Phong()
        {
            InitializeComponent();
            btnPhong.Click += BtnPhong_Click;
            
        }

        private void BtnPhong_Click(object sender, EventArgs e)
        {
            ChiTietDatPhong frm = new ChiTietDatPhong();
            frm.p = p;
            frm.FormClosedEvent += Frm_FormClosedEvent;
            frm.ShowDialog();
        }

        private void Frm_FormClosedEvent(object sender, EventArgs e)
        {
            ChiTietDatPhongClosed?.Invoke(this, EventArgs.Empty);
        }

        private void GUI_Phong_Load(object sender, EventArgs e)
        {
            if (p.TrangThai == "Trống")
            {
                btnPhong.BackColor = SystemColors.Window;
            }
            else
            {
                btnPhong.BackColor = Color.Aquamarine;
            }
            btnPhong.Text = p.TenPhong;
        }
    }
}
