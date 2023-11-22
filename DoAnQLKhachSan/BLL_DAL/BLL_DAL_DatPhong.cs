using System;
using System.Collections.Generic;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_DatPhong
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_DatPhong()
        {

        }

        public List<Object> layDPTheoKH(int id)
        {
            var l = from dp in db.DatPhongs
                    join p in db.Phongs on dp.MaPhong equals p.MaPhong
                    where dp.MaKH == id && dp.TrangThai == "Chưa thanh toán"
                    select new
                    {
                        MaDP = dp.MaDP,
                        TenPhong = p.TenPhong,
                        CheckIn = dp.CheckIn,
                        CheckOut = dp.CheckOut,
                        TongTien = dp.TongTien,
                        MaPhong = dp.MaPhong
                    };
            List<Object> list = l.ToList<Object>();
            return list;
        }

        public List<Object> layDSInHD(int id)
        {
            var l = from phong in db.Phongs
                    join datPhong in db.DatPhongs on phong.MaPhong equals datPhong.MaPhong
                    join hoaDon in db.HoaDons on datPhong.MaHD equals hoaDon.MaHD
                    where hoaDon.MaHD == id
                    select new
                    {
                        STT = 0,
                        TenPhong = phong.TenPhong,
                        GiaPhong = phong.GiaPhong,
                        SoNgay = ((DateTime)datPhong.CheckOut - (DateTime)datPhong.CheckIn).Days + 1,
                        TongTien = phong.GiaPhong * (((DateTime)datPhong.CheckOut - (DateTime)datPhong.CheckIn).Days + 1)
                    };
            var queryList = l.ToList();
            int stt = 1;

            // Cập nhật số thứ tự trong kết quả
            var t = queryList.Select(item => new
            {
                STT = stt++,
                item.TenPhong,
                item.GiaPhong,
                item.SoNgay,
                item.TongTien
            });
            List<Object> list = t.ToList<Object>();
            return list;
        }

        public DatPhong layDPTheoKey(int id)
        {
            return db.DatPhongs.FirstOrDefault(t => t.MaDP == id);
        }

        public DatPhong layPhieuDatPhongTheoPhong(int id)
        {
            return db.DatPhongs.FirstOrDefault(t => t.MaPhong == id && t.TrangThai == "Chưa thanh toán");
        }

        public DatPhong layDPTheoTrangThai(string trangthai)
        {
            return db.DatPhongs.FirstOrDefault(t => t.TrangThai == trangthai);
        }

        public bool themDatPhong(DatPhong dp)
        {
            try
            {
                db.DatPhongs.InsertOnSubmit(dp);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool capNhatDatPhong(DatPhong dp)
        {
            try
            {
                DatPhong temp = db.DatPhongs.FirstOrDefault(t => t.MaDP == dp.MaDP);
                temp.CheckIn = dp.CheckIn;
                temp.CheckOut = dp.CheckOut;
                temp.TongTien = dp.TongTien;
                temp.TrangThai = dp.TrangThai;
                temp.MaKH = dp.MaKH;
                temp.MaPhong = dp.MaPhong;
                temp.MaHD = dp.MaHD;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
