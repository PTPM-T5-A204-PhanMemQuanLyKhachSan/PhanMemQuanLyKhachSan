using System;
using System.Collections.Generic;
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
