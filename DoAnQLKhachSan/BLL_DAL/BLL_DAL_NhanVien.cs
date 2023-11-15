using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_NhanVien
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_NhanVien()
        {

        }

        public bool updateNhanVien(NhanVien temp)
        {
            try
            {
                NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == temp.MaNV);
                if (nv == null)
                {
                    return false;
                }
                nv.HoTenNV = temp.HoTenNV;
                nv.CCCD = temp.CCCD;
                nv.ChucVu = temp.ChucVu;
                nv.QueQuan = temp.QueQuan;
                nv.DienThoai = temp.DienThoai;
                nv.Hinh = temp.Hinh;
                nv.Luong = temp.Luong;
                nv.Phai = temp.Phai;
                nv.NgaySinh = temp.NgaySinh;
                nv.NgayVaoLam = temp.NgayVaoLam;
                nv.TinhTrang = temp.TinhTrang;
                nv.Hinh = temp.Hinh;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<NhanVien> loadDataNhanVien(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return db.NhanViens.ToList();
            }
            else
            {
                return db.NhanViens.Where(x => x.HoTenNV.Contains(key) || x.Phai.Contains(key) || x.QueQuan.Contains(key) || x.TinhTrang.Contains(key) || x.ChucVu.Contains(key)).ToList();
            }
        }

        public bool themNhanVien(NhanVien nv)
        {
            try
            {
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNhanVien(int ma)
        {
            try
            {
                NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == ma);
                if (nv == null)
                {
                    return false;
                }
                db.NhanViens.DeleteOnSubmit(nv);
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
