using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_DichVu
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_DichVu()
        {
                
        }

        public List<DichVu> loadDichVu()
        {
            return db.DichVus.ToList();
        }
    }
}
