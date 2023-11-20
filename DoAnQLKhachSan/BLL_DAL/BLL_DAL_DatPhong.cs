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
        public bool themDatPhong(DatPhong dp)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
