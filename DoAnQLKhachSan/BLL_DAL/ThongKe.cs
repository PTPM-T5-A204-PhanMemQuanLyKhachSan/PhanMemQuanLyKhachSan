using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ThongKe
    {

        public List<DoanhThu> LoadDanhThu(DateTime bd, DateTime kt)
        {
            List<DoanhThu> list = new List<DoanhThu>();
            using (SqlConnection connection = new SqlConnection(BLL_DAL.Properties.Settings.Default.QLKhachSanConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.ThongKeDoanhThu(@StartDate, @EndDate)", connection))
                {
                    command.Parameters.AddWithValue("@StartDate", bd);
                    command.Parameters.AddWithValue("@EndDate", kt);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DoanhThu statistics = new DoanhThu
                            {
                                LoaiDoanhThu = Convert.ToString(reader["DoanhThuLoai"]),
                                TongTien = Convert.ToInt32(reader["DoanhThu"]),
                            };

                            list.Add(statistics);
                        }
                    }
                }
            }

            return list;
        }

        public int SoLuongPhong(DateTime bd, DateTime kt)
        {
            int count = 0;

            using (SqlConnection connection = new SqlConnection(BLL_DAL.Properties.Settings.Default.QLKhachSanConnectionString))
            {
                connection.Open();

                string query = "Select count(dp.MaDP) from DatPhong dp, HoaDon hd where dp.MaHD = hd.MaHD and NgayThanhToan >= @StartDate and NgayThanhToan <= @EndDate";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", bd);
                    command.Parameters.AddWithValue("@EndDate", kt);

                    count = (int)command.ExecuteScalar();
                }
            }

            return count;
        }

        public ThongKe()
        {

        }

    }
}
