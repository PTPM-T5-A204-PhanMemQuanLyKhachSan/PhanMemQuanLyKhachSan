using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_QL_NguoiDung
    {
        QLKhachSanDataContext qLKhachSan = new QLKhachSanDataContext();
        public BLL_DAL_QL_NguoiDung()
        {

        }
        public string Check_User(string pUser, string pPass)
        {
            QL_NguoiDung nd = qLKhachSan.QL_NguoiDungs.FirstOrDefault(t => t.TenDangNhap == pUser && t.MatKhau == pPass);
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
    }
}
