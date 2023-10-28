using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API;
using API.ClassAPI;
using API.Model;

namespace DoAnQLKhachSan
{
    public partial class Form1 : Form
    {
        PhongAPI phongAPI=new PhongAPI();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadPhong();
        }

        public void loadPhong()
        {
            Object data = phongAPI.getAllPhong();
            PhongModel[] phongModels = data as PhongModel[];
            this.dataGridView2.DataSource = phongModels.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text==string.Empty)
            {
                MessageBox.Show( "nhập id can tim");
                return;
            }
            Object data=phongAPI.getPhongById(int.Parse(this.textBox1.Text));
            PhongModel phongModel = data as PhongModel;
            List<PhongModel> phongModels=new List<PhongModel> { phongModel};
            this.dataGridView2.DataSource = phongModels;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhongModel phongModel = new PhongModel
            {
                soPhong = "P05",
                loaiPhong = "Nong111",
                giaoPhong = 1
            };
            bool obj= phongAPI.addProduct(phongModel);
            if(obj)
            {
                MessageBox.Show("true");
                this.loadPhong();
            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            PhongModel phongModel = new PhongModel
            {
                maPhong=1,
                soPhong = "P05ccccc",
                loaiPhong = "Nong111",
                giaoPhong = 1
            };
            bool kq=phongAPI.updateProduct(phongModel);
            if (kq)
            {
                MessageBox.Show("true");
                this.loadPhong();
            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (this.txt_xoa.Text == string.Empty)
            {
                MessageBox.Show("Nhập id can xóa");
            }
            bool kq = phongAPI.deleteProduct(int.Parse(this.txt_xoa.Text));
            if (kq)
            {
                MessageBox.Show("xóa thành công");
                this.loadPhong();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
