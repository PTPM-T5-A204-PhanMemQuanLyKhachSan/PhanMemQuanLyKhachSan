using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_LoaiPhong
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_LoaiPhong()
        {

        }

        public List<LoaiPhong> LoadLoaiPhong()
        {
            return db.LoaiPhongs.ToList();
        }
    }
}
