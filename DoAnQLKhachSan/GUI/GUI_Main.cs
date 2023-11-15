using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public GUI_Main()
        {
            InitializeComponent();
            GUI_QLNhanVien gui = new GUI_QLNhanVien();
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
    }
}
