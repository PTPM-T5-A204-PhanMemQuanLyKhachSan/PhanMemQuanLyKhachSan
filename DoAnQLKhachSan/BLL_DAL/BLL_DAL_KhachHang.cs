using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_KhachHang
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_KhachHang()
        {

        }

        public KhachHang layKHTheoId(int id)
        {
            return db.KhachHangs.FirstOrDefault(t => t.MaKH == id);
        }

        public List<KhachHang> LoadKhachHang(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return db.KhachHangs.ToList();
            }
            else
            {
                return db.KhachHangs.Where(x => x.HoTenKH.Contains(key) || x.CCCD.Contains(key) || x.DiaChi.Contains(key) || x.DienThoai.Contains(key)).ToList();
            }
        }

        public bool themKhachHang(KhachHang kh)
        {
            try
            {
                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaKhachHang(int ma)
        {
            try
            {
                KhachHang kh = db.KhachHangs.FirstOrDefault(x => x.MaKH == ma);
                if (kh == null)
                {
                    return false;
                }
                DatPhong dp = db.DatPhongs.FirstOrDefault(x => x.MaKH == ma);
                if (dp != null)
                {
                    return false;
                }
                db.KhachHangs.DeleteOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaKhachHang(KhachHang t)
        {
            try
            {
                KhachHang kh = db.KhachHangs.FirstOrDefault(x => x.MaKH == t.MaKH);
                if (kh == null)
                {
                    return false;
                }
                kh.HoTenKH = t.HoTenKH;
                kh.CCCD = t.CCCD;
                kh.DiaChi = t.DiaChi;
                kh.DienThoai = t.DienThoai;
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
