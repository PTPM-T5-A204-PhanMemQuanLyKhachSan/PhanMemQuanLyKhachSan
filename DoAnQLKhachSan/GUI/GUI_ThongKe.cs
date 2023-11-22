using BLL_DAL;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace GUI
{
    public partial class GUI_ThongKe : DevExpress.XtraEditors.XtraUserControl
    {
        ThongKe tk = new ThongKe();
        public GUI_ThongKe()
        {
            InitializeComponent();
        }



        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LoadDoanhThu();
            
        }

        private void GUI_ThongKe_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value =  DateTime.Now;
        }

        public void LoadDoanhThu()
        {
            chartControl1.Series.Clear();
            Series series1 = new Series("Doanh thu khách sạn", ViewType.Pie);

            List<DoanhThu> l = tk.LoadDanhThu(dateTimePicker1.Value, dateTimePicker2.Value);
            if(l.Count() < 1)
            {
                txtDTP.Text = "0 VND";
                txtDTDV.Text = "0 VND";
            }
            foreach (DoanhThu d in l)
            {
                series1.Points.Add(new SeriesPoint(d.LoaiDoanhThu, d.TongTien));

                if (d.LoaiDoanhThu == "Doanh Thu Phòng")
                {
                    double.TryParse(d.TongTien.ToString(), out double temp);
                    txtDTP.Text = string.Format("{0:N0} VND", temp);
                }
                else
                {
                    double.TryParse(d.TongTien.ToString(), out double temp);
                    txtDTDV.Text = string.Format("{0:N0} VND", temp);
                }
            }
            series1.Label.TextPattern = "{A}: {VP: p0}";
            chartControl1.Series.Add(series1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }
    }
}
