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

        public DatPhong layPhieuDatPhong(int id)
        {
            return db.DatPhongs.FirstOrDefault(t => t.MaDP == id);
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
    }
}
