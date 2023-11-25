using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_QL_NguoiDung
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_QL_NguoiDung()
        {

        }

        public int GetMaNhomNguoiDung(string nguoiDung)
        {
            return (int)db.QL_NguoiDungs.FirstOrDefault(t => t.TenDangNhap == nguoiDung).MaNhomNguoiDung;
        }

        public string Check_User(string pUser, string pPass)
        {
            QL_NguoiDung nd = db.QL_NguoiDungs.FirstOrDefault(t => t.TenDangNhap == pUser && t.MatKhau == pPass);
            if (nd == null)
            {
                return "Invalid";
            }
            else
            {
                if (nd.HoatDong == false)
                    return "Disabled";
                else
                    return "Success";
            }
        }

        public List<Object> loadDS(string s)
        {
            var l = from qlnd in db.QL_NguoiDungs
                    select new
                    {
                        qlnd.NhanVien.HoTenNV,
                        qlnd.NhanVien.DienThoai,
                        qlnd.TenDangNhap,
                        qlnd.QL_NhomNguoiDung.TenNhom,
                        qlnd.HoatDong,
                        qlnd.MatKhau,
                        qlnd.MaNV,
                        qlnd.MaNhomNguoiDung
                    };
            if (s == string.Empty)
                return l.ToList<Object>();
            else
                return l.Where(t => t.TenDangNhap.Contains(s) || t.HoTenNV.Contains(s) || t.DienThoai.Contains(s)).ToList<Object>();
        }

        public bool ktMaNV(int ma)
        {
            QL_NguoiDung t = db.QL_NguoiDungs.FirstOrDefault(x => x.MaNV == ma);
            if (t != null)
                return false;
            return true;
        }

        public bool themTK(QL_NguoiDung tk)
        {
            try
            {
                QL_NguoiDung t = db.QL_NguoiDungs.FirstOrDefault(x => x.TenDangNhap == tk.TenDangNhap);
                if (t != null)
                {
                    return false;
                }

                db.QL_NguoiDungs.InsertOnSubmit(tk);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaTK(QL_NguoiDung tk)
        {
            try
            {
                QL_NguoiDung t = db.QL_NguoiDungs.FirstOrDefault(x => x.TenDangNhap == tk.TenDangNhap);
                if (t == null)
                {
                    return false;
                }

                QL_NguoiDung tkx = db.QL_NguoiDungs.FirstOrDefault(x => x.MaNV == tk.MaNV);
                if (tkx != null)
                {
                    if (tkx.TenDangNhap != tk.TenDangNhap)
                    {
                        return false;
                    }
                }

                t.MatKhau = tk.MatKhau;
                t.HoatDong = tk.HoatDong;
                t.MaNV = tk.MaNV;
                t.MaNhomNguoiDung = tk.MaNhomNguoiDung;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaTK(string tendn)
        {
            try
            {
                QL_NguoiDung t = db.QL_NguoiDungs.FirstOrDefault(x => x.TenDangNhap == tendn);
                if (t == null)
                {
                    return false;
                }
                db.QL_NguoiDungs.DeleteOnSubmit(t);
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
