using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_QL_PhanQuyen
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_QL_PhanQuyen()
        {

        }

        public List<QL_PhanQuyen> GetMaManHinh(int maNhom)
        {
            return db.QL_PhanQuyens.Where(t => t.MaNhomNguoiDung == maNhom).ToList();
        }
    }
}
