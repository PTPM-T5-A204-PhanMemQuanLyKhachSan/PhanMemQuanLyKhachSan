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
    public partial class GUI_CauHinh : DevExpress.XtraEditors.XtraForm
    {
        CauHinh CauHinh = new CauHinh();
        public GUI_CauHinh()
        {
            InitializeComponent();
        }

        private void cboServer_DropDown(object sender, EventArgs e)
        {
            cboServer.DataSource = CauHinh.GetServerName();
            cboServer.DisplayMember = "ServerName";
        }

        private void cboDataBase_DropDown(object sender, EventArgs e)
        {
            cboDataBase.DataSource = CauHinh.GetDBName(cboServer.Text, txtUsername.Text, txtPassword.Text);
            cboDataBase.DisplayMember = "name";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboServer.Text == string.Empty || txtUsername.Text == string.Empty || txtPassword.Text == string.Empty || cboDataBase.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            CauHinh.SaveConfig(cboServer.Text, txtUsername.Text, txtPassword.Text, cboDataBase.Text);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_CauHinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.GUI_DangNhap.Show();
        }

        private void cboServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cboServer.DroppedDown = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu.PerformClick();
            }
        }

        private void cboDataBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                cboDataBase.DroppedDown = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu.PerformClick();
            }
        }
    }
}