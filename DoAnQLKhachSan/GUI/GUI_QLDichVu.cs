using BLL_DAL;
using DevExpress.XtraEditors;
using Syncfusion.XlsIO.Implementation.XmlSerialization;
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
    public partial class GUI_QLDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        BLL_DAL_DichVu dichvus = new BLL_DAL_DichVu();
        bool isSua = false;
        bool isThem = false;
        public GUI_QLDichVu()
        {
            InitializeComponent();
        }

        private void GUI_QLDichVu_Load(object sender, EventArgs e)
        {
            loadDGVDichVu();
            txtEnable(false);
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
        }

        public void loadDGVDichVu()
        {
            dgvDV.DataSource = dichvus.loadDichVu();
        }

        public void txtEnable(bool e)
        {
            txtTenDV.ReadOnly = txtGiaDV.ReadOnly = !e;
        }

        private void refesh()
        {
            txtTenDV.Text = txtGiaDV.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            isThem = true;
            txtEnable(true);
            refesh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text == string.Empty || txtGiaDV.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isThem)
            {
                DichVu dv = new DichVu();
                dv.TenDV = txtTenDV.Text;
                dv.GiaDV = int.Parse(txtGiaDV.Text);

                if (dichvus.themDichVu(dv))
                {
                    loadDGVDichVu();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isThem = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                txtEnable(false);
            }
            if (isSua)
            {
                if (dgvDV.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DichVu dv = new DichVu();
                dv.MaDV = (int)dgvDV.CurrentRow.Cells["MaDV"].Value;
                dv.TenDV = txtTenDV.Text;
                dv.GiaDV = int.Parse(txtGiaDV.Text);

                if (dichvus.suaDichVu(dv))
                {
                    loadDGVDichVu();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSua = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                txtEnable(false);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            isSua = true;
            txtEnable(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (dgvDV.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dichvus.xoaDichVu(Int32.Parse(dgvDV.CurrentRow.Cells["MaDV"].Value.ToString())))
                {
                    loadDGVDichVu();
                    refesh();
                    MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isSua = false;
                isThem = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                txtEnable(false);

                txtTenDV.Text = dgvDV.CurrentRow.Cells["TenDV"].Value.ToString();
                txtGiaDV.Text = dgvDV.CurrentRow.Cells["GiaDV"].Value.ToString();
            }
        }
    }
}
