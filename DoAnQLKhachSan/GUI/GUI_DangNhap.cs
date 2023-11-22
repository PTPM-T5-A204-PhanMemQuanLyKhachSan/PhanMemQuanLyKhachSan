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
    public partial class GUI_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        BLL_DAL_QL_NguoiDung QL_NguoiDung;
        BLL_DAL_NhanVien nhanVien;
        CauHinh CauHinh;
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            QL_NguoiDung = new BLL_DAL_QL_NguoiDung();
            nhanVien = new BLL_DAL_NhanVien();
            CauHinh = new CauHinh();
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lblUsername.Text.ToLower());
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống " + lblPassword.Text.ToLower());
                this.txtPassword.Focus();
                return;
            }
            int kq = CauHinh.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }

        public void ProcessLogin()
        {
            String result = QL_NguoiDung.Check_User(txtUsername.Text, txtPassword.Text);
            // Wrong username or pass
            if (result == "Invalid")
            {
                MessageBox.Show("Sai " + lblUsername.Text + " Hoặc " + lblPassword.Text);
                return;
            }
            // Account had been disabled
            else if (result == "Disabled")
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            if (Program.GUI_Main == null || Program.GUI_Main.IsDisposed)
            {
                Program.GUI_Main = new GUI_Main();
                Program.GUI_Main.manv = nhanVien.getMaNV(txtUsername.Text);
                Program.GUI_Main.tendn = txtUsername.Text;
            }
            this.Visible = false;
            Program.GUI_Main.Show();
        }

        public void ProcessConfig()
        {
            Program.GUI_CauHinh = new GUI_CauHinh();
            this.Visible = false;
            Program.GUI_CauHinh.Show();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}