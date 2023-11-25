using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_BAL_QL_NhomNguoiDung
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_BAL_QL_NhomNguoiDung()
        {

        }

        public List<QL_NhomNguoiDung> loadNhomQuyen()
        {
            return db.QL_NhomNguoiDungs.ToList<QL_NhomNguoiDung>();
        }
    }
}
