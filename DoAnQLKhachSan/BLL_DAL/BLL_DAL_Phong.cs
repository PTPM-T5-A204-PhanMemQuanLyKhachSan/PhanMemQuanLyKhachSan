using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_Phong
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_Phong()
        {

        }

        public List<Phong> LoadPhong(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return db.Phongs.ToList();
            }
            else
            {
                return db.Phongs.Where(x => x.TenPhong.Contains(key) || x.LoaiPhong.TenLoai.Contains(key) || x.GiaPhong.ToString().Contains(key) || x.TrangThai.Contains(key)).ToList();
            }
        }

        public bool themPhong(Phong p)
        {
            try
            {
                db.Phongs.InsertOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaPhong(int ma)
        {
            try
            {
                Phong p = db.Phongs.FirstOrDefault(x => x.MaPhong == ma);
                if (p == null)
                {
                    return false;
                }
                ChiTietDatPhong ctdp = db.ChiTietDatPhongs.FirstOrDefault(x => x.MaPhong == ma);
                if (ctdp != null)
                {
                    return false;
                }
                db.Phongs.DeleteOnSubmit(p);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaPhong(Phong t)
        {
            try
            {
                Phong p = db.Phongs.FirstOrDefault(x => x.MaPhong == t.MaPhong);
                if (p == null)
                {
                    return false;
                }
                p.TenPhong = t.TenPhong;
                p.LoaiPhong = t.LoaiPhong;
                p.GiaPhong = t.GiaPhong;
                p.TrangThai = t.TrangThai;
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
