using DevExpress.XtraBars;
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
        }

        private void GUI_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.GUI_DangNhap.Show();
        }
    }
}
