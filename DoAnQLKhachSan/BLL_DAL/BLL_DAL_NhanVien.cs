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

        public int getMaNV(string tendn)
        {
            int manv = (from qlnd in db.QL_NguoiDungs
                        join nv in db.NhanViens on qlnd.MaNV equals nv.MaNV
                        where qlnd.TenDangNhap == tendn
                        select nv.MaNV).FirstOrDefault();
            return manv;
        }

        public string getTenNV(int ma)
        {
            return db.NhanViens.FirstOrDefault(t => t.MaNV == ma).HoTenNV;
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
                nv.DiaChi = temp.DiaChi;
                nv.DienThoai = temp.DienThoai;
                nv.Hinh = temp.Hinh;
                nv.Luong = temp.Luong;
                nv.Phai = temp.Phai;
                nv.NgaySinh = temp.NgaySinh;
                nv.NgayVaoLam = temp.NgayVaoLam;
                nv.TinhTrang = temp.TinhTrang;
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
                return db.NhanViens.Where(x => x.HoTenNV.Contains(key) || x.Phai.Contains(key) || x.DiaChi.Contains(key) || x.TinhTrang.Contains(key) || x.ChucVu.Contains(key)).ToList();
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
