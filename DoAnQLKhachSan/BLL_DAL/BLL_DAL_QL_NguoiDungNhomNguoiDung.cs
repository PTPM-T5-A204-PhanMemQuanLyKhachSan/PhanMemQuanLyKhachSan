using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_QL_NguoiDungNhomNguoiDung
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_QL_NguoiDungNhomNguoiDung()
        {

        }

        public List<int> GetMaNhomNguoiDung(string nguoiDung)
        {
            return db.QL_NguoiDungNhomNguoiDungs.Where(t => t.TenDangNhap == nguoiDung).Select(t => t.MaNhomNguoiDung).ToList();
        }
    }
}
